﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web.Areas.Config.Views.DocumentTemplate
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DocumentTemplate/ImportStatus.cshtml")]
    public partial class ImportStatus : Disco.Services.Web.WebViewPage<dynamic>
    {
        public ImportStatus()
        {
        }
        public override void Execute()
        {
            
            #line 1 "..\..\Areas\Config\Views\DocumentTemplate\ImportStatus.cshtml"
  
    Authorization.Require(Claims.Config.DocumentTemplate.ShowStatus);
    
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Document Templates", MVC.Config.DocumentTemplate.Index(), "Import Status");
    Html.BundleDeferred("~/ClientScripts/Modules/Knockout");
    Html.BundleDeferred("~/ClientScripts/Modules/jQuery-SignalR");

            
            #line default
            #line hidden
WriteLiteral("\r\n<h2>Documents Imported Today\r\n</h2>\r\n<div");

WriteLiteral(" id=\"importStatus\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"noSessions\"");

WriteLiteral(" data-bind=\"visible: noSessions\"");

WriteLiteral(">\r\n        <h3>No imported documents today</h3>\r\n    </div>\r\n    <div");

WriteLiteral(" id=\"sessions\"");

WriteLiteral(" data-bind=\"visible: !noSessions(), foreach: { data: sessions, afterRender: sessi" +
"onRendered }\"");

WriteLiteral("\r\n        style=\"display: none\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"session\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"sessionLeftPane\"");

WriteLiteral(">\r\n                    <h3>\r\n                        <span");

WriteLiteral(" data-bind=\"text: title\"");

WriteLiteral("></span>\r\n                    </h3>\r\n                </div>\r\n                <div" +
"");

WriteLiteral(" class=\"sessionRightPane\"");

WriteLiteral(">\r\n                    <p");

WriteLiteral(" class=\"sessionStart\"");

WriteLiteral(" data-bind=\"text: startTime\"");

WriteLiteral(">\r\n                    </p>\r\n                    <p");

WriteLiteral(" class=\"sessionStatus\"");

WriteLiteral(" data-bind=\"text: progressStatus\"");

WriteLiteral(">\r\n                    </p>\r\n                    <div");

WriteLiteral(" data-bind=\"visible: !sessionEnded(), progressValue: progressValue\"");

WriteLiteral(" class=\"sessionProgress\"");

WriteLiteral(">\r\n                    </div>\r\n                </div>\r\n            </div>\r\n      " +
"      <div");

WriteLiteral(" class=\"sessionPages clearfix\"");

WriteLiteral(" data-bind=\"foreach: { data: sessionPages }\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"sessionPage\"");

WriteLiteral(" data-bind=\"style: { backgroundImage: thumbnailUrl }\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"sessionPageDetails\"");

WriteLiteral(">\r\n                        <h3");

WriteLiteral(" data-bind=\"text: title\"");

WriteLiteral("></h3>\r\n                        <div");

WriteLiteral(" data-bind=\"visible: undetected\"");

WriteLiteral(">\r\n                            Disco QR-Code not found<br />\r\n                   " +
"         <a");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" data-bind=\"attr: { href: manuallyAssignUrl }, visible: $parent.sessionEnded\"");

WriteLiteral(">Manually Assign Page</a>\r\n                        </div>\r\n                      " +
"  <div");

WriteLiteral(" data-bind=\"visible: detected\"");

WriteLiteral(">\r\n                            Document: <a");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" data-bind=\"text: documentTemplate, attr: { href: documentTemplateUrl }\"");

WriteLiteral("></a>\r\n                            <br />\r\n                            Target: <a" +
"");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" data-bind=\"text: assignedData, attr: { href: assignedDataUrl }\"");

WriteLiteral("></a>\r\n                        </div>\r\n                        <div");

WriteLiteral(" data-bind=\"visible: !(detected() || undetected())\"");

WriteLiteral(">\r\n                            <p");

WriteLiteral(" class=\"sessionStatus\"");

WriteLiteral(" data-bind=\"text: progressStatus\"");

WriteLiteral(">\r\n                            </p>\r\n                            <div");

WriteLiteral(" data-bind=\"progressValue: progressValue\"");

WriteLiteral(" class=\"sessionProgress\"");

WriteLiteral(">\r\n                            </div>\r\n                        </div>\r\n          " +
"          </div>\r\n                </div>\r\n            </div>\r\n            <div");

WriteLiteral(" class=\"sessionInfoMessages\"");

WriteLiteral(">\r\n                <table");

WriteLiteral(" class=\"logEventsViewport\"");

WriteLiteral(">\r\n                    <thead>\r\n                        <tr>\r\n                   " +
"         <th");

WriteLiteral(" class=\"icon\"");

WriteLiteral(">&nbsp;\r\n                            </th>\r\n                            <th");

