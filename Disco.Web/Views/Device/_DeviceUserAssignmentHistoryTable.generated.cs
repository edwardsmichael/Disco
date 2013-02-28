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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Device/_DeviceUserAssignmentHistoryTable.cshtml")]
    public class DeviceUserAssignmentHistoryTable : System.Web.Mvc.WebViewPage<Disco.Models.Repository.Device>
    {
        public DeviceUserAssignmentHistoryTable()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Device\_DeviceUserAssignmentHistoryTable.cshtml"
 if (Model.DeviceUserAssignments.Count > 0)
{ 

            
            #line default
            #line hidden
WriteLiteral("    <table");

WriteLiteral(" class=\"genericData smallTable\"");

WriteLiteral(">\r\n        <tr>\r\n            <th>\r\n                User\r\n            </th>\r\n     " +
"       <th>\r\n                Assigned\r\n            </th>\r\n            <th>\r\n    " +
"            Unassigned\r\n            </th>\r\n        </tr>\r\n");

            
            #line 16 "..\..\Views\Device\_DeviceUserAssignmentHistoryTable.cshtml"
        
            
            #line default
            #line hidden
            
            #line 16 "..\..\Views\Device\_DeviceUserAssignmentHistoryTable.cshtml"
         foreach (var dua in Model.DeviceUserAssignments.OrderByDescending(m => m.AssignedDate))
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 20 "..\..\Views\Device\_DeviceUserAssignmentHistoryTable.cshtml"
               Write(Html.ActionLink(dua.AssignedUser.ToString(), MVC.User.Show(dua.AssignedUserId)));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 23 "..\..\Views\Device\_DeviceUserAssignmentHistoryTable.cshtml"
               Write(CommonHelpers.FriendlyDate(dua.AssignedDate));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 26 "..\..\Views\Device\_DeviceUserAssignmentHistoryTable.cshtml"
               Write(CommonHelpers.FriendlyDate(dua.UnassignedDate, "Current"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");

            
            #line 29 "..\..\Views\Device\_DeviceUserAssignmentHistoryTable.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n");

            
            #line 31 "..\..\Views\Device\_DeviceUserAssignmentHistoryTable.cshtml"
}
else
{ 

            
            #line default
            #line hidden
WriteLiteral("    <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Assignment History Available</span>\r\n");

            
            #line 35 "..\..\Views\Device\_DeviceUserAssignmentHistoryTable.cshtml"
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
