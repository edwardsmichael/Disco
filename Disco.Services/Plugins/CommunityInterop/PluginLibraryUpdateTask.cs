﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Disco.Data.Repository;
using Disco.Services.Plugins;
using Disco.Services.Tasks;
using Disco.Models.BI.Interop.Community;
using System.Net;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Quartz;

namespace Disco.Services.Plugins.CommunityInterop
{
    public class PluginLibraryUpdateTask : ScheduledTask
    {
        public override string TaskName { get { return "Disco Community - Update Plugin Library"; } }

        public static string CurrentDiscoVersion()
        {
            var AssemblyVersion = typeof(PluginLibraryUpdateTask).Assembly.GetName().Version;
            return string.Format("{0}.{1}.{2:0000}.{3:0000}", AssemblyVersion.Major, AssemblyVersion.Minor, AssemblyVersion.Build, AssemblyVersion.Revision);
        }

        protected override void ExecuteTask()
        {
            ExecuteTaskInternal(this.Status);
            Status.SetFinishedMessage("The Plugin Library Catalogue was updated.");
        }

        internal static void ExecuteTaskInternal(ScheduledTaskStatus Status)
        {
            PluginLibraryUpdateRequest updateRequestBody;
            PluginLibraryUpdateResponse updateResult;
            string catalogueFile;
            PluginLibraryCompatibilityRequest compatRequestBody;
            PluginLibraryCompatibilityResponse compatResult;
            string compatibilityFile;

            var DiscoBIVersion = CurrentDiscoVersion();
            HttpWebRequest webRequest;

            #region Update

            Status.UpdateStatus(1, "Updating Plugin Library Catalogue", "Building Request");

            using (DiscoDataContext database = new DiscoDataContext())
            {
                catalogueFile = Plugins.CatalogueFile(database);

                updateRequestBody = new PluginLibraryUpdateRequest()
                {
                    DeploymentId = database.DiscoConfiguration.DeploymentId,
                    HostVersion = typeof(Plugins).Assembly.GetName().Version.ToString(4)
                };
            }

            Status.UpdateStatus(10, "Sending Request");

            webRequest = (HttpWebRequest)HttpWebRequest.Create(PluginLibraryUpdateUrl());
            webRequest.KeepAlive = false;

            webRequest.ContentType = "application/xml";
            webRequest.Method = WebRequestMethods.Http.Post;
            webRequest.UserAgent = string.Format("Disco/{0} (PluginLibrary)", DiscoBIVersion);

            using (var wrStream = webRequest.GetRequestStream())
            {
                XmlSerializer xml = new XmlSerializer(typeof(PluginLibraryUpdateRequest));
                xml.Serialize(wrStream, updateRequestBody);
            }

            Status.UpdateStatus(20, "Waiting for Response");

            using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse())
            {
                if (webResponse.StatusCode == HttpStatusCode.OK)
                {
                    Status.UpdateStatus(45, "Reading Response");
                    using (var wResStream = webResponse.GetResponseStream())
                    {
                        XmlSerializer xml = new XmlSerializer(typeof(PluginLibraryUpdateResponse));
                        updateResult = (PluginLibraryUpdateResponse)xml.Deserialize(wResStream);
                    }
                }
                else
                {
                    Status.SetTaskException(new WebException(string.Format("Server responded with: [{0}] {1}", webResponse.StatusCode, webResponse.StatusDescription)));
                    return;
                }
            }

            if (!Directory.Exists(Path.GetDirectoryName(catalogueFile)))
                Directory.CreateDirectory(Path.GetDirectoryName(catalogueFile));

            using (FileStream fs = new FileStream(catalogueFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter fsWriter = new StreamWriter(fs))
                {
                    fsWriter.Write(JsonConvert.SerializeObject(updateResult));
                    fsWriter.Flush();
                }
            }
            #endregion

            #region Compatibility

            Status.UpdateStatus(50, "Updating Plugin Library Compatibility", "Building Request");

