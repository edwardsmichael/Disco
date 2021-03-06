﻿using System;
using System.Collections.Generic;
using System.Linq;
using Disco.Data.Repository;
using Disco.Models.BI.Config;
using Disco.Models.Repository;
using Disco.Services.Plugins;
using Disco.Services.Plugins.Features.WarrantyProvider;
using Disco.Services.Users;
using Disco.Services.Authorization;

namespace Disco.BI.Extensions
{
    public static class JobActionExtensions
    {

        #region Device Held
        public static bool CanDeviceHeld(this Job j)
        {
            if (!UserService.CurrentAuthorization.Has(Claims.Job.Properties.DeviceHeld))
                return false;

            return (!j.ClosedDate.HasValue) && (j.DeviceSerialNumber != null) &&
                (!j.DeviceHeld.HasValue || j.DeviceReturnedDate.HasValue);
        }
        public static void OnDeviceHeld(this Job j, User Technician)
        {
            if (!j.CanDeviceHeld())
                throw new InvalidOperationException("Holding Device was Denied");

            j.DeviceHeld = DateTime.Now;
            j.DeviceHeldTechUserId = Technician.Id;
            j.DeviceReadyForReturn = null;
            j.DeviceReadyForReturnTechUserId = null;
            j.DeviceReturnedDate = null;
            j.DeviceReturnedTechUserId = null;
        }
        #endregion

        #region Device Ready for Return
        public static bool CanDeviceReadyForReturn(this Job j)
        {
            if (!UserService.CurrentAuthorization.Has(Claims.Job.Properties.DeviceReadyForReturn))
                return false;

            return (!j.ClosedDate.HasValue) && j.DeviceHeld.HasValue &&
                !j.DeviceReadyForReturn.HasValue && !j.DeviceReturnedDate.HasValue;
        }
        public static void OnDeviceReadyForReturn(this Job j, User Technician)
        {
            if (!j.CanDeviceReadyForReturn())
                throw new InvalidOperationException("Device Ready for Return was Denied");

            j.DeviceReadyForReturn = DateTime.Now;
            j.DeviceReadyForReturnTechUserId = Technician.Id;
        }
        #endregion

        #region Device Returned
        public static bool CanDeviceReturned(this Job j)
        {
            if (!UserService.CurrentAuthorization.Has(Claims.Job.Properties.DeviceReturned))
                return false;

            return (!j.ClosedDate.HasValue) && j.DeviceHeld.HasValue &&
                !j.DeviceReturnedDate.HasValue;
        }
        public static void OnDeviceReturned(this Job j, User Technician)
        {
            if (!j.CanDeviceReturned())
                throw new InvalidOperationException("Device Return was Denied");

            j.DeviceReturnedDate = DateTime.Now;
            j.DeviceReturnedTechUserId = Technician.Id;
        }
        #endregion

        #region Waiting For User Action
        public static bool CanWaitingForUserAction(this Job j)
        {
            if (!UserService.CurrentAuthorization.Has(Claims.Job.Properties.WaitingForUserAction))
                return false;

            return !j.ClosedDate.HasValue && (j.UserId != null) && !j.WaitingForUserAction.HasValue;
        }
        public static void OnWaitingForUserAction(this Job j, DiscoDataContext Database, User Technician, string Reason)
        {
            if (!j.CanWaitingForUserAction())
                throw new InvalidOperationException("Waiting for User Action was Denied");

            j.WaitingForUserAction = DateTime.Now;

            // Write Log
            JobLog jobLog = new JobLog()
            {
                JobId = j.Id,
                TechUserId = Technician.Id,
                Timestamp = DateTime.Now,
                Comments = string.Format("Waiting on User Action{0}Reason: {1}", Environment.NewLine, Reason)
            };
            Database.JobLogs.Add(jobLog);
        }
        #endregion

