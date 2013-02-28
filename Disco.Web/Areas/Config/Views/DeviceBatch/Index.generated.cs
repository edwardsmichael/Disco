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

namespace Disco.Web.Areas.Config.Views.DeviceBatch
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DeviceBatch/Index.cshtml")]
    public class Index : System.Web.Mvc.WebViewPage<Disco.Web.Areas.Config.Models.DeviceBatch.IndexModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
  
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Device Batches");

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"tableData\"");

WriteLiteral(@">
    <tr>
        <th>
            Name
        </th>
        <th>
            Default Model
        </th>
        <th>
            Purchase Date
        </th>
        <th>
            Warranty Expires
        </th>
        <th>
            Insurance Expires
        </th>
        <th>
            Device Count
        </th>
    </tr>
");

            
            #line 26 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 26 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
     foreach (var item in Model.DeviceBatches)
    {

            
            #line default
            #line hidden
WriteLiteral("        <tr>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 30 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
           Write(Html.ActionLink(item.Name, MVC.Config.DeviceBatch.Index(item.Id)));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 33 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
           Write(item.DefaultDeviceModel);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 36 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
           Write(CommonHelpers.FriendlyDate(item.PurchaseDate));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 39 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
           Write(CommonHelpers.FriendlyDate(item.WarrantyExpires, "Unknown"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n");

WriteLiteral("                ");

            
            #line 42 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
           Write(CommonHelpers.FriendlyDate(item.InsuredUntil, item.InsuranceSupplier == null ? "N/A" : "Unknown"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 43 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
            Write(item.InsuranceSupplier == null ? string.Empty : string.Format("[{0}]", item.InsuranceSupplier));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n            <td>\r\n");

            
            #line 46 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 46 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
                 if (item.PurchaseUnitQuantity.HasValue)
                { 

            
            #line default
            #line hidden
WriteLiteral("                    <span>");

            
            #line 48 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
                     Write(item.DeviceCount.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("/");

            
            #line 48 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
                                                       Write(item.PurchaseUnitQuantity.Value.ToString("n0"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 49 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
                }
                else
                { 
                    
            
            #line default
            #line hidden
            
            #line 52 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
               Write(item.DeviceCount.ToString("n0"));

            
            #line default
            #line hidden
            
            #line 52 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
                                                    
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 54 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
                 if (item.DeviceDecommissionedCount > 0)
                { 

            
            #line default
            #line hidden
WriteLiteral("                    <span");

WriteLiteral(" class=\"smallMessage\"");

WriteAttribute("title", Tuple.Create(" title=\"", 1775), Tuple.Create("\"", 1831)
            
            #line 56 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1783), Tuple.Create<System.Object, System.Int32>(item.DeviceDecommissionedCount
            
            #line default
            #line hidden
, 1783), false)
, Tuple.Create(Tuple.Create(" ", 1816), Tuple.Create("Decommissioned", 1817), true)
);

WriteLiteral(">\r\n                        (");

            
            #line 57 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
                     Write(item.DeviceDecommissionedCount);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n");

            
            #line 58 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n        </tr>\r\n");

            
            #line 61 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</table>\r\n<div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n");

            
            #line 64 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 64 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
     if (Model.DeviceBatches.Count > 0)
    { 
        
            
            #line default
            #line hidden
            
            #line 66 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
   Write(Html.ActionLinkButton("Timeline", MVC.Config.DeviceBatch.Timeline()));

            
            #line default
            #line hidden
            
            #line 66 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
                                                                             
    }

            
            #line default
            #line hidden
WriteLiteral("    ");

            
            #line 68 "..\..\Areas\Config\Views\DeviceBatch\Index.cshtml"
Write(Html.ActionLinkButton("Create Device Batch", MVC.Config.DeviceBatch.Create()));

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
