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

namespace Disco.Web.Views.Device
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Device/Show.cshtml")]
    public partial class Show : Disco.Services.Web.WebViewPage<Disco.Web.Models.Device.ShowModel>
    {
        public Show()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Device\Show.cshtml"
  
    ViewBag.Title = Html.ToBreadcrumb("Devices", MVC.Device.Index(), string.Format("Device: {0}", Model.Device.SerialNumber));

    var deviceStatus = Model.Device.Status();

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"Device_Show\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"Device_Show_Status\"");

WriteLiteral(">\r\n        <span");

WriteAttribute("class", Tuple.Create(" class=\"", 298), Tuple.Create("\"", 365)
, Tuple.Create(Tuple.Create("", 306), Tuple.Create("icon", 306), true)
, Tuple.Create(Tuple.Create(" ", 310), Tuple.Create("DeviceStatus", 311), true)
            
            #line 9 "..\..\Views\Device\Show.cshtml"
, Tuple.Create(Tuple.Create("", 323), Tuple.Create<System.Object, System.Int32>(deviceStatus.Replace(" ", string.Empty)
            
            #line default
            #line hidden
, 323), false)
);

WriteLiteral("></span>");

            
            #line 9 "..\..\Views\Device\Show.cshtml"
                                                                                    Write(deviceStatus);

            
            #line default
            #line hidden
WriteLiteral("\r\n        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n            $(function () {\r\n                $(\'#Device_Show_Status\').appendTo" +
"(\'#layout_PageHeading\')\r\n            });\r\n        </script>\r\n    </div>\r\n");

WriteLiteral("    ");

            
            #line 16 "..\..\Views\Device\Show.cshtml"
Write(Html.Partial(MVC.Device.Views.DeviceParts._Subject, Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            var $tabs = $(\'#DeviceDetailTabs\');\r\n    " +
"        if ($tabs.children().length > 1) {\r\n                $tabs.tabs({\r\n      " +
"              activate: function (event, ui) {\r\n                        window.s" +
"etTimeout(function () {\r\n                            var $window = $(window);\r\n " +
"                           var tabHeight = $tabs.height();\r\n                    " +
"        var tabOffset = $tabs.offset();\r\n                            var windowS" +
"crollTop = $window.scrollTop();\r\n                            var windowHeight = " +
"$window.height();\r\n\r\n                            var tabTopNotShown = windowScro" +
"llTop - tabOffset.top;\r\n                            if (tabTopNotShown > 0) {\r\n " +
"                               $(\'html\').animate({ scrollTop: tabOffset.top }, 1" +
"25);\r\n                            } else {\r\n                                var " +
"tabBottomNotShown = ((windowScrollTop + windowHeight) - (tabHeight + tabOffset.t" +
"op)) * -1;\r\n                                if (tabBottomNotShown > 0) {\r\n      " +
"                              if (tabHeight > windowHeight)\r\n                   " +
"                     $(\'html\').animate({ scrollTop: tabOffset.top }, 125);\r\n    " +
"                                else\r\n                                        $(" +
"\'html\').animate({ scrollTop: windowScrollTop + tabBottomNotShown }, 125);\r\n     " +
"                           }\r\n                            }\r\n                   " +
"     }, 1);\r\n                    }\r\n                });\r\n            } else {\r\n " +
"               $tabs.hide();\r\n            }\r\n        });\r\n    </script>\r\n    <di" +
"v");

WriteLiteral(" id=\"DeviceDetailTabs\"");

WriteLiteral(">\r\n        <ul");

WriteLiteral(" id=\"DeviceDetailTabItems\"");

WriteLiteral("></ul>\r\n");

            
            #line 52 "..\..\Views\Device\Show.cshtml"
        
            
            #line default
            #line hidden
            
            #line 52 "..\..\Views\Device\Show.cshtml"
         if (Authorization.Has(Claims.Device.ShowJobs))
        {
            
            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Device\Show.cshtml"
       Write(Html.Partial(MVC.Device.Views.DeviceParts._Jobs, Model));

            
            #line default
            #line hidden
            
            #line 54 "..\..\Views\Device\Show.cshtml"
                                                                    
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 56 "..\..\Views\Device\Show.cshtml"
         if (Authorization.Has(Claims.Device.ShowDetails))
        {
            
            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Device\Show.cshtml"
       Write(Html.Partial(MVC.Device.Views.DeviceParts._Details, Model));

            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Device\Show.cshtml"
                                                                       
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 60 "..\..\Views\Device\Show.cshtml"
         if (Authorization.Has(Claims.Device.ShowAssignmentHistory))
        {
            
            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\Device\Show.cshtml"
       Write(Html.Partial(MVC.Device.Views.DeviceParts._AssignmentHistory, Model));

            
            #line default
            #line hidden
            
            #line 62 "..\..\Views\Device\Show.cshtml"
                                                                                 
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 64 "..\..\Views\Device\Show.cshtml"
         if (Authorization.Has(Claims.Device.ShowAttachments))
        {
            
            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\Device\Show.cshtml"
       Write(Html.Partial(MVC.Device.Views.DeviceParts._Resources, Model));

            
            #line default
            #line hidden
            
            #line 66 "..\..\Views\Device\Show.cshtml"
                                                                         
        }

            
            #line default
            #line hidden
WriteLiteral("        ");

            
            #line 68 "..\..\Views\Device\Show.cshtml"
         if (Authorization.Has(Claims.Device.ShowCertificates))
        {
            
            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\Device\Show.cshtml"
       Write(Html.Partial(MVC.Device.Views.DeviceParts._Certificates, Model));

            
            #line default
            #line hidden
            
            #line 70 "..\..\Views\Device\Show.cshtml"
                                                                            
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