        #region Not Waiting For User Action
        public static bool CanNotWaitingForUserAction(this Job j)
        {
            if (!UserService.CurrentAuthorization.Has(Claims.Job.Properties.NotWaitingForUserAction))
                return false;

            return j.WaitingForUserAction.HasValue;
        }
        public static void OnNotWaitingForUserAction(this Job j, DiscoDataContext Database, User Technician, string Resolution)
        {
            if (!j.CanNotWaitingForUserAction())
                throw new InvalidOperationException("Not Waiting for User Action was Denied");

            j.WaitingForUserAction = null;

            // Write Log
            JobLog jobLog = new JobLog()
            {
                JobId = j.Id,
                TechUserId = Technician.Id,
                Timestamp = DateTime.Now,
                Comments = string.Format("User Action Resolved{0}Resolution: {1}", Environment.NewLine, Resolution)
            };
            Database.JobLogs.Add(jobLog);
        }
        #endregion

        #region Log Warranty
        public static bool CanLogWarranty(this Job j)
        {
            if (!UserService.CurrentAuthorization.Has(Claims.Job.Actions.LogWarranty))
                return false;
            
            return !j.ClosedDate.HasValue &&
                (j.DeviceSerialNumber != null) &&
                j.JobTypeId == JobType.JobTypeIds.HWar &&
                string.IsNullOrEmpty(j.JobMetaWarranty.ExternalReference);
        }
        public static void OnLogWarranty(this Job j, DiscoDataContext Database, string FaultDescription, PluginFeatureManifest WarrantyProviderDefinition, OrganisationAddress Address, User TechUser, Dictionary<string, string> WarrantyProviderProperties)
        {
            if (!j.CanLogWarranty())
                throw new InvalidOperationException("Log Warranty was Denied");

            if (string.IsNullOrWhiteSpace(FaultDescription))
                FaultDescription = j.GenerateFaultDescriptionFooter(Database, WarrantyProviderDefinition);
            else
                FaultDescription = string.Concat(FaultDescription, Environment.NewLine, Environment.NewLine, j.GenerateFaultDescriptionFooter(Database, WarrantyProviderDefinition));

            using (WarrantyProviderFeature WarrantyProvider = WarrantyProviderDefinition.CreateInstance<WarrantyProviderFeature>())
            {
                string providerRef = WarrantyProvider.SubmitJob(Database, j, Address, TechUser, FaultDescription, WarrantyProviderProperties);

                j.JobMetaWarranty.ExternalLoggedDate = DateTime.Now;
                j.JobMetaWarranty.ExternalName = WarrantyProvider.WarrantyProviderId;

                if (providerRef.Length > 100)
                    j.JobMetaWarranty.ExternalReference = providerRef.Substring(0, 100);
                else
                    j.JobMetaWarranty.ExternalReference = providerRef;

                // Write Log
                JobLog jobLog = new JobLog()
                {
                    JobId = j.Id,
                    TechUserId = TechUser.Id,
                    Timestamp = DateTime.Now,
                    Comments = string.Format("Warranty Claim Submitted{0}{0}Provider: {1}{0}Repair Address: {2}{0}Provider Reference: {3}{0}{0}{4}", Environment.NewLine, WarrantyProvider.Manifest.Name, Address.Name, providerRef, FaultDescription)
                };
                Database.JobLogs.Add(jobLog);
            }
        }
        #endregion

