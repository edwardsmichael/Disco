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

namespace Disco.Web.Views.User.UserParts
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/UserParts/_Subject.cshtml")]
    public partial class Subject : Disco.Services.Web.WebViewPage<Disco.Web.Models.User.ShowModel>
    {
        public Subject()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\User\UserParts\_Subject.cshtml"
  
    Authorization.Require(Claims.User.Show);

    var currentDeviceAssignments = Model.User.DeviceUserAssignments.Where(dua => !dua.UnassignedDate.HasValue).OrderByDescending(dua => dua.AssignedDate).ToList();

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" id=\"User_Show_Subjects\"");

WriteLiteral(">\r\n    <tbody>\r\n        <tr>\r\n            <td");

WriteLiteral(" id=\"User_Show_Details\"");

WriteLiteral(">\r\n                <div>\r\n                    <div");

WriteLiteral(" id=\"User_Show_Details_Identity\"");

WriteLiteral(">\r\n                        <table");

WriteLiteral(" class=\"none verticalHeadings\"");

WriteLiteral(">\r\n                            <tr>\r\n                                <td><span>Us" +
"ername (Id):</span>\r\n                                </td>\r\n                    " +
"            <td>\r\n                                    <h4");

WriteLiteral(" id=\"User_Show_Details_Identity_Id\"");

WriteLiteral(" title=\"Username\"");

WriteLiteral(">");

            
            #line 18 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                       Write(Model.User.Id);

            
            #line default
            #line hidden
WriteLiteral("</h4>\r\n                                </td>\r\n                            </tr>\r\n" +
"                            <tr>\r\n                                <td>Display Na" +
"me:</td>\r\n                                <td><span");

WriteLiteral(" id=\"User_Show_Details_Identity_DisplayName\"");

WriteLiteral(" title=\"Display Name\"");

WriteLiteral(">");

            
            #line 23 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                                      Write(Model.User.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n                            </tr>\r\n                            <tr>" +
"\r\n                                <td>Given Name:</td>\r\n                        " +
"        <td><span");

WriteLiteral(" id=\"User_Show_Details_Identity_GivenName\"");

WriteLiteral(" title=\"Given Name\"");

WriteLiteral(">");

            
            #line 27 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                                  Write(Model.User.GivenName);

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n                            </tr>\r\n                            <tr>" +
"\r\n                                <td>Surname:</td>\r\n                           " +
"     <td><span");

WriteLiteral(" id=\"User_Show_Details_Identity_Surname\"");

WriteLiteral(" title=\"Surname\"");

WriteLiteral(">");

            
            #line 31 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                             Write(Model.User.Surname);

            
            #line default
            #line hidden
WriteLiteral("</span></td>\r\n                            </tr>\r\n                        </table>" +
"\r\n                    </div>\r\n                    <div");

WriteLiteral(" id=\"User_Show_Details_Attributes\"");

WriteLiteral(" class=\"status\"");

WriteLiteral(">\r\n                        <table");

WriteLiteral(" class=\"none verticalHeadings\"");

WriteLiteral(">\r\n                            <tr>\r\n                                <td>Email:</" +
"td>\r\n                                <td>\r\n");

            
            #line 40 "..\..\Views\User\UserParts\_Subject.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 40 "..\..\Views\User\UserParts\_Subject.cshtml"
                                     if (!string.IsNullOrEmpty(Model.User.EmailAddress))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <span");

WriteLiteral(" id=\"User_Show_Details_Attributes_Email\"");

WriteLiteral(" title=\"Email Address [Update in Active Directory]\"");

WriteLiteral(">");

            
            #line 42 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                                                                    Write(Model.User.EmailAddress);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 43 "..\..\Views\User\UserParts\_Subject.cshtml"
                                    }
                                    else
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">Unknown</span>\r\n");

            
            #line 47 "..\..\Views\User\UserParts\_Subject.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </td>\r\n                            </tr>\r\n       " +
"                     <tr>\r\n                                <td>Phone:</td>\r\n    " +
"                            <td>\r\n");

            
            #line 53 "..\..\Views\User\UserParts\_Subject.cshtml"
                                    
            
            #line default
            #line hidden
            
            #line 53 "..\..\Views\User\UserParts\_Subject.cshtml"
                                     if (!string.IsNullOrEmpty(Model.User.PhoneNumber))
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <span");

