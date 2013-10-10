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

namespace Disco.Web.Views.Shared
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_SearchDialog.cshtml")]
    public partial class SearchDialog : Disco.Services.Web.WebViewPage<string>
    {
        public SearchDialog()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Shared\_SearchDialog.cshtml"
 using (Html.BeginForm(MVC.Search.Query(), FormMethod.Get))
{
    
            
            #line default
            #line hidden
            
            #line 4 "..\..\Views\Shared\_SearchDialog.cshtml"
Write(Html.ValidationSummary(true));

            
            #line default
            #line hidden
            
            #line 4 "..\..\Views\Shared\_SearchDialog.cshtml"
                                 

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"searchDialog\"");

WriteLiteral(" class=\"form\"");

WriteLiteral(" style=\"width: 450px\"");

WriteLiteral(">\r\n        <table>\r\n            <tr>\r\n                <th>\r\n                    Q" +
"uery:\r\n                </th>\r\n                <td>\r\n");

WriteLiteral("                    ");

            
            #line 12 "..\..\Views\Shared\_SearchDialog.cshtml"
               Write(Html.TextBox("term"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..\Views\Shared\_SearchDialog.cshtml"
                    
            
            #line default
            #line hidden
            
            #line 13 "..\..\Views\Shared\_SearchDialog.cshtml"
                     if (Model != null)
                    {
                        
            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Shared\_SearchDialog.cshtml"
                   Write(Html.Hidden("limit", Model));

            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\Shared\_SearchDialog.cshtml"
                                                    
                        if (Model == "jobs" || Model == "devices")
                        { 

            
            #line default
            #line hidden
WriteLiteral("                        <br />\r\n");

WriteLiteral("                        <input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"searchDetails\"");

WriteLiteral(" id=\"searchDetails\"");

WriteLiteral(" value=\"true\"");

WriteLiteral(" />");

WriteLiteral("<label\r\n                            for=\"searchDetails\">Search Details</label>\r\n");

            
            #line 21 "..\..\Views\Shared\_SearchDialog.cshtml"
                        }
                    }

            
            #line default
            #line hidden
WriteLiteral("                </td>\r\n            </tr>\r\n        </table>\r\n        <p");

WriteLiteral(" class=\"actions\"");

WriteLiteral(">\r\n            <input");

WriteLiteral(" type=\"submit\"");

WriteLiteral(" class=\"button\"");

WriteLiteral(" value=\"Search\"");

WriteLiteral(" />\r\n        </p>\r\n        <script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n            $(function () {\r\n                $(\'#searchDialog\').find(\'#term\')." +
"watermark(\'Search\').focus();\r\n            });\r\n        </script>\r\n    </div>\r\n");

            
            #line 35 "..\..\Views\Shared\_SearchDialog.cshtml"
}
            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
