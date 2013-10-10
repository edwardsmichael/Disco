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
    
    #line 2 "..\..\Views\Device\ImportReview.cshtml"
    using Disco.BI.DeviceBI.Importing;
    
    #line default
    #line hidden
    using Disco.BI.Extensions;
    using Disco.Models.Repository;
    using Disco.Services.Authorization;
    using Disco.Services.Web;
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Device/ImportReview.cshtml")]
    public partial class ImportReview : Disco.Services.Web.WebViewPage<Disco.Web.Models.Device.ImportReviewModel>
    {
        public ImportReview()
        {
        }
        public override void Execute()
        {
            
            #line 3 "..\..\Views\Device\ImportReview.cshtml"
  
    Authorization.Require(Claims.Device.Actions.Import);
    
    ViewBag.Title = Html.ToBreadcrumb("Devices", MVC.Device.Index(), "Import Devices", MVC.Device.ImportExport(), string.Format("File: {0}", Model.ImportFilename));

    int importDeviceOkCount = Model.ImportDevices.Count(id => id.Errors.Count == 0);
    int importDeviceNewCount = Model.ImportDevices.Count(id => id.Errors.Count == 0 && id.Device == null);
    int importDeviceUpdateCount = Model.ImportDevices.Count(id => id.Errors.Count == 0 && id.Device != null);
    int importDeviceErrorCount = Model.ImportDevices.Count - importDeviceOkCount;

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteLiteral(" id=\"deviceImportReview\"");

WriteLiteral(">\r\n");

            
            #line 14 "..\..\Views\Device\ImportReview.cshtml"
    
            
            #line default
            #line hidden
            
            #line 14 "..\..\Views\Device\ImportReview.cshtml"
     if (Model.ImportDevices.Count > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h2>Parsed ");

            
            #line 16 "..\..\Views\Device\ImportReview.cshtml"
              Write(Model.ImportDevices.Count);

            
            #line default
            #line hidden
WriteLiteral(" Device Record");

            
            #line 16 "..\..\Views\Device\ImportReview.cshtml"
                                                       Write(Model.ImportDevices.Count != 1 ? "s" : null);

            
            #line default
            #line hidden
WriteLiteral("</h2>\r\n");

WriteLiteral("        <h4>\r\n");

WriteLiteral("            ");

            
            #line 18 "..\..\Views\Device\ImportReview.cshtml"
       Write(importDeviceOkCount);

            
            #line default
            #line hidden
WriteLiteral(" of ");

            
            #line 18 "..\..\Views\Device\ImportReview.cshtml"
                               Write(Model.ImportDevices.Count);

            
            #line default
            #line hidden
WriteLiteral(" Device");

            
            #line 18 "..\..\Views\Device\ImportReview.cshtml"
                                                                 Write(Model.ImportDevices.Count != 1 ? "s" : null);

            
            #line default
            #line hidden
WriteLiteral(" are ready for import.\r\n        </h4>\r\n");

            
            #line 20 "..\..\Views\Device\ImportReview.cshtml"
        if (importDeviceErrorCount > 0)
        {

            
            #line default
            #line hidden
WriteLiteral("        <h4");

WriteLiteral(" id=\"errorMessage\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 23 "..\..\Views\Device\ImportReview.cshtml"
        Write(importDeviceErrorCount);

            
            #line default
            #line hidden
WriteLiteral(" Record");

            
            #line 23 "..\..\Views\Device\ImportReview.cshtml"
                                        Write(importDeviceErrorCount != 1 ? "s" : null);

            
            #line default
            #line hidden
WriteLiteral(" will be skipped if the import continues\r\n        </h4>\r\n");

            
            #line 25 "..\..\Views\Device\ImportReview.cshtml"
        }


            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" id=\"devicesNavigation\"");

WriteLiteral(">\r\n            <ul");

WriteLiteral(" class=\"none\"");

WriteLiteral(">\r\n");

            
            #line 29 "..\..\Views\Device\ImportReview.cshtml"
                
            
            #line default
            #line hidden
            
            #line 29 "..\..\Views\Device\ImportReview.cshtml"
                 if (importDeviceNewCount > 0)
                {
            
            #line default
            #line hidden
WriteLiteral("<li");

WriteLiteral(" class=\"statusNew\"");

WriteLiteral(">\r\n                    <input");

WriteLiteral(" id=\"devicesNavigationNew\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" checked=\"checked\"");

WriteLiteral(" /><label");

WriteLiteral(" for=\"devicesNavigationNew\"");

WriteLiteral(">Show New Devices (");

            
            #line 31 "..\..\Views\Device\ImportReview.cshtml"
                                                                                                                                         Write(Model.ImportDevices.Count(id => id.Errors.Count == 0 && id.Device == null));

            
            #line default
            #line hidden
WriteLiteral(")</label>\r\n                </li>");

            
            #line 32 "..\..\Views\Device\ImportReview.cshtml"
                     }
            
            #line default
            #line hidden
            
            #line 32 "..\..\Views\Device\ImportReview.cshtml"
                       if (importDeviceUpdateCount > 0)
                      {
            
            #line default
            #line hidden
WriteLiteral("<li");

WriteLiteral(" class=\"statusUpdate\"");

WriteLiteral(">\r\n                          <input");

WriteLiteral(" id=\"devicesNavigationUpdate\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" checked=\"checked\"");

WriteLiteral(" /><label");

WriteLiteral(" for=\"devicesNavigationUpdate\"");

WriteLiteral(">Show Updates (");

            
            #line 34 "..\..\Views\Device\ImportReview.cshtml"
                                                                                                                                                 Write(Model.ImportDevices.Count(id => id.Errors.Count == 0 && id.Device != null));

            
            #line default
            #line hidden
WriteLiteral(")</label>\r\n                      </li>");

            
            #line 35 "..\..\Views\Device\ImportReview.cshtml"
                           }
            
            #line default
            #line hidden
            
            #line 35 "..\..\Views\Device\ImportReview.cshtml"
                             if (importDeviceErrorCount > 0)
                            {
            
            #line default
            #line hidden
WriteLiteral("<li");

WriteLiteral(" class=\"statusError\"");

WriteLiteral(">\r\n                                <input");

WriteLiteral(" id=\"devicesNavigationError\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" checked=\"checked\"");

WriteLiteral(" /><label");

WriteLiteral(" for=\"devicesNavigationError\"");

WriteLiteral(">Show Errors (");

            
            #line 37 "..\..\Views\Device\ImportReview.cshtml"
                                                                                                                                                    Write(Model.ImportDevices.Count(id => id.Errors.Count != 0));

            
            #line default
            #line hidden
WriteLiteral(")</label>\r\n                            </li>");

            
            #line 38 "..\..\Views\Device\ImportReview.cshtml"
                                 }

            
            #line default
            #line hidden
WriteLiteral(@"            </ul>
            <script>
                $(function () {
                    $devices = $('#devices');
                    $rows = $devices.children('tbody').children('tr');

                    $('#devicesNavigationNew').change(function () {
                        if ($(this).is(':checked'))
                            $rows.filter('.statusNew').show();
                        else
                            $rows.filter('.statusNew').hide();
                    });

                    $('#devicesNavigationUpdate').change(function () {
                        if ($(this).is(':checked'))
                            $rows.filter('.statusUpdate').show();
                        else
                            $rows.filter('.statusUpdate').hide();
                    });

                    $('#devicesNavigationError').change(function () {
                        if ($(this).is(':checked'))
                            $rows.filter('.statusError').show();
                        else
                            $rows.filter('.statusError').hide();
                    });
                });
            </script>
        </div>
");

            
            #line 68 "..\..\Views\Device\ImportReview.cshtml"
        

            
            #line default
            #line hidden
WriteLiteral("        <table");

WriteLiteral(" id=\"devices\"");

WriteLiteral(">\r\n            <thead>\r\n                <tr>\r\n                    <th");

WriteLiteral(" class=\"row\"");

WriteLiteral(">Row</th>\r\n                    <th");

WriteLiteral(" class=\"action\"");

WriteLiteral(">Action</th>\r\n                    <th");

WriteLiteral(" class=\"serialNumber\"");

WriteLiteral(">Serial Number</th>\r\n                    <th");

WriteLiteral(" class=\"model\"");

WriteLiteral(">Model</th>\r\n                    <th");

WriteLiteral(" class=\"profile\"");

WriteLiteral(">Profile</th>\r\n                    <th");

WriteLiteral(" class=\"batch\"");

WriteLiteral(">Batch</th>\r\n                    <th");

WriteLiteral(" class=\"assignedUser\"");

WriteLiteral(">Assigned User</th>\r\n                    <th");

WriteLiteral(" class=\"location\"");

WriteLiteral(">Location</th>\r\n                    <th");

WriteLiteral(" class=\"assetNumber\"");

WriteLiteral(">Asset Number</th>\r\n                </tr>\r\n            </thead>\r\n            <tbo" +
"dy>\r\n");

            
            #line 84 "..\..\Views\Device\ImportReview.cshtml"
                
            
            #line default
            #line hidden
            
            #line 84 "..\..\Views\Device\ImportReview.cshtml"
                 foreach (var device in Model.ImportDevices)
                {
                    bool isUpdate = device.Device != null;
                    string error;

            
            #line default
            #line hidden
WriteLiteral("                    <tr");

WriteAttribute("class", Tuple.Create(" class=\"", 4454), Tuple.Create("\"", 4492)
, Tuple.Create(Tuple.Create("", 4462), Tuple.Create("status", 4462), true)
            
            #line 88 "..\..\Views\Device\ImportReview.cshtml"
, Tuple.Create(Tuple.Create("", 4468), Tuple.Create<System.Object, System.Int32>(device.ImportStatus()
            
            #line default
            #line hidden
, 4468), false)
);

WriteLiteral(">\r\n                        <td");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 90 "..\..\Views\Device\ImportReview.cshtml"
                        Write((Model.ImportDevices.IndexOf(device) + 1));

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                        <td");

WriteLiteral(" class=\"action\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 93 "..\..\Views\Device\ImportReview.cshtml"
                        Write(device.ImportStatus());

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </td>\r\n                        <td");

WriteLiteral(" class=\"serialNumber\"");

WriteLiteral(">\r\n");

            
            #line 96 "..\..\Views\Device\ImportReview.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 96 "..\..\Views\Device\ImportReview.cshtml"
                             if (device.Device == null)
                            {
                                
            
            #line default
            #line hidden
            
            #line 98 "..\..\Views\Device\ImportReview.cshtml"
                           Write(device.SerialNumber);

            
            #line default
            #line hidden
            
            #line 98 "..\..\Views\Device\ImportReview.cshtml"
                                                    
                            }
                            else
                            {
                                
            
            #line default
            #line hidden
            
            #line 102 "..\..\Views\Device\ImportReview.cshtml"
                           Write(Html.ActionLink(device.SerialNumber, MVC.Device.Show(device.SerialNumber), new { target = "_blank" }));

            
            #line default
            #line hidden
            
            #line 102 "..\..\Views\Device\ImportReview.cshtml"
                                                                                                                                      
                            }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 105 "..\..\Views\Device\ImportReview.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 105 "..\..\Views\Device\ImportReview.cshtml"
                             if (device.Errors.TryGetValue("SerialNumber", out error))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"error\"");

WriteLiteral(">");

            
            #line 107 "..\..\Views\Device\ImportReview.cshtml"
                                              Write(error);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 108 "..\..\Views\Device\ImportReview.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </td>\r\n                        <td");

WriteLiteral(" class=\"model\"");

WriteLiteral(">\r\n");

            
            #line 111 "..\..\Views\Device\ImportReview.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 111 "..\..\Views\Device\ImportReview.cshtml"
                             if (device.Errors.TryGetValue("DeviceModelId", out error))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"error\"");

WriteLiteral(">");

            
            #line 113 "..\..\Views\Device\ImportReview.cshtml"
                                              Write(error);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 114 "..\..\Views\Device\ImportReview.cshtml"
                            }
                            else
                            {
                                if (!isUpdate || device.DeviceModelId != device.Device.DeviceModelId)
                                {

            
            #line default
            #line hidden
WriteLiteral("                                <img");

WriteLiteral(" class=\"modelImage\"");

WriteLiteral(" alt=\"Model Image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 6013), Tuple.Create("\"", 6112)
            
            #line 119 "..\..\Views\Device\ImportReview.cshtml"
, Tuple.Create(Tuple.Create("", 6019), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.DeviceModel.Image(device.DeviceModel.Id, device.DeviceModel.ImageHash()))
            
            #line default
            #line hidden
, 6019), false)
);

WriteLiteral(" />\r\n");

            
            #line 120 "..\..\Views\Device\ImportReview.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 120 "..\..\Views\Device\ImportReview.cshtml"
                           Write(device.DeviceModel.ToString());

            
            #line default
            #line hidden
            
            #line 120 "..\..\Views\Device\ImportReview.cshtml"
                                                              
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Change</span>\r\n");

            
            #line 125 "..\..\Views\Device\ImportReview.cshtml"
                                }
                            }
            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td");