        #region Convert HWar to HNWar
        public static bool CanConvertHWarToHNWar(this Job j)
        {
            if (!UserService.CurrentAuthorization.Has(Claims.Job.Actions.ConvertHWarToHNWar))
                return false;

            return !j.ClosedDate.HasValue && (j.DeviceSerialNumber != null) &&
                j.JobTypeId == JobType.JobTypeIds.HWar && string.IsNullOrEmpty(j.JobMetaWarranty.ExternalReference);
        }
        public static void OnConvertHWarToHNWar(this Job j, DiscoDataContext Database)
        {
            if (!j.CanConvertHWarToHNWar())
                throw new InvalidOperationException("Convert HWar to HNWar was Denied");

            var techUser = UserService.CurrentUser;

            // Remove JobMetaWarranty
            if (j.JobMetaWarranty != null)
                Database.JobMetaWarranties.Remove(j.JobMetaWarranty);

            // Add JobMetaNonWarranty
            var metaHNWar = new JobMetaNonWarranty() { Job = j };
            Database.JobMetaNonWarranties.Add(metaHNWar);

            // Swap Job Sub Types
            List<string> jobSubTypes = j.JobSubTypes.Select(jst => jst.Id).ToList();
            j.JobSubTypes.Clear();
            foreach (var jst in Database.JobSubTypes.Where(i => i.JobTypeId == JobType.JobTypeIds.HNWar && jobSubTypes.Contains(i.Id)))
                j.JobSubTypes.Add(jst);

            // Add Components
            var components = Database.DeviceComponents.Include("JobSubTypes").Where(c => !c.DeviceModelId.HasValue || c.DeviceModelId == j.Device.DeviceModelId);
            var jobComponents = new List<DeviceComponent>();
            foreach (var component in components)
            {
                if (!component.DeviceModelId.HasValue)
                {
                    jobComponents.Add(component);
                }
                else
                {
                    foreach (var st in component.JobSubTypes)
                    {
                        foreach (var jst in j.JobSubTypes)
                        {
                            if (st.JobTypeId == jst.JobTypeId && st.Id == jst.Id)
                            {
                                jobComponents.Add(component);
                                break;
                            }
                        }
                        if (jobComponents.Contains(component))
                            break;
                    }
                }
            }
            foreach (var component in jobComponents)
            {
                Database.JobComponents.Add(new JobComponent()
                {
                    Job = j,
                    TechUserId = techUser.Id,
                    Cost = component.Cost,
                    Description = component.Description
                });
            }

            // Write Log
            JobLog jobLog = new JobLog()
            {
                JobId = j.Id,
                TechUserId = techUser.Id,
                Timestamp = DateTime.Now,
                Comments = string.Format("Job Type Converted{0}From: {1}{0}To: {2}", Environment.NewLine, Database.JobTypes.Find(JobType.JobTypeIds.HWar), Database.JobTypes.Find(JobType.JobTypeIds.HNWar))
            };
            Database.JobLogs.Add(jobLog);

            j.JobTypeId = JobType.JobTypeIds.HNWar;
        }
        #endregion

        #region Warranty Completed
        public static bool CanWarrantyCompleted(this Job j)
        {
            return (j.JobTypeId == JobType.JobTypeIds.HWar) &&
                j.JobMetaWarranty.ExternalLoggedDate.HasValue &&
                !j.JobMetaWarranty.ExternalCompletedDate.HasValue;
        }
        public static void OnWarrantyCompleted(this Job j)
        {
            if (!j.CanWarrantyCompleted())
                throw new InvalidOperationException("Warranty Completed was Denied");

            j.JobMetaWarranty.ExternalCompletedDate = DateTime.Now;
        }
        #endregion

        #region Insurance Claim Form Sent
        public static bool CanInsuranceClaimFormSent(this Job j)
        {
            if (!UserService.CurrentAuthorization.Has(Claims.Job.Properties.NonWarrantyProperties.InsuranceClaimFormSent))
                return false;

            return (j.JobTypeId == JobType.JobTypeIds.HNWar) &&
                j.JobMetaNonWarranty.IsInsuranceClaim &&
                !j.JobMetaInsurance.ClaimFormSentDate.HasValue;
        }
        public static void OnInsuranceClaimFormSent(this Job j)
        {
            if (!j.CanInsuranceClaimFormSent())
                throw new InvalidOperationException("Insurance Claim Form Sent was Denied");

            var techUser = UserService.CurrentUser;

            j.JobMetaInsurance.ClaimFormSentDate = DateTime.Now;
            j.JobMetaInsurance.ClaimFormSentUserId = techUser.Id;
        }
        #endregion

