#pragma checksum "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b423e9d5141e8407901196c0393d61ac3846a840"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookType_Index), @"mvc.1.0.view", @"/Views/BookType/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BookType/Index.cshtml", typeof(AspNetCore.Views_BookType_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/_ViewImports.cshtml"
using SignalR;

#line default
#line hidden
#line 3 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/_ViewImports.cshtml"
using SignalR.Models;

#line default
#line hidden
#line 4 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b423e9d5141e8407901196c0393d61ac3846a840", @"/Views/BookType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cda95d27bd1cd512491c238ac23dca4804fffe8", @"/Views/_ViewImports.cshtml")]
    public class Views_BookType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SignalR.Models.BookType>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 121, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    \r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(257, 47, false);
#line 17 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Discription));

#line default
#line hidden
            EndContext();
            BeginContext(304, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 23 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(439, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(500, 46, false);
#line 27 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Discription));

#line default
#line hidden
            EndContext();
            BeginContext(546, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 615, "\"", 645, 2);
            WriteAttributeValue("", 622, "/BookType/Edit/", 622, 15, true);
#line 30 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Index.cshtml"
WriteAttributeValue("", 637, item.ID, 637, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(646, 36, true);
            WriteLiteral(" >Edit</a> |\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 682, "\"", 714, 2);
            WriteAttributeValue("", 689, "/BookType/Delete/", 689, 17, true);
#line 31 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Index.cshtml"
WriteAttributeValue("", 706, item.ID, 706, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(715, 56, true);
            WriteLiteral(" >Delete</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 34 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(782, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SignalR.Models.BookType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
