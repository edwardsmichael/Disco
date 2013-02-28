﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
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
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Device/_DeviceTable.cshtml")]
    public class DeviceTable : System.Web.Mvc.WebViewPage<IEnumerable<Disco.Models.BI.Search.DeviceSearchResultItem>>
    {
        public DeviceTable()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"genericData deviceTable\"");

WriteLiteral(">\r\n");

            
            #line 3 "..\..\Views\Device\_DeviceTable.cshtml"
    
            
            #line default
            #line hidden
            
            #line 3 "..\..\Views\Device\_DeviceTable.cshtml"
     if (Model != null && Model.Count() > 0)
    { 

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" class=\"genericData deviceTable\"");

WriteLiteral(@">
            <thead>
                <tr>
                    <th>
                        Serial#
                    </th>
                    <th>
                        Asset#
                    </th>
                    <th>
                        Name
                    </th>
                    <th>
                        Model
                    </th>
                    <th>
                        Profile
                    </th>
                    <th>
                        Assigned User
                    </th>
                    <th>
                        Jobs
                    </th>
                </tr>
            </thead>
            <tbody>
");

            
            #line 32 "..\..\Views\Device\_DeviceTable.cshtml"
                
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Device\_DeviceTable.cshtml"
                 foreach (var item in Model)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr");

WriteAttribute("class", Tuple.Create(" class=\"", 1005), Tuple.Create("\"", 1082)
            
            #line 34 "..\..\Views\Device\_DeviceTable.cshtml"
, Tuple.Create(Tuple.Create("", 1013), Tuple.Create<System.Object, System.Int32>(item.DecommissionedDate.HasValue ? "decommissioned" : string.Empty
            
            #line default
            #line hidden
, 1013), false)
);

WriteLiteral(">\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 36 "..\..\Views\Device\_DeviceTable.cshtml"
                       Write(Html.ActionLink(item.SerialNumber, MVC.Device.Show(item.SerialNumber)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 39 "..\..\Views\Device\_DeviceTable.cshtml"
                       Write(item.AssetNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 40 "..\..\Views\Device\_DeviceTable.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\Device\_DeviceTable.cshtml"
                             if (item.DecommissionedDate.HasValue)
                            {
            
            #line default
            #line hidden
WriteLiteral(" <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">(Decommissioned\r\n");

WriteLiteral("                            ");

            
            #line 42 "..\..\Views\Device\_DeviceTable.cshtml"
                       Write(CommonHelpers.FriendlyDate(item.DecommissionedDate.Value));

            
            #line default
            #line hidden
WriteLiteral(")</span> ");

            
            #line 42 "..\..\Views\Device\_DeviceTable.cshtml"
                                                                                               }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td>\r\n");

            
            #line 45 "..\..\Views\Device\_DeviceTable.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 45 "..\..\Views\Device\_DeviceTable.cshtml"
                             if (string.IsNullOrWhiteSpace(item.ComputerName))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">Unknown</span>\r\n");

            
            #line 48 "..\..\Views\Device\_DeviceTable.cshtml"
                            }
                            else
                            { 
                                
            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Device\_DeviceTable.cshtml"
                           Write(item.ComputerName);

            
            #line default
            #line hidden
            
            #line 51 "..\..\Views\Device\_DeviceTable.cshtml"
                                                  
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td>\r\n");

            
            #line 55 "..\..\Views\Device\_DeviceTable.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 55 "..\..\Views\Device\_DeviceTable.cshtml"
                             if (item.DeviceModelDescription != null)
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span>");

            
            #line 57 "..\..\Views\Device\_DeviceTable.cshtml"
                                 Write(item.DeviceModelDescription);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 58 "..\..\Views\Device\_DeviceTable.cshtml"
                            }
                            else
                            { 

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">Unknown</span>                    \r\n");

            
            #line 62 "..\..\Views\Device\_DeviceTable.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 65 "..\..\Views\Device\_DeviceTable.cshtml"
                       Write(item.DeviceProfileDescription);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");

            
            #line 68 "..\..\Views\Device\_DeviceTable.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 68 "..\..\Views\Device\_DeviceTable.cshtml"
                             if (string.IsNullOrEmpty(item.AssignedUserId))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">N/A</span>                 \r\n");

            
            #line 71 "..\..\Views\Device\_DeviceTable.cshtml"
                            }
                            else
                            { 

            
            #line default
            #line hidden
WriteLiteral("                                <span>");

            
            #line 74 "..\..\Views\Device\_DeviceTable.cshtml"
                                 Write(item.AssignedUserDescription);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 75 "..\..\Views\Device\_DeviceTable.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 78 "..\..\Views\Device\_DeviceTable.cshtml"
                       Write(item.JobCount);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");

            
            #line 81 "..\..\Views\Device\_DeviceTable.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n");

            
            #line 84 "..\..\Views\Device\_DeviceTable.cshtml"
    }
    else
    { 

            
            #line default
            #line hidden
WriteLiteral("        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Devices Found</span>\r\n");

            
            #line 88 "..\..\Views\Device\_DeviceTable.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