        #region Log Repair
        public static bool CanLogRepair(this Job j)
        {
            if (!UserService.CurrentAuthorization.Has(Claims.Job.Actions.LogRepair))
                return false;

            return (j.JobTypeId == JobType.JobTypeIds.HNWar) &&
                (j.DeviceSerialNumber != null) &&
                !j.JobMetaNonWarranty.RepairerLoggedDate.HasValue &&
                !j.JobMetaNonWarranty.RepairerCompletedDate.HasValue;
        }
        public static void OnLogRepair(this Job j, string RepairerName, string RepairerReference)
        {
            if (!j.CanLogRepair())
                throw new InvalidOperationException("Log Repair was Denied");

            if (j.JobMetaNonWarranty.RepairerName != RepairerName)
                j.JobMetaNonWarranty.RepairerName = RepairerName;
            if (j.JobMetaNonWarranty.RepairerReference != RepairerReference)
                j.JobMetaNonWarranty.RepairerReference = RepairerReference;
            j.JobMetaNonWarranty.RepairerLoggedDate = DateTime.Now;
        }
        #endregion

        #region Repair Complete
        public static bool CanRepairComplete(this Job j)
        {
            if (!UserService.CurrentAuthorization.Has(Claims.Job.Properties.NonWarrantyProperties.RepairerCompletedDate))
                return false;

            return (j.JobTypeId == JobType.JobTypeIds.HNWar) &&
                j.JobMetaNonWarranty.RepairerLoggedDate.HasValue &&
                !j.JobMetaNonWarranty.RepairerCompletedDate.HasValue;
        }
        public static void OnRepairComplete(this Job j)
        {
            if (!j.CanRepairComplete())
                throw new InvalidOperationException("Repair Complete was Denied");

            j.JobMetaNonWarranty.RepairerCompletedDate = DateTime.Now;
        }
        #endregion

        #region Close
        public static bool CanClose(this Job j)
        {
            if (!UserService.CurrentAuthorization.Has(Claims.Job.Actions.Close))
                return false;

            if (j.ClosedDate.HasValue)
                return false; // Job already Closed

            if (j.DeviceHeld.HasValue && !j.DeviceReturnedDate.HasValue)
                return false; // Device not returned to User

            if (j.WaitingForUserAction.HasValue)
                return false; // Job waiting on User Action

            switch (j.JobTypeId)
            {
                case JobType.JobTypeIds.HWar:
                    if (!string.IsNullOrEmpty(j.JobMetaWarranty.ExternalReference) && !j.JobMetaWarranty.ExternalCompletedDate.HasValue)
                        return false; // Job Logged (Warranty) but not completed
                    break;
                case JobType.JobTypeIds.HNWar:
                    if (j.JobMetaNonWarranty.RepairerLoggedDate.HasValue && !j.JobMetaNonWarranty.RepairerCompletedDate.HasValue)
                        return false; // Job Logged (Repair) but not completed
                    if (j.JobMetaNonWarranty.AccountingChargeRequiredDate.HasValue && (!j.JobMetaNonWarranty.AccountingChargePaidDate.HasValue || !j.JobMetaNonWarranty.AccountingChargeAddedDate.HasValue))
                        return false; // Accounting Charge Required, but not added or paid

                    if (j.JobMetaNonWarranty.AccountingChargeAddedDate.HasValue && !j.JobMetaNonWarranty.AccountingChargePaidDate.HasValue)
                        return false; // Accounting Charge Added, but not paid

                    if (j.JobMetaNonWarranty.IsInsuranceClaim && !j.JobMetaInsurance.ClaimFormSentDate.HasValue)
                        return false; // Is Insurance Claim, but claim form not sent
                    break;
            }

            return true;
        }
        public static void OnClose(this Job j, User Technician)
        {
            if (!j.CanClose())
                throw new InvalidOperationException("Close was Denied");

            j.ClosedDate = DateTime.Now;
            j.ClosedTechUserId = Technician.Id;
        }
        #endregion