WriteLiteral(" class=\"message\"");

WriteLiteral(">Message\r\n                            </th>\r\n                        </tr>\r\n     " +
"               </thead>\r\n                </table>\r\n                <div");

WriteLiteral(" class=\"logEventsViewportContainer\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"logEventsViewportNoLogs\"");

WriteLiteral(" data-bind=\"visible: messages().length == 0\"");

WriteLiteral("\r\n                        style=\"display: none\"");

WriteLiteral(">\r\n                        No logs\r\n                    </div>\r\n                 " +
"   <table");

WriteLiteral(" class=\"logEventsViewport\"");

WriteLiteral(" data-bind=\"visible: messages().length > 0\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n                        <tbody");

WriteLiteral(" data-bind=\"foreach: messages\"");

WriteLiteral(">\r\n                            <tr>\r\n                                <td");

WriteLiteral(" class=\"icon\"");

WriteLiteral(" data-bind=\"attr: { title: FormattedTimestamp }, css: { information: EventTypeSev" +
"erity == 0, warning: EventTypeSeverity == 1, error: EventTypeSeverity == 2 }\"");

WriteLiteral(">&nbsp;\r\n                                </td>\r\n                                <" +
"td");

WriteLiteral(" class=\"message\"");

WriteLiteral(" data-bind=\"text: FormattedMessage, attr: { title: EventTypeName }\"");

WriteLiteral("></td>\r\n                            </tr>\r\n                        </tbody>\r\n    " +
"                </table>\r\n                </div>\r\n            </div>\r\n        </" +
"div>\r\n    </div>\r\n</div>\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    ko.bindingHandlers.progressValue = {
        update: function (element, valueAccessor, allBindingsAccessor, viewModel) {
            var v = ko.utils.unwrapObservable(valueAccessor());
            var vInt = parseInt(v);
            if (vInt >= 0) {
                $element = $(element);
                if (!$element.is('.ui-progressbar'))
                    $element.progressbar();
                $(element).progressbar('option', 'value', vInt);
            }
        }
    };