WriteLiteral(" class=\"profile\"");

WriteLiteral(">\r\n");

            
            #line 128 "..\..\Views\Device\ImportReview.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 128 "..\..\Views\Device\ImportReview.cshtml"
                             if (device.Errors.TryGetValue("DeviceProfileId", out error))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"error\"");

WriteLiteral(">");

            
            #line 130 "..\..\Views\Device\ImportReview.cshtml"
                                              Write(error);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 131 "..\..\Views\Device\ImportReview.cshtml"
                            }
                            else
                            {
                                if (!isUpdate || device.DeviceProfileId != device.Device.DeviceProfileId)
                                {
                                
            
            #line default
            #line hidden
            
            #line 136 "..\..\Views\Device\ImportReview.cshtml"
                           Write(device.DeviceProfile.ToString());

            
            #line default
            #line hidden
            
            #line 136 "..\..\Views\Device\ImportReview.cshtml"
                                                                
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Change</span>\r\n");

            
            #line 141 "..\..\Views\Device\ImportReview.cshtml"
                                }
                            }
            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td");

WriteLiteral(" class=\"batch\"");

WriteLiteral(">\r\n");

            
            #line 144 "..\..\Views\Device\ImportReview.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 144 "..\..\Views\Device\ImportReview.cshtml"
                             if (device.Errors.TryGetValue("DeviceBatchId", out error))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"error\"");

