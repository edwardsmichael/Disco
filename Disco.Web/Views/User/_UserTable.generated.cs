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

namespace Disco.Web.Views.User
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/_UserTable.cshtml")]
    public partial class UserTable : Disco.Services.Web.WebViewPage<IEnumerable<Disco.Models.BI.Search.UserSearchResultItem>>
    {
        public UserTable()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" class=\"genericData userTable\"");

WriteLiteral(">\r\n");

            
            #line 3 "..\..\Views\User\_UserTable.cshtml"
    
            
            #line default
            #line hidden
            
            #line 3 "..\..\Views\User\_UserTable.cshtml"
     if (Model != null && Model.Count() > 0)
    { 

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" class=\"genericData userTable\"");

WriteLiteral(@">
            <thead>
                <tr>
                    <th>Id
                    </th>
                    <th>Surname
                    </th>
                    <th>Given Name
                    </th>
                    <th>Display Name
                    </th>
                    <th>Assigned Devices
                    </th>
                    <th>Jobs
                    </th>
                </tr>
            </thead>
            <tbody>
");

            
            #line 23 "..\..\Views\User\_UserTable.cshtml"
                
            
            #line default
            #line hidden
            
            #line 23 "..\..\Views\User\_UserTable.cshtml"
                 foreach (var item in Model)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <tr>\r\n                        <td>\r\n");

            
            #line 27 "..\..\Views\User\_UserTable.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 27 "..\..\Views\User\_UserTable.cshtml"
                             if (Authorization.Has(Claims.User.Show))
                            {
                                
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\User\_UserTable.cshtml"
                           Write(Html.ActionLink(item.Id, MVC.User.Show(item.Id)));

            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\User\_UserTable.cshtml"
                                                                                 
                            }
                            else
                            {
                                
            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\User\_UserTable.cshtml"
                           Write(item.Id);

            
            #line default
            #line hidden
            
            #line 33 "..\..\Views\User\_UserTable.cshtml"
                                        
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 37 "..\..\Views\User\_UserTable.cshtml"
                       Write(item.Surname);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 40 "..\..\Views\User\_UserTable.cshtml"
                       Write(item.GivenName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 43 "..\..\Views\User\_UserTable.cshtml"
                       Write(item.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 46 "..\..\Views\User\_UserTable.cshtml"
                       Write(item.AssignedDevicesCount);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");

WriteLiteral("                            ");

            
            #line 49 "..\..\Views\User\_UserTable.cshtml"
                       Write(item.JobCount);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");

            
            #line 52 "..\..\Views\User\_UserTable.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n");

            
            #line 55 "..\..\Views\User\_UserTable.cshtml"
    }
    else
    { 

            
            #line default
            #line hidden
WriteLiteral("        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Users Found</span>\r\n");

            
            #line 59 "..\..\Views\User\_UserTable.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
