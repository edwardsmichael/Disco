﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
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
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/User/UserParts/_Jobs.cshtml")]
    public partial class Jobs : System.Web.Mvc.WebViewPage<Disco.Web.Models.User.ShowModel>
    {
        public Jobs()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");

WriteLiteral(" id=\"UserDetailTab-Jobs\"");

WriteLiteral(" class=\"UserPart\"");

WriteLiteral(">\r\n    <div");

WriteLiteral(" id=\"UserDetailTab-JobsContainer\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 4 "..\..\Views\User\UserParts\_Jobs.cshtml"
   Write(Html.Partial(MVC.Shared.Views._JobTable, Model.Jobs));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <script>\r\n        $(\'#UserDetailTabItems\').append(\'<li><a href=" +
"\"#UserDetailTab-Jobs\">Jobs [");

            
            #line 7 "..\..\Views\User\UserParts\_Jobs.cshtml"
                                                                             Write(Model.User.Jobs == null ? 0 : Model.User.Jobs.Count);

            
            #line default
            #line hidden
WriteLiteral("]</a></li>\');\r\n    </script>\r\n</div>");

        }
    }
}
#pragma warning restore 1591