WriteLiteral(">");

            
            #line 146 "..\..\Views\Device\ImportReview.cshtml"
                                              Write(error);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 147 "..\..\Views\Device\ImportReview.cshtml"
                            }
                            else
                            {
                                if (!isUpdate || device.DeviceBatchId != device.Device.DeviceBatchId)
                                {
                                    if (device.DeviceBatch == null)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                ");

WriteLiteral("&lt;None&gt;");

WriteLiteral("\r\n");

            
            #line 155 "..\..\Views\Device\ImportReview.cshtml"
                                    }
                                    else
                                    {
                                
            
            #line default
            #line hidden
            
            #line 158 "..\..\Views\Device\ImportReview.cshtml"
                           Write(device.DeviceBatch.ToString());

            
            #line default
            #line hidden
            
            #line 158 "..\..\Views\Device\ImportReview.cshtml"
                                                              
                                    }
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Change</span>\r\n");

            
            #line 164 "..\..\Views\Device\ImportReview.cshtml"
                                }
                            }
            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td");

WriteLiteral(" class=\"assignedUser\"");

WriteLiteral(">\r\n");

            
            #line 167 "..\..\Views\Device\ImportReview.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 167 "..\..\Views\Device\ImportReview.cshtml"
                             if (device.Errors.TryGetValue("AssignedUserId", out error))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"error\"");