        #region Force Close
        public static bool CanForceClose(this Job j)
        {
            if (!UserService.CurrentAuthorization.Has(Claims.Job.Actions.ForceClose))
                return false;

            var canCloseNormally = j.CanClose();

            if (canCloseNormally)
                return false;

            // Check for Override
            if (j.ClosedDate.HasValue)
                return false; // Job already Closed

            if (j.DeviceHeld.HasValue && !j.DeviceReturnedDate.HasValue)
                return false; // Device not returned to User

            if (j.WaitingForUserAction.HasValue)
                return false; // Job waiting on User Action

            switch (j.JobTypeId)
            {
                case JobType.JobTypeIds.HWar:
                    if (!string.IsNullOrEmpty(j.JobMetaWarranty.ExternalReference) && !j.JobMetaWarranty.ExternalCompletedDate.HasValue)
                        return true; // Job Logged (Warranty) but not completed
                    break;
                case JobType.JobTypeIds.HNWar:
                    if (j.JobMetaNonWarranty.RepairerLoggedDate.HasValue && !j.JobMetaNonWarranty.RepairerCompletedDate.HasValue)
                        return true; // Job Logged (Repair) but not completed
                    if (j.JobMetaNonWarranty.AccountingChargeRequiredDate.HasValue && (!j.JobMetaNonWarranty.AccountingChargePaidDate.HasValue || !j.JobMetaNonWarranty.AccountingChargeAddedDate.HasValue))
                        return true; // Accounting Charge Required, but not added or paid

                    if (j.JobMetaNonWarranty.AccountingChargeAddedDate.HasValue && !j.JobMetaNonWarranty.AccountingChargePaidDate.HasValue)
                        return true; // Accounting Charge Added, but not paid

                    if (j.JobMetaNonWarranty.IsInsuranceClaim && !j.JobMetaInsurance.ClaimFormSentDate.HasValue)
                        return true; // Is Insurance Claim, but claim form not sent
                    break;
            }

            return false;
        }
        public static void OnForceClose(this Job j, DiscoDataContext Database, User Technician, string Reason)
        {
            if (!j.CanForceClose())
                throw new InvalidOperationException("Force Close was Denied");

            // Write Log
            JobLog jobLog = new JobLog()
            {
                JobId = j.Id,
                TechUserId = Technician.Id,
                Timestamp = DateTime.Now,
                Comments = string.Format("Job Forcibly Closed{0}Reason: {1}", Environment.NewLine, Reason)
            };
            Database.JobLogs.Add(jobLog);

            j.ClosedDate = DateTime.Now;
            j.ClosedTechUserId = Technician.Id;
        }
        #endregion

        #region Reopen
        public static bool CanReopen(this Job j)
        {
            if (!UserService.CurrentAuthorization.Has(Claims.Job.Actions.Reopen))
                return false;

            return j.ClosedDate.HasValue;
        }
        public static void OnReopen(this Job j)
        {
            if (!j.CanReopen())
                throw new InvalidOperationException("Reopen was Denied");

            j.ClosedDate = null;
            j.ClosedTechUserId = null;
        }
        #endregion

        #region Delete
        public static bool CanDelete(this Job j)
        {
            if (!UserService.CurrentAuthorization.Has(Claims.Job.Actions.Delete))
                return false;

            return j.ClosedDate.HasValue;
        }
        public static void OnDelete(this Job j, DiscoDataContext Database)
        {
            // Job Sub Types
            j.JobSubTypes.Clear();

            // Job Attachments
            foreach (var ja in j.JobAttachments.ToArray())
                ja.OnDelete(Database);
            j.JobAttachments.Clear();

            // Job Components
            foreach (var jc in j.JobComponents.ToArray())
                Database.JobComponents.Remove(jc);
            j.JobComponents.Clear();

            // Job Logs
            foreach (var jl in j.JobLogs.ToArray())
                Database.JobLogs.Remove(jl);
            j.JobLogs.Clear();

            // Job Meta
            if (j.JobMetaInsurance != null)
            {
                Database.JobMetaInsurances.Remove(j.JobMetaInsurance);
                j.JobMetaInsurance = null;
            }
            if (j.JobMetaNonWarranty != null)
            {
                Database.JobMetaNonWarranties.Remove(j.JobMetaNonWarranty);
                j.JobMetaNonWarranty = null;
            }
            if (j.JobMetaWarranty != null)
            {
                Database.JobMetaWarranties.Remove(j.JobMetaWarranty);
                j.JobMetaWarranty = null;
            }

            // Job
            Database.Jobs.Remove(j);
        }
        #endregion
    }
}
