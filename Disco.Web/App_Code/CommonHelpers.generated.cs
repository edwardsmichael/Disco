﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Disco.Web
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 5 "..\..\App_Code\CommonHelpers.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 6 "..\..\App_Code\CommonHelpers.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.WebPages.Html;
    
    #line 2 "..\..\App_Code\CommonHelpers.cshtml"
    using Disco.BI.Extensions;
    
    #line default
    #line hidden
    
    #line 3 "..\..\App_Code\CommonHelpers.cshtml"
    using Disco.Models.Repository;
    
    #line default
    #line hidden
    
    #line 7 "..\..\App_Code\CommonHelpers.cshtml"
    using Disco.Services.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\App_Code\CommonHelpers.cshtml"
    using Disco.Web;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public class CommonHelpers : System.Web.WebPages.HelperPage
    {

public static System.Web.WebPages.HelperResult FriendlyDate(DateTime d, string ElementId = null)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 9 "..\..\App_Code\CommonHelpers.cshtml"
 

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    <span ");



#line 10 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, ElementId == null ? null : new HtmlString(string.Format("id=\"{0}\" ", ElementId)));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "title=\"");



#line 10 "..\..\App_Code\CommonHelpers.cshtml"
                                                                       WriteTo(@__razor_helper_writer, d.ToFullDateTime());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" data-discodatetime=\"");



#line 10 "..\..\App_Code\CommonHelpers.cshtml"
                                                                                                                WriteTo(@__razor_helper_writer, d.ToSortableDateTime());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" data-datetimeformatted=\"");



#line 10 "..\..\App_Code\CommonHelpers.cshtml"
                                                                                                                                                                 WriteTo(@__razor_helper_writer, d.ToJavascriptDateTime());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" class=\"date nowrap\">");



#line 10 "..\..\App_Code\CommonHelpers.cshtml"
                                                                                                                                                                                                                WriteTo(@__razor_helper_writer, d.ToFuzzy());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</span>\r\n");



#line 11 "..\..\App_Code\CommonHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult FriendlyDate(DateTime? d, string NullValue = "N/A", string ElementId = null)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 13 "..\..\App_Code\CommonHelpers.cshtml"
 

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    <span ");



#line 14 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, ElementId == null ? null : new HtmlString(string.Format("id=\"{0}\" ", ElementId)));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "title=\"");



#line 14 "..\..\App_Code\CommonHelpers.cshtml"
                                                                       WriteTo(@__razor_helper_writer, d.ToFullDateTime(NullValue));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" data-discodatetime=\"");



#line 14 "..\..\App_Code\CommonHelpers.cshtml"
                                                                                                                         WriteTo(@__razor_helper_writer, d.ToSortableDateTime());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" data-datetimeformatted=\"");



#line 14 "..\..\App_Code\CommonHelpers.cshtml"
                                                                                                                                                                          WriteTo(@__razor_helper_writer, d.ToJavascriptDateTime());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" class=\"date nowrap\">");



#line 14 "..\..\App_Code\CommonHelpers.cshtml"
                                                                                                                                                                                                                         WriteTo(@__razor_helper_writer, d.ToFuzzy(NullValue));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</span>\r\n");



#line 15 "..\..\App_Code\CommonHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult RadioButtonList(string id, List<System.Web.Mvc.SelectListItem> items, int columns = 1)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 17 "..\..\App_Code\CommonHelpers.cshtml"
 
    
#line default
#line hidden


#line 18 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, ItemList("radio", id, items, columns));

#line default
#line hidden


#line 18 "..\..\App_Code\CommonHelpers.cshtml"
                                          

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult CheckBoxList(string id, List<System.Web.Mvc.SelectListItem> items, int columns = 1, bool alignEven = true, int? forceUniqueIds = null)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 21 "..\..\App_Code\CommonHelpers.cshtml"
 
    
#line default
#line hidden


#line 22 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, ItemList("checkbox", id, items, columns, alignEven, forceUniqueIds));

#line default
#line hidden


#line 22 "..\..\App_Code\CommonHelpers.cshtml"
                                                                        

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult ItemList(string inputType, string id, List<System.Web.Mvc.SelectListItem> items, int columns = 1, bool alignEven = true, int? forceUniqueIds = null)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 25 "..\..\App_Code\CommonHelpers.cshtml"
 
    int itemsPerColumn = items.Count / columns;
    int columnWidth = (100 / columns);
    var itemNextId = 0;

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    <table class=\"none\">\r\n        <tr>\r\n");



#line 31 "..\..\App_Code\CommonHelpers.cshtml"
             for (int i = 0; i < columns; i++)
            {

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "                <td");



#line 33 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, alignEven ? new HtmlString(string.Format(" style=\"width: {0}%\"", columnWidth)) : new HtmlString(string.Empty));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, ">\r\n                    <ul class=\"none\">\r\n");



