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

namespace Disco.Web.Areas.Config.Views.DeviceModel
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DeviceModel/Index.cshtml")]
    public partial class Index : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.DeviceModel.IndexModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
  
    Authorization.Require(Claims.Config.DeviceModel.Show);
    
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Device Models");

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"tableData\"");

WriteLiteral(@">
    <tr>
        <th>
            Name/Description
        </th>
        <th>
            Manufacturer
        </th>
        <th>
            Model
        </th>
        <th>
            Type
        </th>
        <th>
            Device Count
        </th>
    </tr>
");

            
            #line 25 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 25 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
     foreach (var item in Model.DeviceModels)
    {

            
            #line default
            #line hidden
WriteLiteral("        <tr>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 29 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
           Write(Html.ActionLink(item.ToString(), MVC.Config.DeviceModel.Index(item.Id)));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 32 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Manufacturer));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 35 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 38 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ModelType));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 41 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
           Write(item.DeviceCount.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 42 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 42 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
                 if (item.DeviceDecommissionedCount > 0)
                { 

            
            #line default
            #line hidden
WriteLiteral("                    <span");

WriteLiteral(" class=\"smallMessage\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1233), Tuple.Create("\"", 1289)
            
            #line 44 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1241), Tuple.Create<System.Object, System.Int32>(item.DeviceDecommissionedCount
            
            #line default
            #line hidden
, 1241), false)
, Tuple.Create(Tuple.Create(" ", 1274), Tuple.Create("Decommissioned", 1275), true)
);

WriteLiteral(">\r\n                        (");

            
            #line 45 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
                     Write(item.DeviceDecommissionedCount.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n");

            
            #line 46 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n        </tr>\r\n");

            
            #line 49 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</table>\r\n<div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n");

WriteLiteral("    ");

            
            #line 52 "..\..\Areas\Config\Views\DeviceModel\Index.cshtml"
Write(Html.ActionLinkButton("Generic Components", MVC.Config.DeviceModel.GenericComponents()));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>");

        }
    }
}
#pragma warning restore 1591