WriteLiteral(" id=\"User_Show_Details_Attributes_Phone\"");

WriteLiteral(" title=\"Phone Number [Update in Active Directory]\"");

WriteLiteral(">");

            
            #line 55 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                                                                   Write(Model.User.PhoneNumber);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 56 "..\..\Views\User\UserParts\_Subject.cshtml"
                                    }
                                    else
                                    {

            
            #line default
            #line hidden
WriteLiteral("                                        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">Unknown</span>\r\n");

            
            #line 60 "..\..\Views\User\UserParts\_Subject.cshtml"
                                    }

            
            #line default
            #line hidden
WriteLiteral("                                </td>\r\n                            </tr>\r\n       " +
"                 </table>\r\n                    </div>\r\n");

            
            #line 65 "..\..\Views\User\UserParts\_Subject.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 65 "..\..\Views\User\UserParts\_Subject.cshtml"
                     if (Authorization.Has(Claims.User.Actions.GenerateDocuments))
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div");

WriteLiteral(" id=\"User_Show_GenerateDocument_Container\"");

WriteLiteral(" class=\"status\"");

WriteLiteral(">\r\n");

WriteLiteral("                            ");

            
            #line 68 "..\..\Views\User\UserParts\_Subject.cshtml"
                       Write(Html.DropDownList("User_Show_GenerateDocument", Model.DocumentTemplatesSelectListItems));

            
            #line default
            #line hidden
WriteLiteral("\r\n                            <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n                                $(function () {\r\n                             " +
"       var generatePdfUrl = \'");

            
            #line 71 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                     Write(Url.Action(MVC.API.User.GeneratePdf(Model.User.Id, null)));

            
            #line default
            #line hidden
WriteLiteral(@"?DocumentTemplateId=';
                                    var $documentTemplates = $('#User_Show_GenerateDocument');
                                    $documentTemplates.change(function () {
                                        var v = $documentTemplates.val();
                                        if (v) {
                                            window.location.href = generatePdfUrl + v;
                                            $documentTemplates.val('').blur();
                                        }
                                    });
                                });
                            </script>
                        </div>
");

            
            #line 83 "..\..\Views\User\UserParts\_Subject.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                    <div");

WriteLiteral(" id=\"User_Show_Details_Actions\"");

WriteLiteral(">\r\n");

            
            #line 85 "..\..\Views\User\UserParts\_Subject.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 85 "..\..\Views\User\UserParts\_Subject.cshtml"
                         if (Authorization.Has(Claims.Job.Actions.Create))
                        {
                            Html.BundleDeferred("~/ClientScripts/Modules/Disco-CreateJob");
                            
            
            #line default
            #line hidden
            
            #line 88 "..\..\Views\User\UserParts\_Subject.cshtml"
                       Write(Html.ActionLinkSmallButton("Create Job", MVC.Job.Create(Model.PrimaryDeviceSerialNumber, Model.User.Id), "User_Show_Details_Actions_CreateJob_Button"));

            
            #line default
            #line hidden
            
            #line 88 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                                                                                                                   
                            if (currentDeviceAssignments.Count > 1)
                            {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" id=\"User_Show_Details_Actions_CreateJob_Dialog\"");

WriteLiteral(" class=\"dialog\"");

WriteLiteral(" title=\"Create Job for Which Device?\"");

WriteLiteral(">\r\n                                <div");

WriteLiteral(" class=\"clearfix\"");

WriteLiteral(">\r\n                                    <span");

WriteLiteral(" class=\"ui-icon ui-icon-info\"");

WriteLiteral(" style=\"float: left; margin: 0 7px 20px 0;\"");

WriteLiteral(@"></span>
                                    Multiple devices are assigned to this user. Which device should be associated with this job?
                                </div>
                                <div>
                                    <ul");

WriteLiteral(" id=\"CreateJob_Assignments\"");

WriteLiteral(" class=\"none\"");

WriteLiteral(">\r\n");

            
            #line 98 "..\..\Views\User\UserParts\_Subject.cshtml"
                                        
            
            #line default
            #line hidden
            
            #line 98 "..\..\Views\User\UserParts\_Subject.cshtml"
                                         foreach (var assignment in currentDeviceAssignments)
                                        {

            
            #line default
            #line hidden
WriteLiteral("                                            <li");

WriteLiteral(" class=\"CreateJob_Assignment clearfix\"");

WriteLiteral(" data-createjoburl=\"");

            
            #line 100 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                                    Write(Url.Action(MVC.Job.Create(assignment.DeviceSerialNumber, Model.User.Id)));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n                                                <img");

WriteLiteral(" class=\"CreateJob_Assignment_Image\"");

WriteLiteral(" alt=\"Model Image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 6191), Tuple.Create("\"", 6312)
            
            #line 101 "..\..\Views\User\UserParts\_Subject.cshtml"
                               , Tuple.Create(Tuple.Create("", 6197), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.DeviceModel.Image(assignment.Device.DeviceModel.Id, assignment.Device.DeviceModel.ImageHash()))
            
            #line default
            #line hidden
, 6197), false)
);