            using (DiscoDataContext database = new DiscoDataContext())
            {
                compatibilityFile = Plugins.CompatibilityFile(database);

                compatRequestBody = new PluginLibraryCompatibilityRequest()
                {
                    DeploymentId = database.DiscoConfiguration.DeploymentId,
                    HostVersion = typeof(Plugins).Assembly.GetName().Version.ToString(4)
                };
            }

            Status.UpdateStatus(60, "Sending Request");

            webRequest = (HttpWebRequest)HttpWebRequest.Create(PluginLibraryCompatibilityUrl());
            webRequest.KeepAlive = false;

            webRequest.ContentType = "application/json";
            webRequest.Method = WebRequestMethods.Http.Post;
            webRequest.UserAgent = string.Format("Disco/{0} (PluginLibrary)", DiscoBIVersion);

            using (var wrStream = webRequest.GetRequestStream())
            {
                XmlSerializer xml = new XmlSerializer(typeof(PluginLibraryCompatibilityRequest));
                xml.Serialize(wrStream, compatRequestBody);
            }

            Status.UpdateStatus(70, "Waiting for Response");

            using (HttpWebResponse webResponse = (HttpWebResponse)webRequest.GetResponse())
            {
                if (webResponse.StatusCode == HttpStatusCode.OK)
                {
                    Status.UpdateStatus(95, "Reading Response");
                    using (var wResStream = webResponse.GetResponseStream())
                    {
                        XmlSerializer xml = new XmlSerializer(typeof(PluginLibraryCompatibilityResponse));
                        compatResult = (PluginLibraryCompatibilityResponse)xml.Deserialize(wResStream);
                    }
                }
                else
                {
                    Status.SetTaskException(new WebException(string.Format("Server responded with: [{0}] {1}", webResponse.StatusCode, webResponse.StatusDescription)));
                    return;
                }
            }

            if (!Directory.Exists(Path.GetDirectoryName(compatibilityFile)))
                Directory.CreateDirectory(Path.GetDirectoryName(compatibilityFile));

            using (FileStream fs = new FileStream(compatibilityFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                using (StreamWriter fsWriter = new StreamWriter(fs))
                {
                    fsWriter.Write(JsonConvert.SerializeObject(compatResult));
                    fsWriter.Flush();
                }
            }
            #endregion
        }

        private static string PluginLibraryUpdateUrl()
        {
            return string.Concat(Disco.Data.Configuration.CommunityHelpers.CommunityUrl(), "DiscoPluginLibrary/V1");
        }
        private static string PluginLibraryCompatibilityUrl()
        {
            return string.Concat(Disco.Data.Configuration.CommunityHelpers.CommunityUrl(), "DiscoPluginLibrary/CompatibilityV1");
        }

        public static ScheduledTaskStatus ScheduleNow()
        {

            var taskStatus = ScheduledTasks.GetTaskStatuses(typeof(PluginLibraryUpdateTask)).Where(ts => ts.IsRunning).FirstOrDefault();
            if (taskStatus != null)
                return taskStatus;
            else
            {
                var t = new PluginLibraryUpdateTask();
                return t.ScheduleTask();
            }
        }
        public static ScheduledTaskStatus RunningStatus
        {
            get
            {
                return ScheduledTasks.GetTaskStatuses(typeof(PluginLibraryUpdateTask)).Where(ts => ts.IsRunning).FirstOrDefault();
            }
        }

        public override void InitalizeScheduledTask(DiscoDataContext Database)
        {
            // Random time between midday and midnight.
            var rnd = new Random();

            var rndHour = rnd.Next(12, 23);
            var rndMinute = rnd.Next(0, 59);

            TriggerBuilder triggerBuilder = TriggerBuilder.Create().
                WithSchedule(CronScheduleBuilder.DailyAtHourAndMinute(rndHour, rndMinute));

            this.ScheduleTask(triggerBuilder);
        }
    }
}
