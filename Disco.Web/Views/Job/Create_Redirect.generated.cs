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
    using Disco.Web;
    using Disco.Web.Extensions;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job/Create_Redirect.cshtml")]
    public class Create_Redirect : System.Web.Mvc.WebViewPage<Disco.Web.Models.Job.CreateRedirectModel>
    {
        public Create_Redirect()
        {
        }
        public override void Execute()
        {
            
            #line 2 "..\..\Views\Job\Create_Redirect.cshtml"
  
    Layout = null;
    ViewBag.Title = Html.ToBreadcrumb("Jobs", MVC.Job.Index(), "Create - Redirecting...");

            
            #line default
            #line hidden
WriteLiteral("\r\n<a");

WriteLiteral(" id=\"redirectLink\"");

WriteAttribute("href", Tuple.Create(" href=\"", 188), Tuple.Create("\"", 214)
            
            #line 6 "..\..\Views\Job\Create_Redirect.cshtml"
, Tuple.Create(Tuple.Create("", 195), Tuple.Create<System.Object, System.Int32>(Model.RedirectLink
            
            #line default
            #line hidden
, 195), false)
);

WriteLiteral(@">Redirecting...</a>
<script>
    var redirectLink = document.getElementById('redirectLink').getAttribute('href');

    //#region Parent Dialog
    if (window.parent) {
        window.parent.window.location.href = redirectLink;

        var parentDialog = window.parent.document.getElementById('createJobDialog');
        if (parentDialog) {
            var discoDialogMethods = parentDialog.discoDialogMethods;
            discoDialogMethods.close();
        }
    }
    //#endregion
</script>
");

        }
    }
}
#pragma warning restore 1591
