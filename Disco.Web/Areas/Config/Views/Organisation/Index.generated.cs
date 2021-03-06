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

namespace Disco.Web.Areas.Config.Views.Organisation
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/Organisation/Index.cshtml")]
    public partial class Index : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.Organisation.IndexModel>
    {
        public Index()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
  
    Authorization.Require(Claims.Config.Organisation.Show);

    var canConfigAddresses = Authorization.Has(Claims.Config.Organisation.ConfigureAddresses);

    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Organisation Details");
    Html.BundleDeferred("~/ClientScripts/Modules/Disco-PropertyChangeHelpers");
    Html.BundleDeferred("~/ClientScripts/Modules/Disco-AjaxHelperIcons");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 700px\"");

WriteLiteral(">\r\n    <h2>Details</h2>\r\n    <table>\r\n        <tr>\r\n            <th");

WriteLiteral(" style=\"width: 160px\"");

WriteLiteral(">Name:\r\n            </th>\r\n            <td>");

            
            #line 17 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                 if (Authorization.Has(Claims.Config.Organisation.ConfigureName))
                {
                
            
            #line default
            #line hidden
            
            #line 19 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
           Write(Html.EditorFor(m => m.OrganisationName));

            
            #line default
            #line hidden
            
            #line 19 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                        
                
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
           Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                         

            
            #line default
            #line hidden
WriteLiteral("                <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                    $(function () {
                        var field = $('#OrganisationName');
                        document.DiscoFunctions.PropertyChangeHelper(
                        field,
                        'Unknown',
                        '");

            
            #line 27 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                     Write(Url.Action(MVC.API.System.UpdateOrganisationName()));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                        \'OrganisationName\'\r\n                        );\r\n     " +
"               });\r\n                </script>\r\n");

            
            #line 32 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                <h3>");

            
            #line 35 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
               Write(Model.OrganisationName);

            
            #line default
            #line hidden
WriteLiteral("</h3>\r\n");

            
            #line 36 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n        </tr>\r\n        <tr>\r\n            <th");

WriteLiteral(" style=\"width: 160px\"");

WriteLiteral(">Logo:\r\n");

            
            #line 41 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 41 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                 if (Authorization.Has(Claims.Config.Organisation.ConfigureLogo))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <br />\r\n");

WriteLiteral("                    <br />\r\n");

WriteLiteral("                    <a");

WriteLiteral(" id=\"buttonUpdateOrganisationLogo\"");

WriteLiteral(" href=\"#\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Update</a>\r\n");

            
            #line 46 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </th>\r\n            <td>\r\n                <div");

WriteLiteral(" style=\"text-align: center;\"");

WriteLiteral(">\r\n                    <img");

WriteLiteral(" style=\"height: 256px; width: 256px;\"");

WriteLiteral(" alt=\"Organisation Logo\"");

WriteAttribute("src", Tuple.Create(" src=\"", 2007), Tuple.Create("\"", 2041)
            
            #line 50 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
            , Tuple.Create(Tuple.Create("", 2013), Tuple.Create<System.Object, System.Int32>(Url.OrganisationLogoUrl()
            
            #line default
            #line hidden
, 2013), false)
);

WriteLiteral(" />\r\n                </div>\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n    " +
"        <th");

WriteLiteral(" style=\"width: 160px\"");

WriteLiteral(">Multi-Site Mode:\r\n            </th>\r\n            <td>");

            
            #line 57 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                 if (Authorization.Has(Claims.Config.Organisation.ConfigureMultiSiteMode))
                {
                
            
            #line default
            #line hidden
            
            #line 59 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
           Write(Html.EditorFor(m => m.MultiSiteMode));

            
            #line default
            #line hidden
            
            #line 59 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                      
            
            #line default
            #line hidden
            
            #line 59 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                 Write(Html.LabelFor(m => m.MultiSiteMode));

            
            #line default
            #line hidden
            
            #line 59 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                                                          
                
            
            #line default
            #line hidden
            
            #line 60 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
           Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
            
            #line 60 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                         

            
            #line default
            #line hidden
WriteLiteral("                <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                    $(function () {
                        var field = $('#MultiSiteMode');
                        document.DiscoFunctions.PropertyChangeHelper(
                        field,
                        null,
                        '");

            
            #line 67 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                     Write(Url.Action(MVC.API.System.UpdateMultiSiteMode()));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                        \'MultiSiteMode\'\r\n                        );\r\n        " +
"            });\r\n                </script>\r\n");

            
            #line 72 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                <input");

WriteLiteral(" name=\"MultiSiteMode\"");

WriteLiteral(" class=\"check-box\"");

WriteLiteral(" id=\"MultiSiteMode\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ");

            
            #line 75 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                                                             Write(Model.MultiSiteMode ? new HtmlString("checked=\"checked\" ") : new HtmlString(string.Empty));

            
            #line default
            #line hidden
WriteLiteral("disabled=\"disabled\">  ");

            
            #line 75 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                                                                                                                                                                                     
            
            #line default
            #line hidden
            
            #line 75 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                                                                                                                                                                                Write(Html.LabelFor(m => m.MultiSiteMode));

            
            #line default
            #line hidden
            
            #line 75 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                                                                                                                                                                                                                         
                }

            
            #line default
            #line hidden
WriteLiteral("                ");

            
            #line 77 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                 if (Model.OrganisationAddresses.Count > 1)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" id=\"messageMultiSiteMode\"");

WriteLiteral(" style=\"padding: 0.7em 0.7em; margin-top: 20px;\"");

WriteLiteral(" class=\"ui-state-highlight ui-corner-all\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" style=\"margin-right: 0.3em; float: left;\"");

WriteLiteral(" class=\"ui-icon ui-icon-info\"");

WriteLiteral("></span>\r\n                        Multi-Site mode is recommended where multiple a" +
"ddresses are configured.\r\n                    </div>\r\n");

            
            #line 83 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n        </tr>\r\n        <tr>\r\n            <th");

WriteLiteral(" style=\"width: 160px\"");

WriteLiteral(">Addresses:\r\n");

            
            #line 88 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 88 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                 if (canConfigAddresses)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <br />\r\n");

WriteLiteral("                    <br />\r\n");

WriteLiteral("                    <a");

WriteLiteral(" href=\"#\"");

WriteLiteral(" id=\"createAddress\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(">Create</a>\r\n");

            
            #line 93 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </th>\r\n            <td>\r\n");

            
            #line 96 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 96 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                 if (Model.OrganisationAddresses.Count > 0)
                { 

            
            #line default
            #line hidden
WriteLiteral("                    <table");

WriteLiteral(" id=\"organisationAddresses\"");

WriteLiteral(">\r\n                        <tr>\r\n                            <th>Name\r\n          " +
"                  </th>\r\n                            <th>Address\r\n              " +
"              </th>\r\n                            <th></th>\r\n                    " +
"    </tr>\r\n");

            
            #line 106 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 106 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                         foreach (var item in Model.OrganisationAddresses)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <tr");

WriteLiteral(" data-addressid=\"");

            
            #line 108 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                           Write(item.Id);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                                <td>\r\n                                    <spa" +
"n");

WriteLiteral(" class=\"name\"");

WriteLiteral(">");

            
            #line 110 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                  Write(Html.DisplayFor(modelItem => item.Name));

            
            #line default
            #line hidden
WriteLiteral("</span> (<span");

WriteLiteral(" class=\"shortName\"");

WriteLiteral(">");

            
            #line 110 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                                                                                           Write(Html.DisplayFor(modelItem => item.ShortName));

            
            #line default
            #line hidden
WriteLiteral("</span>)\r\n                                </td>\r\n                                " +
"<td>\r\n                                    <span");

WriteLiteral(" class=\"address\"");

WriteLiteral(">");

            
            #line 113 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.Address));

            
            #line default
            #line hidden
WriteLiteral("</span><br />\r\n                                    <span");

WriteLiteral(" class=\"suburb\"");

WriteLiteral(">");

            
            #line 114 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                    Write(Html.DisplayFor(modelItem => item.Suburb));

            
            #line default
            #line hidden
WriteLiteral("</span> <span");

WriteLiteral(" class=\"postcode\"");

WriteLiteral(">");

            
            #line 114 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                                                                                             Write(Html.DisplayFor(modelItem => item.Postcode));

            
            #line default
            #line hidden
WriteLiteral("</span><br />\r\n                                    <span");

WriteLiteral(" class=\"state\"");

WriteLiteral(">");

            
            #line 115 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.State));

            
            #line default
            #line hidden
WriteLiteral("</span> <span");

WriteLiteral(" class=\"country\"");

WriteLiteral(">");

            
            #line 115 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                                                                                          Write(Html.DisplayFor(modelItem => item.Country));

            
            #line default
            #line hidden
WriteLiteral("</span><br />\r\n                                    <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">Phone:</span> <span");

WriteLiteral(" class=\"phoneNumber\"");

WriteLiteral(">");

            
            #line 116 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                                                                  Write(Html.DisplayFor(modelItem => item.PhoneNumber));

            
            #line default
            #line hidden
WriteLiteral("</span><br />\r\n                                    <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">Fax:</span> <span");

WriteLiteral(" class=\"faxNumber\"");

WriteLiteral(">");

            
            #line 117 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                                                              Write(Html.DisplayFor(modelItem => item.FaxNumber));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                                </td>\r\n                                <" +
"td>\r\n");

            
            #line 120 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 120 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                     if (canConfigAddresses)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <span");

WriteLiteral(" class=\"edit\"");

WriteLiteral(" title=\"Edit Address\"");

WriteLiteral("></span>");

WriteLiteral("<span");

WriteLiteral(" class=\"delete\"");

WriteLiteral(" title=\"Delete Address\"");

WriteLiteral("></span>\r\n");

            
            #line 123 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </td>\r\n                            </tr>\r\n");

            
            #line 126 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </table>\r\n");

            
            #line 128 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                }
                else
                { 

            
            #line default
            #line hidden
WriteLiteral("                    <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Addresses Stored</span>\r\n");

            
            #line 132 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </td>\r\n        </tr>\r\n    </table>\r\n</div>\r\n");

            
            #line 137 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
 if (Authorization.Has(Claims.Config.Organisation.ConfigureLogo))
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"dialogUpdateOrganisationLogo\"");

WriteLiteral(" title=\"Update Organisation Logo\"");

WriteLiteral(">\r\n");

            
            #line 140 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 140 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
         using (Html.BeginForm(MVC.API.System.OrganisationLogo(true, null, null), FormMethod.Post, new { enctype = "multipart/form-data" }))
        {

            
            #line default
            #line hidden
WriteLiteral("            <h3>Update Action</h3>\r\n");

WriteLiteral("            <div");

WriteLiteral(" style=\"margin-top: 10px; padding-bottom: 5px;\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" id=\"updateOrganisationLogoResetLogo\"");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"ResetLogo\"");

WriteLiteral(" value=\"true\"");

WriteLiteral("\r\n                    checked=\"checked\"");

WriteLiteral(" /><label");

WriteLiteral(" for=\"updateOrganisationLogoResetLogo\"");

WriteLiteral(">Remove Logo</label>\r\n            </div>\r\n");

WriteLiteral("            <div");

WriteLiteral(" style=\"margin-top: 5px; border-top: 1px dashed #aaa; padding-top: 5px;\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" id=\"updateOrganisationLogoUploadLogo\"");

WriteLiteral(" type=\"radio\"");

WriteLiteral(" name=\"ResetLogo\"");

WriteLiteral(" value=\"false\"");

WriteLiteral(" /><label\r\n                    for=\"updateOrganisationLogoUploadLogo\">Upload Logo" +
"</label>\r\n                <div");

WriteLiteral(" id=\"updateOrganisationLogoUploadLogoContainer\"");

WriteLiteral(" style=\"display: none; padding-left: 10px;\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" id=\"updateOrganisationLogoUploadLogoImage\"");

WriteLiteral(" type=\"file\"");

WriteLiteral(" name=\"Image\"");

WriteLiteral(" />\r\n                    <span");

WriteLiteral(" id=\"updateOrganisationLogoUploadLogoImageRequired\"");

WriteLiteral(" class=\"field-validation-valid field-validation-error\"");

WriteLiteral(">* Required</span>\r\n                </div>\r\n            </div>\r\n");

            
            #line 155 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");

WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n        $(function () {\r\n            var button = $(\'#buttonUpdateOrganisation" +
"Logo\');\r\n            var buttonDialog = $(\'#dialogUpdateOrganisationLogo\');\r\n   " +
"         button.click(function () {\r\n                buttonDialog.dialog(\'open\')" +
";\r\n                return false;\r\n            });\r\n            buttonDialog.find" +
"(\'input[type=\"radio\"]\').click(function () {\r\n                if ($(\'#updateOrgan" +
"isationLogoUploadLogo\').is(\':checked\')) {\r\n                    $(\'#updateOrganis" +
"ationLogoUploadLogoImage\').removeAttr(\'disabled\');\r\n                    $(\'#upda" +
"teOrganisationLogoUploadLogoContainer\').slideDown();\r\n                }\r\n       " +
"         else {\r\n                    $(\'#updateOrganisationLogoUploadLogoContain" +
"er\').slideUp();\r\n                    $(\'#updateOrganisationLogoUploadLogoImage\')" +
".attr(\'disabled\', \'disabled\');\r\n                }\r\n            });\r\n            " +
"buttonDialog.dialog({\r\n                resizable: false,\r\n                height" +
": 200,\r\n                modal: true,\r\n                autoOpen: false,\r\n        " +
"        buttons: {\r\n                    \"Save\": function () {\r\n                 " +
"       var $this = $(this);\r\n\r\n                        var $image = $(\'#updateOr" +
"ganisationLogoUploadLogoImage\');\r\n                        if ($(\'#updateOrganisa" +
"tionLogoUploadLogo\').is(\':checked\') && $image.val() == \'\') {\r\n                  " +
"          $image.addClass(\'input-validation-error\');\r\n                          " +
"  $(\'#updateOrganisationLogoUploadLogoImageRequired\').removeClass(\'field-validat" +
"ion-valid\');\r\n                        } else {\r\n                            $ima" +
"ge.removeClass(\'input-validation-error\');\r\n                            $(\'#updat" +
"eOrganisationLogoUploadLogoImageRequired\').addClass(\'field-validation-valid\');\r\n" +
"                            $this.dialog(\"disable\");\r\n                          " +
"  $this.dialog(\"option\", \"buttons\", null);\r\n                            $this.fi" +
"nd(\'form\').submit();\r\n                        }\r\n                    },\r\n       " +
"             Cancel: function () {\r\n                        $(this).dialog(\"clos" +
"e\");\r\n                    }\r\n                }\r\n            });\r\n        });\r\n  " +
"  </script>\r\n");

            
            #line 203 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
}

            
            #line default
            #line hidden
            
            #line 204 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
 if (canConfigAddresses)
{

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"dialogConfirmRemove\"");

WriteLiteral(" title=\"Delete this Address?\"");

WriteLiteral(">\r\n        <p>\r\n            <span");

WriteLiteral(" class=\"ui-icon ui-icon-alert\"");

WriteLiteral(" style=\"float: left; margin: 0 7px 20px 0;\"");

WriteLiteral("></span>\r\n            This item will be permanently deleted and cannot be recover" +
"ed. Are you sure?\r\n        </p>\r\n    </div>\r\n");

WriteLiteral("    <div");

WriteLiteral(" id=\"dialogEdit\"");

WriteLiteral(" title=\"Edit/Create Address\"");

WriteLiteral(">\r\n        <table>\r\n            <tr>\r\n                <td>Short&nbsp;Name\r\n      " +
"          </td>\r\n                <td>\r\n                    <input");

WriteLiteral(" id=\"editShortName\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                " +
"<td>Name\r\n                </td>\r\n                <td>\r\n                    <inpu" +
"t");

WriteLiteral(" id=\"editName\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                " +
"<td>Address\r\n                </td>\r\n                <td>\r\n                    <i" +
"nput");

WriteLiteral(" id=\"editAddress\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                " +
"<td>Suburb\r\n                </td>\r\n                <td>\r\n                    <in" +
"put");

WriteLiteral(" id=\"editSuburb\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                " +
"<td>Postcode\r\n                </td>\r\n                <td>\r\n                    <" +
"input");

WriteLiteral(" id=\"editPostcode\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                " +
"<td>State\r\n                </td>\r\n                <td>\r\n                    <inp" +
"ut");

WriteLiteral(" id=\"editState\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                " +
"<td>Country\r\n                </td>\r\n                <td>\r\n                    <i" +
"nput");

WriteLiteral(" id=\"editCountry\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                " +
"<td>Phone Number\r\n                </td>\r\n                <td>\r\n                 " +
"   <input");

WriteLiteral(" id=\"editPhoneNumber\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                " +
"<td>Fax Number\r\n                </td>\r\n                <td>\r\n                   " +
" <input");

WriteLiteral(" id=\"editFaxNumber\"");

WriteLiteral(" type=\"text\"");

WriteLiteral(" />\r\n                </td>\r\n            </tr>\r\n        </table>\r\n    </div>\r\n");

WriteLiteral("    <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
        $(function () {
            $(""#dialogConfirmRemove"").dialog({
                resizable: false,
                modal: true,
                autoOpen: false,
                buttons: {
                    ""Delete"": function () {
                        return null;
                    },
                    Cancel: function () {
                        $(this).dialog(""close"");
                    }
                }
            });
            $('#organisationAddresses').find('span.delete').click(function () {
                var componentRow = $(this).closest('tr');
                var id = componentRow.attr('data-addressid');
                if (id) {
                    var dialog = $(""#dialogConfirmRemove"");
                    var buttons = dialog.dialog(""option"", ""buttons"");
                    buttons['Delete'] = function () { $(this).dialog(""disable""); window.location.href = '");

            
            #line 300 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                                                                                     Write(Url.Action(MVC.API.System.DeleteOrganisationAddress()));

            
            #line default
            #line hidden
WriteLiteral("\' + \'?redirect=true&id=\' + id; };\r\n                var buttons = dialog.dialog(\"o" +
"ption\", \"buttons\", buttons);\r\n                dialog.dialog(\'open\');\r\n          " +
"  }\r\n        });\r\n\r\n        var editAddress = function (element) {\r\n            " +
"var id = \'\', shortName = \'\', name = \'\', address = \'\', suburb = \'\', postcode = \'\'" +
", state = \'\', country = \'\', phoneNumber = \'\', faxNumber = \'\';\r\n            var d" +
"ialog = $(\'#dialogEdit\');\r\n            if (element) {\r\n                id = elem" +
"ent.attr(\'data-addressid\');\r\n                shortName = element.find(\'.shortNam" +
"e\').text();\r\n                name = element.find(\'.name\').text();\r\n             " +
"   address = element.find(\'.address\').text();\r\n                suburb = element." +
"find(\'.suburb\').text();\r\n                postcode = element.find(\'.postcode\').te" +
"xt();\r\n                state = element.find(\'.state\').text();\r\n                c" +
"ountry = element.find(\'.country\').text();\r\n                phoneNumber = element" +
".find(\'.phoneNumber\').text();\r\n                faxNumber = element.find(\'.faxNum" +
"ber\').text();\r\n                dialog.attr(\'data-addressid\', id);\r\n             " +
"   dialog.dialog(\'option\', \'title\', \'Edit Address: \' + name);\r\n            } els" +
"e {\r\n                dialog.attr(\'data-addressid\', null);\r\n                dialo" +
"g.dialog(\'option\', \'title\', \'Create Address\');\r\n            }\r\n\r\n            $(\'" +
"#editShortName\').val(shortName);\r\n            $(\'#editName\').val(name);\r\n       " +
"     $(\'#editAddress\').val(address);\r\n            $(\'#editSuburb\').val(suburb);\r" +
"\n            $(\'#editPostcode\').val(postcode);\r\n            $(\'#editState\').val(" +
"state);\r\n            $(\'#editCountry\').val(country);\r\n            $(\'#editPhoneN" +
"umber\').val(phoneNumber);\r\n            $(\'#editFaxNumber\').val(faxNumber);\r\n    " +
"        dialog.dialog(\'open\');\r\n        }\r\n\r\n        $(\'#organisationAddresses\')" +
".find(\'span.edit\').click(function () {\r\n            var componentRow = $(this).c" +
"losest(\'tr\');\r\n            editAddress(componentRow);\r\n        });\r\n\r\n        $(" +
"\'#createAddress\').click(function () {\r\n            editAddress();\r\n            r" +
"eturn false;\r\n        });\r\n\r\n        var submitAddress = function () {\r\n        " +
"    var dialog = $(\'#dialogEdit\');\r\n            var data = {\r\n                Id" +
": dialog.attr(\'data-addressid\'),\r\n                ShortName: $(\'#editShortName\')" +
".val(),\r\n                Name: $(\'#editName\').val(),\r\n                Address: $" +
"(\'#editAddress\').val(),\r\n                Suburb: $(\'#editSuburb\').val(),\r\n      " +
"          Postcode: $(\'#editPostcode\').val(),\r\n                State: $(\'#editSt" +
"ate\').val(),\r\n                Country: $(\'#editCountry\').val(),\r\n               " +
" PhoneNumber: $(\'#editPhoneNumber\').val(),\r\n                FaxNumber: $(\'#editF" +
"axNumber\').val()\r\n            };\r\n\r\n            $.ajax({\r\n                url: \'" +
"");

            
            #line 365 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                  Write(Url.Action(MVC.API.System.UpdateOrganisationAddress()));

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                dataType: \'json\',\r\n                data: data,\r\n             " +
"   type: \'post\',\r\n                success: function (d) {\r\n                    i" +
"f (d == \'OK\') {\r\n                        window.location.href = \'");

            
            #line 371 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
                                            Write(Url.Action(MVC.Config.Organisation.Index()));

            
            #line default
            #line hidden
WriteLiteral(@"';
                    } else {
                        alert('Unable to update address:\n' + d);
                        dialog.dialog('enable');
                    }
                },
                error: function (jqXHR, textStatus, errorThrown) {
                    alert('Unable to update address:\n' + textStatus);
                    dialog.dialog('enable');
                }
            });

        };
        $(""#dialogEdit"").dialog({
            resizable: false,
            modal: true,
            autoOpen: false,
            width: 350,
            buttons: {
                ""Save"": function () {
                    submitAddress();
                },
                Cancel: function () {
                    $(this).dialog(""close"");
                }
            }
        });

    });
    </script>
");

            
            #line 401 "..\..\Areas\Config\Views\Organisation\Index.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