WriteLiteral(">");

            
            #line 169 "..\..\Views\Device\ImportReview.cshtml"
                                              Write(error);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 170 "..\..\Views\Device\ImportReview.cshtml"
                            }
                            else
                            {
                                if (!isUpdate || device.AssignedUserId != device.Device.AssignedUserId)
                                {
                                    if (device.AssignedUser == null)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                ");

WriteLiteral("&lt;None&gt;");

WriteLiteral("\r\n");

            
            #line 178 "..\..\Views\Device\ImportReview.cshtml"
                                    }
                                    else
                                    {
                                
            
            #line default
            #line hidden
            
            #line 181 "..\..\Views\Device\ImportReview.cshtml"
                           Write(device.AssignedUser.ToString());

            
            #line default
            #line hidden
            
            #line 181 "..\..\Views\Device\ImportReview.cshtml"
                                                               
                                    }
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Change</span>\r\n");

            
            #line 187 "..\..\Views\Device\ImportReview.cshtml"
                                }
                            }
            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td");

WriteLiteral(" class=\"location\"");

WriteLiteral(">\r\n");

            
            #line 190 "..\..\Views\Device\ImportReview.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 190 "..\..\Views\Device\ImportReview.cshtml"
                             if (device.Errors.TryGetValue("Location", out error))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"error\"");