</script>
<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    $(function () {\r\n        var vm;\r\n        var host = $(\'#importStatus\');\r\n" +
"        var hostSessions = $(\'#sessions\');\r\n        var liveConnection;\r\n       " +
" var urlDeviceShow = \'");

            
            #line 104 "..\..\Areas\Config\Views\DocumentTemplate\ImportStatus.cshtml"
                         Write(Url.Action(MVC.Device.Show()));

            
            #line default
            #line hidden
WriteLiteral("/\'\r\n        var urlJobShow = \'");

            
            #line 105 "..\..\Areas\Config\Views\DocumentTemplate\ImportStatus.cshtml"
                      Write(Url.Action(MVC.Job.Show()));

            
            #line default
            #line hidden
WriteLiteral("/\'\r\n        var urlUserShow = \'");

            
            #line 106 "..\..\Areas\Config\Views\DocumentTemplate\ImportStatus.cshtml"
                       Write(Url.Action(MVC.User.Show()));

            
            #line default
            #line hidden
WriteLiteral("/\'\r\n        var urlPageThumbnail = \'");

            
            #line 107 "..\..\Areas\Config\Views\DocumentTemplate\ImportStatus.cshtml"
                            Write(Url.Action(MVC.API.DocumentTemplate.ImporterThumbnail()));

            
            #line default
            #line hidden
WriteLiteral("/\'\r\n        var urlDocumentTemplate = \'");

            
            #line 108 "..\..\Areas\Config\Views\DocumentTemplate\ImportStatus.cshtml"
                               Write(Url.Action(MVC.Config.DocumentTemplate.Index()));

            
            #line default
            #line hidden
WriteLiteral("/\';\r\n        var urlManuallyAssign = \'");

            
            #line 109 "..\..\Areas\Config\Views\DocumentTemplate\ImportStatus.cshtml"
                             Write(Url.Action(MVC.Config.DocumentTemplate.UndetectedPages()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n        var iconErrorUrl = \'url(");

            
            #line 110 "..\..\Areas\Config\Views\DocumentTemplate\ImportStatus.cshtml"
                            Write(Links.ClientSource.Style.Images.Status.fail32_png);

            
            #line default
            #line hidden
WriteLiteral(")\';\r\n        var isLive = false;\r\n\r\n        function pageViewModel() {\r\n         " +
"   var self = this;\r\n\r\n            self.noSessions = ko.observable(true);\r\n     " +
"       self.sessions = ko.observableArray();\r\n            self.sessionIndex = {}" +
";\r\n\r\n            self.sessionRendered = function (e, d) {\r\n                if (!" +
"d.sessionEnded()) {\r\n                    d.progressbar = $(e).find(\'.sessionProg" +
"ress\').progressbar();\r\n                }\r\n            };\r\n        }\r\n        fun" +
"ction sessionViewModel(id) {\r\n            var self = this;\r\n\r\n            self.t" +
"itle = ko.observable(id);\r\n            self.messages = ko.observableArray();\r\n  " +
"          self.progressStatus = ko.observable();\r\n            self.progressValue" +
" = ko.observable();\r\n            self.startTime = ko.observable();\r\n            " +
"self.sessionEnded = ko.observable(false);\r\n\r\n            self.sessionPages = ko." +
"observableArray();\r\n            self.sessionPagesIndex = {};\r\n            self.a" +
"ddSessionPage = function (sessionPage) {\r\n                //if (isLive) {\r\n     " +
"           self.sessionPages.push(sessionPage);\r\n                self.sessionPag" +
"esIndex[sessionPage.pageNumber] = sessionPage;\r\n                //}\r\n           " +
" }\r\n        }\r\n        function sessionPageViewModel(sessionId, pageNumber) {\r\n " +
"           var self = this;\r\n\r\n            self.sessionId = sessionId;\r\n        " +
"    self.pageNumber = pageNumber;\r\n            self.title = \'Page \' + pageNumber" +
";\r\n            self.progressStatus = ko.observable();\r\n            self.progress" +
"Value = ko.observable();\r\n            self.undetected = ko.observable(false);\r\n " +
"           self.detected = ko.observable(false);\r\n            self.documentTempl" +
"ateId = ko.observable();\r\n            self.documentTemplate = ko.observable();\r\n" +
"            self.assignedDataType = ko.observable();\r\n            self.assignedD" +
"ataId = ko.observable();\r\n            self.assignedData = ko.observable();\r\n    " +
"        self.thumbnailEnabled = ko.observable(0);\r\n            self.updateThumbn" +
"ail = function () {\r\n                self.thumbnailEnabled(self.thumbnailEnabled" +
"() + 1);\r\n            }\r\n            self.documentTemplateUrl = ko.computed(func" +
"tion () {\r\n                return urlDocumentTemplate + self.documentTemplateId(" +
");\r\n            });\r\n            self.manuallyAssignUrl = ko.computed(function (" +
") {\r\n                return urlManuallyAssign + \'#\' + self.sessionId + \'_\' + sel" +
"f.pageNumber;\r\n            });\r\n            self.assignedDataUrl = ko.computed(f" +
"unction () {\r\n                var t = self.assignedDataType();\r\n                " +
"var dId = self.assignedDataId();\r\n                switch (t) {\r\n                " +
"    case \'Device\':\r\n                        return urlDeviceShow + dId;\r\n       " +
"             case \'Job\':\r\n                        return urlJobShow + dId;\r\n    " +
"                case \'User\':\r\n                        return urlUserShow + dId;\r" +
"\n                }\r\n                return null;\r\n            });\r\n            s" +
"elf.thumbnailUrl = ko.computed(function () {\r\n                var enabled = self" +
".thumbnailEnabled();\r\n                if (enabled > 0) {\r\n                    re" +
"turn \'url(\' + urlPageThumbnail + \'?SessionId=\' + self.sessionId + \'&PageNumber=\'" +
" + self.pageNumber + \'&NoCache=\' + enabled + \')\';\r\n                }\r\n          " +
"      return null;\r\n            });\r\n        }\r\n\r\n        function parseLog(log)" +
" {\r\n            if (log.ModuleId === 40 && log.Arguments && log.Arguments.length" +
" > 0) {\r\n                // find session\r\n                var sessionId = log.Ar" +
"guments[0];\r\n                var session = vm.sessionIndex[sessionId];\r\n        " +
"        if (!session && log.EventTypeId === 10) { // Starting Session (Ignore \'p" +
"artial\' sessions)\r\n                    session = new sessionViewModel(log.Argume" +
"nts[1]);\r\n                    vm.sessionIndex[sessionId] = session;\r\n           " +
"         vm.sessions.unshift(session);\r\n                    vm.noSessions(false)" +
";\r\n                }\r\n                if (session) {\r\n                    switch" +
" (log.EventTypeId) {\r\n                        case 10: // SessionStarting\r\n     " +
"                       session.startTime(log.FormattedTimestamp.substring(log.Fo" +
"rmattedTimestamp.indexOf(\' \') + 1));\r\n                            break;\r\n      " +
"                  case 11: // SessionProgress\r\n                            sessi" +
"on.progressValue(log.Arguments[1]);\r\n                            session.progres" +
"sStatus(log.Arguments[2]);\r\n                            break;\r\n                " +
"        case 12: // SessionFinished\r\n                            session.session" +
"Ended(true);\r\n                            session.progressStatus(\'Import Finishe" +
"d\');\r\n                            break;\r\n                        case 15: // Se" +
"ssionWarning\r\n                            session.messages.unshift(log);\r\n      " +
"                      break;\r\n                        case 16: // SessionError\r\n" +
"                            session.messages.unshift(log);\r\n                    " +
"        break;\r\n                        case 100: // ImportPageStarting\r\n       " +
"                     session.addSessionPage(new sessionPageViewModel(sessionId, " +
"log.Arguments[1]));\r\n                            break;\r\n                       " +
" case 104: // ImportPageImageUpdate\r\n                            var p = session" +
".sessionPagesIndex[log.Arguments[1]];\r\n                            if (p) {\r\n   " +
"                             p.updateThumbnail();\r\n                            }" +
"\r\n                            break;\r\n                        case 105: // Impor" +
"tPageProgress\r\n                            var p = session.sessionPagesIndex[log" +
".Arguments[1]];\r\n                            if (p) {\r\n                         " +
"       p.progressValue(log.Arguments[2]);\r\n                                p.pro" +
"gressStatus(log.Arguments[3]);\r\n                            }\r\n                 " +
"           break;\r\n                        case 110: // ImportPageDetected\r\n    " +
"                        var p = session.sessionPagesIndex[log.Arguments[1]];\r\n  " +
"                          if (p) {\r\n                                p.documentTe" +
"mplateId(log.Arguments[2]);\r\n                                p.documentTemplate(" +
"log.Arguments[3]);\r\n                                p.assignedDataType(log.Argum" +
"ents[4]);\r\n                                p.assignedDataId(log.Arguments[5]);\r\n" +
"                                p.assignedData(log.Arguments[6]);\r\n             " +
"                   p.detected(true);\r\n                                if (!isLiv" +
"e) {\r\n                                    p.updateThumbnail();\r\n                " +
"                }\r\n                            }\r\n                            se" +
"ssion.messages.unshift(log);\r\n                            break;\r\n              " +
"          case 115: // ImportPageUndetected\r\n                            var p =" +
" session.sessionPagesIndex[log.Arguments[1]];\r\n                            if (p" +
") {\r\n                                p.undetected(true);\r\n                      " +
"          if (!isLive) {\r\n                                    p.updateThumbnail(" +
");\r\n                                }\r\n                            }\r\n          " +
"                  session.messages.unshift(log);\r\n                            br" +
"eak;\r\n                        case 150: // Ignore: ImportPageUndetectedStored\r\n " +
"                           break;\r\n                        default:\r\n           " +
"                 session.messages.unshift(log);\r\n                    }\r\n        " +
"        }\r\n            }\r\n        }\r\n        function init() {\r\n            // C" +
"reate View Model\r\n            vm = new pageViewModel();\r\n\r\n            // Load L" +
"ogs\r\n            var d = new Date();\r\n            var loadData = {\r\n            " +
"    Format: \"json\",\r\n                Start: d.getFullYear() + \'-\' + (d.getMonth(" +
") + 1) + \'-\' + d.getDate(),\r\n                End: null,\r\n                ModuleI" +
"d: 40,\r\n                Take: 2000\r\n            };\r\n            $.ajax({\r\n      " +
"          url: \'");

            
            #line 285 "..\..\Areas\Config\Views\DocumentTemplate\ImportStatus.cshtml"
                  Write(Url.Action(MVC.API.Logging.RetrieveEvents()));

            
            #line default
            #line hidden
WriteLiteral(@"',
                dataType: 'json',
                type: 'POST',
                traditional: true,
                data: loadData,
                success: init_loadedLogs,
                error: function (jqXHR, textStatus, errorThrown) {
                    alert('Unable to retrieve logs: ' + errorThrown);
                }
            });
        }
        function init_loadedLogs(logs) {
            logs.reverse();
            for (var i = 0; i < logs.length; i++) {
                parseLog(logs[i]);
            }
            // Bind
            ko.applyBindings(vm);

            // Init Persistent Connection
            liveConnection = $.connection('");

            
            #line 305 "..\..\Areas\Config\Views\DocumentTemplate\ImportStatus.cshtml"
                                       Write(Url.Content("~/API/Logging/Notifications"));

            
            #line default
            #line hidden
WriteLiteral("\', { addToGroups: \'");

            
            #line 305 "..\..\Areas\Config\Views\DocumentTemplate\ImportStatus.cshtml"
                                                                                                       Write(Disco.BI.DocumentTemplateBI.Importer.DocumentImporterLog.Current.LiveLogGroupName);

            
            #line default
            #line hidden
WriteLiteral(@"' });
            liveConnection.received(parseLog);
            liveConnection.error(function (e) { if (e.status != 200) alert('Live-Log Error: ' + e.statusText + ': ' + e.responseText); });
            isLive = true;
            liveConnection.start();
        }
        init();
    });
</script>
");

        }
    }
}
#pragma warning restore 1591
