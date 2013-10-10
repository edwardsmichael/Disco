﻿using Disco.Services.Authorization;
using Disco.Services.Logging;
using Disco.Services.Tasks;
using Disco.Services.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace Disco.Web.Areas.API.Controllers
{
    public partial class LoggingController : AuthorizedDatabaseController
    {
        [DiscoAuthorize(Claims.Config.Logging.Show)]
        public virtual ActionResult Modules()
        {
            var m = LogContext.LogModules.Values.Select(lm => Models.Logs.LogModuleModel.FromLogModule(lm)).ToList();

            return Json(m, JsonRequestBehavior.AllowGet);
        }

        [DiscoAuthorize(Claims.Config.Logging.Show)]
        public virtual ActionResult RetrieveEvents(string Format, DateTime? Start = null, DateTime? End = null, int? ModuleId = null, List<int> EventTypeIds = null, int? Take = null)
        {
             var logRetriever = new ReadLogContext()
            {
                Start = Start,
                End = End,
                Module = ModuleId,
                EventTypes = EventTypeIds,
                Take = Take
            };
            var results = logRetriever.Query(Database);

            switch (Format.ToLower())
            {
                case "json":
                    {
                        return Json(results, JsonRequestBehavior.AllowGet);
                    }
                case "csv":
                    {
                        return File(results.ToCsv(), "text/csv", "DiscoLogs.csv");
                    }
                default:
                    {
                        throw new ArgumentException("Unknown Format", "Format");
                    }
            }

        }

        public virtual ActionResult ScheduledTaskStatus(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException("id");

            var status = ScheduledTasks.GetTaskStatus(id);

            if (status == null)
                throw new ArgumentException("Invalid ScheduledTask SessionId", "id");

            return Json(ScheduledTaskStatusLive.FromScheduledTaskStatus(status, null), JsonRequestBehavior.AllowGet);
        }
    }
}
