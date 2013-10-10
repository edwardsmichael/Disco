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

namespace Disco.Web.Areas.Config.Views.DeviceProfile
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Config/Views/DeviceProfile/Defaults.cshtml")]
    public partial class Defaults : Disco.Services.Web.WebViewPage<Disco.Web.Areas.Config.Models.DeviceProfile.DefaultsModel>
    {
        public Defaults()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Areas\Config\Views\DeviceProfile\Defaults.cshtml"
  
    Authorization.Require(Claims.Config.DeviceProfile.ConfigureDefaults);
    
    ViewBag.Title = Html.ToBreadcrumb("Configuration", MVC.Config.Config.Index(), "Device Profiles", MVC.Config.DeviceProfile.Index(null), "Defaults");

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 600px\"");

WriteLiteral(">\r\n    <table>\r\n        <tr>\r\n            <th");

WriteLiteral(" class=\"name\"");

WriteLiteral(" style=\"width: 230px\"");

WriteLiteral(">\r\n                Default Profile:\r\n            </th>\r\n            <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 14 "..\..\Areas\Config\Views\DeviceProfile\Defaults.cshtml"
           Write(Html.DropDownListFor(m => m.Default, Model.DeviceProfiles.ToSelectListItems(Model.Default)));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 15 "..\..\Areas\Config\Views\DeviceProfile\Defaults.cshtml"
           Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n                <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                    $(function () {
                        $('#Default').change(function () {
                            $this = $(this);
                            $ajaxLoading = $this.next('.ajaxLoading').show();
                            var data = { id: $this.val() };
                            $.getJSON('");

            
            #line 22 "..\..\Areas\Config\Views\DeviceProfile\Defaults.cshtml"
                                   Write(Url.Action(MVC.API.DeviceProfile.Default()));

            
            #line default
            #line hidden
WriteLiteral(@"', data, function (response, result) {
                                if (result != 'success' || response != 'OK') {
                                    alert('Unable to change Default Device Profile:\n' + response);
                                    $ajaxLoading.hide();
                                } else {
                                    $ajaxLoading.hide().next('.ajaxOk').show().delay('fast').fadeOut('slow');
                                }
                            });
                        });
                    });
                </script>
            </td>
        </tr>
        <tr>
            <th");

WriteLiteral(" class=\"name\"");

WriteLiteral(">\r\n                Default Add Device Offline Profile:\r\n            </th>\r\n      " +
"      <td");

WriteLiteral(" class=\"value\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 40 "..\..\Areas\Config\Views\DeviceProfile\Defaults.cshtml"
           Write(Html.DropDownListFor(m => m.DefaultAddDeviceOffline, Model.DeviceProfilesAndNone.ToSelectListItems(Model.DefaultAddDeviceOffline)));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                ");

            
            #line 41 "..\..\Areas\Config\Views\DeviceProfile\Defaults.cshtml"
           Write(AjaxHelpers.AjaxLoader());

            
            #line default
            #line hidden
WriteLiteral("\r\n                <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(@">
                    $(function () {
                        $('#DefaultAddDeviceOffline').change(function () {
                            $this = $(this);
                            $ajaxLoading = $this.next('.ajaxLoading').show();
                            var data = { id: $this.val() };
                            $.getJSON('");

            
            #line 48 "..\..\Areas\Config\Views\DeviceProfile\Defaults.cshtml"
                                   Write(Url.Action(MVC.API.DeviceProfile.DefaultAddDeviceOffline()));

            
            #line default
            #line hidden
WriteLiteral(@"', data, function (response, result) {
                                if (result != 'success' || response != 'OK') {
                                    alert('Unable to change Default Add Device Offline Device Profile:\n' + response);
                                    $ajaxLoading.hide();
                                } else {
                                    $ajaxLoading.hide().next('.ajaxOk').show().delay('fast').fadeOut('slow');
                                }
                            });
                        });
                    });
                </script>
            </td>
        </tr>
    </table>
</div>
");

        }
    }
}
#pragma warning restore 1591