WriteLiteral(">");

            
            #line 192 "..\..\Views\Device\ImportReview.cshtml"
                                              Write(error);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 193 "..\..\Views\Device\ImportReview.cshtml"
                            }
                            else
                            {
                                if (!isUpdate || device.Location != device.Device.Location)
                                {
                                    if (device.Location == null)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                ");

WriteLiteral("&lt;None&gt;");

WriteLiteral("\r\n");

            
            #line 201 "..\..\Views\Device\ImportReview.cshtml"
                                    }
                                    else
                                    {
                                
            
            #line default
            #line hidden
            
            #line 204 "..\..\Views\Device\ImportReview.cshtml"
                           Write(device.Location);

            
            #line default
            #line hidden
            
            #line 204 "..\..\Views\Device\ImportReview.cshtml"
                                                
                                    }
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Change</span>\r\n");

            
            #line 210 "..\..\Views\Device\ImportReview.cshtml"
                                }
                            }
            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        <td");

WriteLiteral(" class=\"assetNumber\"");

WriteLiteral(">\r\n");

            
            #line 213 "..\..\Views\Device\ImportReview.cshtml"
                            
            
            #line default
            #line hidden
            
            #line 213 "..\..\Views\Device\ImportReview.cshtml"
                             if (device.Errors.TryGetValue("AssetNumber", out error))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"error\"");

WriteLiteral(">");

            
            #line 215 "..\..\Views\Device\ImportReview.cshtml"
                                              Write(error);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

            
            #line 216 "..\..\Views\Device\ImportReview.cshtml"
                            }
                            else
                            {
                                if (!isUpdate || device.AssetNumber != device.Device.AssetNumber)
                                {
                                    if (device.AssetNumber == null)
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                ");

WriteLiteral("&lt;None&gt;");

WriteLiteral("\r\n");

            
            #line 224 "..\..\Views\Device\ImportReview.cshtml"
                                    }
                                    else
                                    {
                                
            
            #line default
            #line hidden
            
            #line 227 "..\..\Views\Device\ImportReview.cshtml"
                           Write(device.AssetNumber);

            
            #line default
            #line hidden
            
            #line 227 "..\..\Views\Device\ImportReview.cshtml"
                                                   
                                    }
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Change</span>\r\n");

            
            #line 233 "..\..\Views\Device\ImportReview.cshtml"
                                }
                            }
            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                    </tr>\r\n");

            
            #line 236 "..\..\Views\Device\ImportReview.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tbody>\r\n        </table>\r\n");

            
            #line 239 "..\..\Views\Device\ImportReview.cshtml"

                if (importDeviceOkCount > 0)
                {

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"actionBar\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 243 "..\..\Views\Device\ImportReview.cshtml"
       Write(Html.ActionLinkButton(string.Format("Import {0} Device{1}", importDeviceOkCount, importDeviceOkCount != 1 ? "s" : null), MVC.API.Device.ImportProcess(Model.ImportParseTaskId)));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n");

            
            #line 245 "..\..\Views\Device\ImportReview.cshtml"
                }
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <h2>No Devices were found in this file</h2>\r\n");

            
            #line 250 "..\..\Views\Device\ImportReview.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n");

        }
    }
}
#pragma warning restore 1591