#line 35 "..\..\App_Code\CommonHelpers.cshtml"
                          
                int itemsForThisColumn = itemsPerColumn + (items.Count % columns > i ? 1 : 0);
                for (int i2 = 0; i2 < itemsForThisColumn && itemNextId < items.Count; i2++)
                {
                    var item = items[itemNextId];
                    itemNextId++;
                    var itemId = forceUniqueIds.HasValue ? string.Format("{0}_{1}_{2}", id, item.Value, forceUniqueIds++) : string.Format("{0}_{1}", id, item.Value);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "                            <li>\r\n                                <input id=\"");



#line 43 "..\..\App_Code\CommonHelpers.cshtml"
            WriteTo(@__razor_helper_writer, itemId);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" name=\"");



#line 43 "..\..\App_Code\CommonHelpers.cshtml"
                           WriteTo(@__razor_helper_writer, id);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" value=\"");



#line 43 "..\..\App_Code\CommonHelpers.cshtml"
                                       WriteTo(@__razor_helper_writer, item.Value);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" type=\"");



#line 43 "..\..\App_Code\CommonHelpers.cshtml"
                                                          WriteTo(@__razor_helper_writer, inputType);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" ");



#line 43 "..\..\App_Code\CommonHelpers.cshtml"
                                                                       WriteTo(@__razor_helper_writer, item.Selected ? new HtmlString("checked=\"checked\" ") : null);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "/><label for=\"");



#line 43 "..\..\App_Code\CommonHelpers.cshtml"
                                                                                                                                                    WriteTo(@__razor_helper_writer, itemId);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\">");



#line 43 "..\..\App_Code\CommonHelpers.cshtml"
                                                                                                                                                             WriteTo(@__razor_helper_writer, item.Text);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</label></li>\r\n");



#line 44 "..\..\App_Code\CommonHelpers.cshtml"
                }
                        

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "                    </ul>\r\n                </td>\r\n");



#line 48 "..\..\App_Code\CommonHelpers.cshtml"
            }

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "        </tr>\r\n    </table>\r\n");



#line 51 "..\..\App_Code\CommonHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult FriendlyDateAndUser(DateTime? d, User u, string DateNullValue = "N/A")
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 53 "..\..\App_Code\CommonHelpers.cshtml"
 
    
#line default
#line hidden


#line 54 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, FriendlyDate(d, DateNullValue));

#line default
#line hidden


#line 54 "..\..\App_Code\CommonHelpers.cshtml"
                                   ;
    
#line default
#line hidden


#line 55 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, FriendlyUser(u, null, "by"));

#line default
#line hidden


#line 55 "..\..\App_Code\CommonHelpers.cshtml"
                                ;

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult FriendlyDateAndUser(DateTime d, User u)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 58 "..\..\App_Code\CommonHelpers.cshtml"
 
    
#line default
#line hidden


#line 59 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, FriendlyDate(d));

#line default
#line hidden


#line 59 "..\..\App_Code\CommonHelpers.cshtml"
                    ;
    
#line default
#line hidden


#line 60 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, FriendlyUser(u, null, "by"));

#line default
#line hidden


#line 60 "..\..\App_Code\CommonHelpers.cshtml"
                                ;

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult FriendlyDateAndTitleUser(DateTime? d, User u, string DateNullValue = "N/A")
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 63 "..\..\App_Code\CommonHelpers.cshtml"
 

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    <span title=\"");



#line 64 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, d.ToFullDateTime(DateNullValue));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, " by ");



#line 64 "..\..\App_Code\CommonHelpers.cshtml"
                      WriteTo(@__razor_helper_writer, u);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" data-discodatetime=\"");



#line 64 "..\..\App_Code\CommonHelpers.cshtml"
                                              WriteTo(@__razor_helper_writer, d.ToSortableDateTime());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" class=\"date nowrap\">");



#line 64 "..\..\App_Code\CommonHelpers.cshtml"
                                                                                           WriteTo(@__razor_helper_writer, d.ToFuzzy(DateNullValue));

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</span>\r\n");



#line 65 "..\..\App_Code\CommonHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult FriendlyDateAndTitleUser(DateTime d, User u)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 67 "..\..\App_Code\CommonHelpers.cshtml"
 

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    <span title=\"");



#line 68 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, d.ToFullDateTime());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, " by ");



#line 68 "..\..\App_Code\CommonHelpers.cshtml"
         WriteTo(@__razor_helper_writer, u);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" data-discodatetime=\"");



#line 68 "..\..\App_Code\CommonHelpers.cshtml"
                                 WriteTo(@__razor_helper_writer, d.ToSortableDateTime());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" class=\"date nowrap\">");



#line 68 "..\..\App_Code\CommonHelpers.cshtml"
                                                                              WriteTo(@__razor_helper_writer, d.ToFuzzy());

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</span>\r\n");



