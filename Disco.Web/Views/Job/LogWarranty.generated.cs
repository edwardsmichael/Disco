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

namespace Disco.Web.Views.Job
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/LogWarranty.cshtml")]
    public partial class LogWarranty : Disco.Services.Web.WebViewPage<Disco.Web.Models.Job.LogWarrantyModel>
    {
        public LogWarranty()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Job\LogWarranty.cshtml"
  
    Authorization.Require(Claims.Job.Actions.LogWarranty);
    
    ViewBag.Title = Html.ToBreadcrumb("Jobs", MVC.Job.Index(), string.Format("Job: {0}", Model.Job.Id), MVC.Job.Show(Model.Job.Id), "Log Warranty");

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\Views\Job\LogWarranty.cshtml"
 using (Html.BeginForm(MVC.Job.LogWarranty(), FormMethod.Post))
{
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Job\LogWarranty.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 9 "..\..\Views\Job\LogWarranty.cshtml"
                                 
    
            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Job\LogWarranty.cshtml"
Write(Html.HiddenFor(m => m.JobId));

            
            #line default
            #line hidden
            
            #line 10 "..\..\Views\Job\LogWarranty.cshtml"
                                 
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Job\LogWarranty.cshtml"
Write(Html.ValidationMessageFor(m => m.JobId));

            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\Job\LogWarranty.cshtml"
                                            

            
            #line default
            #line hidden
WriteLiteral("    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"WarrantyAction\"");

WriteLiteral(" value=\"Disclose\"");

WriteLiteral(" />\r\n");

WriteLiteral("    <div");

WriteLiteral(" id=\"warrantyJobForm\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 650px\"");

WriteLiteral(">\r\n        <table>\r\n            <tr>\r\n                <th>Internal Job Id:\r\n     " +
"           </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 19 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Model.JobId);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">Device Serial Number:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 26 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Model.Job.Device.SerialNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">Device Model:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 33 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Model.Job.Device.DeviceModel.Manufacturer);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 33 "..\..\Views\Job\LogWarranty.cshtml"
                                                          Write(Model.Job.Device.DeviceModel.Model);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <th" +
">Technician:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 40 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Model.TechUser.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">\r\n                        Email Address: ");

            
            #line 42 "..\..\Views\Job\LogWarranty.cshtml"
                                  Write(Model.TechUser.EmailAddress);

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n                        Phone Number: ");

            
            #line 43 "..\..\Views\Job\LogWarranty.cshtml"
                                 Write(Model.TechUser.PhoneNumber);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n         " +
"   <tr>\r\n                <th");

WriteLiteral(" style=\"width: 150px\"");

WriteLiteral(">Repair Address:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 51 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Html.DropDownListFor(model => model.OrganisationAddressId, Model.OrganisationAddresses.ToSelectListItems(Model.OrganisationAddressId, (Model.OrganisationAddress == null))));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("                    ");

            
            #line 52 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Html.ValidationMessageFor(m => m.OrganisationAddressId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <div");

WriteLiteral(" id=\"organisationAddressDetailsLoading\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n                        <img");

WriteAttribute("src", Tuple.Create(" src=\"", 2141), Tuple.Create("\"", 2200)
            
            #line 54 "..\..\Views\Job\LogWarranty.cshtml"
, Tuple.Create(Tuple.Create("", 2147), Tuple.Create<System.Object, System.Int32>(Links.ClientSource.Style.Images.Status.loading_gif
            
            #line default
            #line hidden
, 2147), false)
);

WriteLiteral(" alt=\"Loading\"");

WriteLiteral(" />\r\n                        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">Loading Details...</span>\r\n                    </div>\r\n                    <div");

WriteLiteral(" id=\"organisationAddressDetails\"");

WriteLiteral(">\r\n");

            
            #line 58 "..\..\Views\Job\LogWarranty.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 58 "..\..\Views\Job\LogWarranty.cshtml"
                          
    var oa = Model.OrganisationAddress;
    if (oa != null)
    {

            
            #line default
            #line hidden
WriteLiteral("                            <span>");

            
            #line 62 "..\..\Views\Job\LogWarranty.cshtml"
                             Write(oa.Address);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("                            <br />\r\n");

WriteLiteral("                            <span>");

            
            #line 64 "..\..\Views\Job\LogWarranty.cshtml"
                             Write(oa.Suburb);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 64 "..\..\Views\Job\LogWarranty.cshtml"
                                         Write(oa.Postcode);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

WriteLiteral("                            <br />\r\n");

WriteLiteral("                            <span>");

            
            #line 66 "..\..\Views\Job\LogWarranty.cshtml"
                             Write(oa.State);

            
            #line default
            #line hidden
WriteLiteral(", ");

            
            #line 66 "..\..\Views\Job\LogWarranty.cshtml"
                                        Write(oa.Country);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 67 "..\..\Views\Job\LogWarranty.cshtml"
    }
                        
            
            #line default
            #line hidden
WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n         " +
"   <tr>\r\n                <th>Warranty Provider:\r\n                </th>\r\n        " +
"        <td>\r\n");

WriteLiteral("                    ");

            
            #line 76 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Html.DropDownListFor(model => model.WarrantyProviderId, Model.WarrantyProviders.ToSelectListItems(Model.WarrantyProviderId, true)));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("                    ");

            
            #line 77 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Html.ValidationMessageFor(m => m.WarrantyProviderId));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" id=\"warrantyJobFaultDescription\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 650px; margin-top: 15px;\"");

WriteLiteral(">\r\n        <h2>Fault Description</h2>\r\n        <table>\r\n            <tr>\r\n       " +
"         <td>\r\n");

WriteLiteral("                    ");

            
            #line 87 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Html.EditorFor(model => model.FaultDescription));

            
            #line default
            #line hidden
WriteLiteral("<br />\r\n");

WriteLiteral("                    ");

            
            #line 88 "..\..\Views\Job\LogWarranty.cshtml"
               Write(Html.ValidationMessageFor(m => m.FaultDescription));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n");

            
            #line 93 "..\..\Views\Job\LogWarranty.cshtml"
    if (Model.WarrantyProvider != null && Model.WarrantyProviderSubmitJobViewType != null)
    { 

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"warrantyJobProviderProperties\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 96 "..\..\Views\Job\LogWarranty.cshtml"
   Write(Html.PartialCompiled(Model.WarrantyProviderSubmitJobViewType, Model.WarrantyProviderSubmitJobModel));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 98 "..\..\Views\Job\LogWarranty.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n        <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" value=\"Preview Warranty Claim\"");

WriteLiteral(" />\r\n    </div>\r\n");

            
            #line 102 "..\..\Views\Job\LogWarranty.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
    $(function () {

        var $organisationAddressDetails = $('#organisationAddressDetails');
        var $organisationAddressDetailsLoading = $('#organisationAddressDetailsLoading');
        var $OrganisationAddressId = $('#OrganisationAddressId');

        var $ProviderId = $('#WarrantyProviderId');

        var updateProviderDetails = function () {
            var providerId = $ProviderId.val();
            var orgAddressId = $OrganisationAddressId.val();

            if (providerId) {
                window.location.href = '");

            
            #line 117 "..\..\Views\Job\LogWarranty.cshtml"
                                    Write(Url.Action(MVC.Job.LogWarranty(Model.JobId, null, null)));

            
            #line default
            #line hidden
WriteLiteral("?WarrantyProviderId=\' + providerId + \'&OrganisationAddressId=\' + orgAddressId;\r\n " +
"           }\r\n        }\r\n        $OrganisationAddressId.change(updateProviderDet" +
"ails);\r\n        $ProviderId.change(updateProviderDetails);\r\n    });\r\n</script>\r\n" +
"");

        }
    }
}
#pragma warning restore 1591