WriteLiteral(" />\r\n                                                <div");

WriteLiteral(" class=\"CreateJob_Assignment_Details\"");

WriteLiteral(">\r\n                                                    <table");

WriteLiteral(" class=\"none\"");

WriteLiteral(@">
                                                        <tbody>
                                                            <tr>
                                                                <td>Serial Number:
                                                                </td>
                                                                <td>
                                                                    <span>");

            
            #line 109 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                     Write(assignment.Device.SerialNumber);

            
            #line default
            #line hidden
WriteLiteral("</span> (<span>");

            
            #line 109 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                                                   Write(assignment.Device.ComputerName);

            
            #line default
            #line hidden
WriteLiteral(@"</span>)
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td>Model:
                                                                </td>
                                                                <td>
                                                                    <span>");

            
            #line 116 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                     Write(assignment.Device.DeviceModel.ToString());

            
            #line default
            #line hidden
WriteLiteral(@"</span>
                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td>Asset:</td>
                                                                <td>
");

            
            #line 122 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                    
            
            #line default
            #line hidden
            
            #line 122 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                     if (!string.IsNullOrEmpty(assignment.Device.AssetNumber))
                                                                    {

            
            #line default
            #line hidden
WriteLiteral("                                                                        <span>");

            
            #line 124 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                         Write(assignment.Device.AssetNumber);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 125 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                    }
                                                                    else
                                                                    {

            
            #line default
            #line hidden
WriteLiteral("                                                                        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">Unknown</span>\r\n");

            
            #line 129 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                    }

            
            #line default
            #line hidden
WriteLiteral(@"                                                                </td>
                                                            </tr>
                                                            <tr>
                                                                <td>Assigned:</td>
                                                                <td>
                                                                    <span>");

            
            #line 135 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                     Write(CommonHelpers.FriendlyDate(assignment.AssignedDate));

            
            #line default
            #line hidden
WriteLiteral(@"</span>
                                                                </td>
                                                            </tr>
                                                        </tbody>
                                                    </table>
                                                </div>
                                            </li>   
");

            
            #line 142 "..\..\Views\User\UserParts\_Subject.cshtml"
                                        }

            
            #line default
            #line hidden
WriteLiteral("                                    </ul>\r\n                                </div>" +
"\r\n                            </div>\r\n");

WriteLiteral("                            <script>\r\n                                $(function " +
"() {\r\n                                    var button = $(\'#User_Show_Details_Act" +
"ions_CreateJob_Button\');\r\n                                    var buttonDialog =" +
" null;\r\n\r\n                                    button.click(function () {\r\n      " +
"                                  if (!buttonDialog) {\r\n                        " +
"                    buttonDialog = $(\'#User_Show_Details_Actions_CreateJob_Dialo" +
"g\').dialog({\r\n                                                resizable: false,\r" +
"\n                                                width: 400,\r\n                  " +
"                              modal: true,\r\n                                    " +
"            autoOpen: false,\r\n                                                bu" +
"ttons: {\r\n                                                    Cancel: function (" +
") {\r\n                                                        $(this).dialog(\"clo" +
"se\");\r\n                                                    }\r\n                  " +
"                              }\r\n                                            });" +
"\r\n\r\n                                            dialogItems = buttonDialog.find(" +
"\'li.CreateJob_Assignment\');\r\n\r\n                                            dialo" +
"gItems.click(function () {\r\n                                                var " +
"$this = $(this);\r\n\r\n                                                buttonDialog" +
".dialog(\"close\");\r\n\r\n                                                var createJ" +
"obUrl = $this.attr(\'data-createjoburl\');\r\n                                      " +
"          document.DiscoFunctions.CreateOpenJobDialog(createJobUrl);\r\n          " +
"                                  });\r\n                                        }" +
"\r\n\r\n                                        buttonDialog.dialog(\'open\');\r\n      " +
"                                  return false;\r\n                               " +
"     });\r\n                                });\r\n                            </scr" +
"ipt>\r\n");

            
            #line 182 "..\..\Views\User\UserParts\_Subject.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral(@"                            <script>
                                $(function () {
                                    $('#User_Show_Details_Actions_CreateJob_Button').click(function () {
                                        var $this = $(this);
                                        var href = $this.attr('href');

                                        document.DiscoFunctions.CreateOpenJobDialog(href);

                                        return false;
                                    });
                                });
                            </script>
");

            
            #line 197 "..\..\Views\User\UserParts\_Subject.cshtml"
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                </div>\r\n            </td>\r\n          " +
"  <td");

WriteLiteral(" id=\"User_Show_AssignedDevices\"");

WriteLiteral(">\r\n                <div>\r\n                    <div");

WriteLiteral(" id=\"User_Show_AssignedDevices_Active\"");

WriteLiteral(">\r\n                        <h3>Current Device Assignments</h3>\r\n");

            
            #line 206 "..\..\Views\User\UserParts\_Subject.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 206 "..\..\Views\User\UserParts\_Subject.cshtml"
                         if (currentDeviceAssignments.Count > 0)
                        {
                            foreach (var assignment in currentDeviceAssignments)
                            {

            
            #line default
            #line hidden
WriteLiteral("                            <div");

WriteLiteral(" class=\"User_Show_AssignedDevices_CurrentAssignment clearfix\"");

WriteLiteral(" data-deviceserialnumber=\"");

            
            #line 210 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                                                  Write(assignment.DeviceSerialNumber);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">\r\n");

            
            #line 211 "..\..\Views\User\UserParts\_Subject.cshtml"
                                
            
            #line default
            #line hidden
            
            #line 211 "..\..\Views\User\UserParts\_Subject.cshtml"
                                 if (Authorization.Has(Claims.Device.Show))
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 13184), Tuple.Create("\"", 13251)
            
            #line 213 "..\..\Views\User\UserParts\_Subject.cshtml"
, Tuple.Create(Tuple.Create("", 13191), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Device.Show(assignment.Device.SerialNumber))
            
            #line default
            #line hidden
, 13191), false)
);

WriteLiteral(">\r\n                                        <img");

WriteLiteral(" class=\"User_Show_AssignedDevices_CurrentAssignment_Image\"");

WriteLiteral(" alt=\"Model Image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 13375), Tuple.Create("\"", 13496)
            
            #line 214 "..\..\Views\User\UserParts\_Subject.cshtml"
                                             , Tuple.Create(Tuple.Create("", 13381), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.DeviceModel.Image(assignment.Device.DeviceModel.Id, assignment.Device.DeviceModel.ImageHash()))
            
            #line default
            #line hidden
, 13381), false)
);

WriteLiteral(" />\r\n                                    </a>\r\n");

            
            #line 216 "..\..\Views\User\UserParts\_Subject.cshtml"
                                }
                                else
                                {

            
            #line default
            #line hidden
WriteLiteral("                                    <img");

WriteLiteral(" class=\"User_Show_AssignedDevices_CurrentAssignment_Image\"");

WriteLiteral(" alt=\"Model Image\"");

WriteAttribute("src", Tuple.Create(" src=\"", 13768), Tuple.Create("\"", 13889)
            
            #line 219 "..\..\Views\User\UserParts\_Subject.cshtml"
                                         , Tuple.Create(Tuple.Create("", 13774), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.API.DeviceModel.Image(assignment.Device.DeviceModel.Id, assignment.Device.DeviceModel.ImageHash()))
            
            #line default
            #line hidden
, 13774), false)
);