#line 69 "..\..\App_Code\CommonHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult FriendlyUser(User u, string nullValue = null, string prepend = null)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 71 "..\..\App_Code\CommonHelpers.cshtml"
 
    if (u != null)
    { 
    
#line default
#line hidden


#line 74 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, prepend);

#line default
#line hidden


WriteLiteralTo(@__razor_helper_writer, " <span title=\"");



#line 74 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, u);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\">");



#line 74 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, u.Id);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</span>\r\n");



#line 75 "..\..\App_Code\CommonHelpers.cshtml"
    }
    else
    { 

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    <span>");



#line 78 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, nullValue);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</span>\r\n");



#line 79 "..\..\App_Code\CommonHelpers.cshtml"
    }

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult Breadcrumbs(List<Tuple<string, ActionResult>> BreadCrumbs)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 82 "..\..\App_Code\CommonHelpers.cshtml"
 
    for (int index = 0; index < BreadCrumbs.Count; index++)
    {
        var breadCrumb = BreadCrumbs[index];
        if (index != 0)
        {

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    <span>&gt;</span>\r\n");



#line 89 "..\..\App_Code\CommonHelpers.cshtml"
        }
        if (breadCrumb.Item2 == null)
        {
    
#line default
#line hidden


#line 92 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, breadCrumb.Item1);

#line default
#line hidden


#line 92 "..\..\App_Code\CommonHelpers.cshtml"
                     
        }
        else
        { 
    
#line default
#line hidden


#line 96 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, Html.GetPageHelper().ActionLink(breadCrumb.Item1, breadCrumb.Item2));

#line default
#line hidden


#line 96 "..\..\App_Code\CommonHelpers.cshtml"
                                                                        
        }
    }

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult Breadcrumbs(string Title)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 101 "..\..\App_Code\CommonHelpers.cshtml"
 
    
#line default
#line hidden


#line 102 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, Title);

#line default
#line hidden


#line 102 "..\..\App_Code\CommonHelpers.cshtml"
          

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult BreadcrumbsTitle(List<Tuple<string, ActionResult>> BreadCrumbs)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 105 "..\..\App_Code\CommonHelpers.cshtml"
 
    for (int index = 0; index < BreadCrumbs.Count; index++)
    {
        var breadCrumb = BreadCrumbs[index];
        if (index != 0)
        {
    
#line default
#line hidden


#line 111 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, new HtmlString(" > "));

#line default
#line hidden


#line 111 "..\..\App_Code\CommonHelpers.cshtml"
                            
        }
    
#line default
#line hidden


#line 113 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, breadCrumb.Item1);

#line default
#line hidden


#line 113 "..\..\App_Code\CommonHelpers.cshtml"
                     
    }

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult BreadcrumbsTitle(string Title)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 117 "..\..\App_Code\CommonHelpers.cshtml"
 
    
#line default
#line hidden


#line 118 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, Title);

#line default
#line hidden


#line 118 "..\..\App_Code\CommonHelpers.cshtml"
          

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult CheckboxBulkSelect(string BulkSelectContainerId, string ParentJQuerySelector = null)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 121 "..\..\App_Code\CommonHelpers.cshtml"
 Html.GetPageHelper().BundleDeferred("~/ClientScripts/Modules/Disco-jQueryExtensions");

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    <span id=\"");



#line 122 "..\..\App_Code\CommonHelpers.cshtml"
WriteTo(@__razor_helper_writer, BulkSelectContainerId);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\" class=\"checkboxBulkSelectContainer\">\r\n");



#line 123 "..\..\App_Code\CommonHelpers.cshtml"
         if (string.IsNullOrWhiteSpace(ParentJQuerySelector))
        {

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "            <script type=\"text/javascript\">$(function () { $(\'#");



#line 125 "..\..\App_Code\CommonHelpers.cshtml"
                                 WriteTo(@__razor_helper_writer, BulkSelectContainerId);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\').checkboxBulkSelect(); });</script>\r\n");



#line 126 "..\..\App_Code\CommonHelpers.cshtml"
        }
        else
        {

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "            <script type=\"text/javascript\">$(function () { $(\'#");



#line 129 "..\..\App_Code\CommonHelpers.cshtml"
                                 WriteTo(@__razor_helper_writer, BulkSelectContainerId);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\').checkboxBulkSelect({ parentSelector: \'");



#line 129 "..\..\App_Code\CommonHelpers.cshtml"
                                                                                                  WriteTo(@__razor_helper_writer, ParentJQuerySelector);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\' }); });</script>\r\n");



#line 130 "..\..\App_Code\CommonHelpers.cshtml"
        }

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "    </span>\r\n");



#line 132 "..\..\App_Code\CommonHelpers.cshtml"

#line default
#line hidden

});

}


        public CommonHelpers()
        {
        }
    }
}
#pragma warning restore 1591