WriteLiteral(" />\r\n");

            
            #line 220 "..\..\Views\User\UserParts\_Subject.cshtml"
                                }

            
            #line default
            #line hidden
WriteLiteral("                                <div");

WriteLiteral(" class=\"User_Show_AssignedDevices_CurrentAssignment_Details\"");

WriteLiteral(">\r\n                                    <table");

WriteLiteral(" class=\"none\"");

WriteLiteral(@">
                                        <tbody>
                                            <tr>
                                                <td>Serial Number:
                                                </td>
                                                <td>
                                                    <span");

WriteLiteral(" class=\"User_Show_AssignedDevices_CurrentAssignment_SerialNumber\"");

WriteLiteral(">\r\n");

            
            #line 229 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                        
            
            #line default
            #line hidden
            
            #line 229 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                         if (Authorization.Has(Claims.Device.Show))
                                                        {
                                                            
            
            #line default
            #line hidden
            
            #line 231 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                       Write(Html.ActionLink(assignment.Device.SerialNumber, MVC.Device.Show(assignment.Device.SerialNumber)));

            
            #line default
            #line hidden
            
            #line 231 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                                                                                             
                                                        }
                                                        else
                                                        {
                                                            
            
            #line default
            #line hidden
            
            #line 235 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                       Write(assignment.Device.SerialNumber);

            
            #line default
            #line hidden
            
            #line 235 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                           
                                                        }

            
            #line default
            #line hidden
WriteLiteral("                                                    </span>(<span>");

            
            #line 237 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                             Write(assignment.Device.ComputerName);

            
            #line default
            #line hidden
WriteLiteral(@"</span>)
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Model:
                                                </td>
                                                <td>
                                                    <span");

WriteLiteral(" class=\"User_Show_AssignedDevices_CurrentAssignment_Model\"");

WriteLiteral(">");

            
            #line 244 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                                               Write(assignment.Device.DeviceModel.ToString());

            
            #line default
            #line hidden
WriteLiteral(@"</span>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Asset:</td>
                                                <td>
");

            
            #line 250 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                    
            
            #line default
            #line hidden
            
            #line 250 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                     if (!string.IsNullOrEmpty(assignment.Device.AssetNumber))
                                                    {

            
            #line default
            #line hidden
WriteLiteral("                                                        <span");

WriteLiteral(" class=\"User_Show_AssignedDevices_CurrentAssignment_Asset\"");

WriteLiteral(">");

            
            #line 252 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                                                   Write(assignment.Device.AssetNumber);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 253 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                    }
                                                    else
                                                    {

            
            #line default
            #line hidden
WriteLiteral("                                                        <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">Unknown</span>\r\n");

            
            #line 257 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                    }

            
            #line default
            #line hidden
WriteLiteral(@"                                                </td>
                                            </tr>
                                            <tr>
                                                <td>Assigned:</td>
                                                <td>
                                                    <span");

WriteLiteral(" class=\"User_Show_AssignedDevices_CurrentAssignment_Assigned\"");

WriteLiteral(">");

            
            #line 263 "..\..\Views\User\UserParts\_Subject.cshtml"
                                                                                                                  Write(CommonHelpers.FriendlyDate(assignment.AssignedDate));

            
            #line default
            #line hidden
WriteLiteral(@"</span>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>   
");

            
            #line 270 "..\..\Views\User\UserParts\_Subject.cshtml"
                            }
                        }
                        else
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <span");

WriteLiteral(" class=\"smallMessage\"");

WriteLiteral(">No Current Device Assignments</span>\r\n");

            
            #line 275 "..\..\Views\User\UserParts\_Subject.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </div>\r\n                </div>\r\n            </td>\r\n        </" +
"tr>\r\n    </tbody>\r\n</table>\r\n");

        }
    }
}
#pragma warning restore 1591
