#pragma checksum "C:\Users\duski\source\repos\SignalR\SignalR\Views\BookItem\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd368ec70922434d26663f06af9beba2a16c8e6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookItem_Index), @"mvc.1.0.view", @"/Views/BookItem/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BookItem/Index.cshtml", typeof(AspNetCore.Views_BookItem_Index))]
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
#line 2 "C:\Users\duski\source\repos\SignalR\SignalR\Views\_ViewImports.cshtml"
using SignalR;

#line default
#line hidden
#line 3 "C:\Users\duski\source\repos\SignalR\SignalR\Views\_ViewImports.cshtml"
using SignalR.Models;

#line default
#line hidden
#line 4 "C:\Users\duski\source\repos\SignalR\SignalR\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd368ec70922434d26663f06af9beba2a16c8e6d", @"/Views/BookItem/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfffc8099bda8c783b0cdbe95ce2a59f497502d5", @"/Views/_ViewImports.cshtml")]
    public class Views_BookItem_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SignalR.Models.BookItem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\duski\source\repos\SignalR\SignalR\Views\BookItem\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 121, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    \r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(257, 45, false);
#line 17 "C:\Users\duski\source\repos\SignalR\SignalR\Views\BookItem\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Book.Name));

#line default
#line hidden
            EndContext();
            BeginContext(302, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(358, 51, false);
#line 20 "C:\Users\duski\source\repos\SignalR\SignalR\Views\BookItem\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.State.StateName));

#line default
#line hidden
            EndContext();
            BeginContext(409, 90, true);
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\duski\source\repos\SignalR\SignalR\Views\BookItem\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(548, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(609, 44, false);
#line 32 "C:\Users\duski\source\repos\SignalR\SignalR\Views\BookItem\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Book.Name));

#line default
#line hidden
            EndContext();
            BeginContext(653, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(721, 50, false);
#line 35 "C:\Users\duski\source\repos\SignalR\SignalR\Views\BookItem\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.State.StateName));

#line default
#line hidden
            EndContext();
            BeginContext(771, 73, true);
            WriteLiteral("\r\n                </td>\r\n\r\n\r\n                <td>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 844, "\"", 874, 2);
            WriteAttributeValue("", 851, "/BookItem/Edit/", 851, 15, true);
#line 40 "C:\Users\duski\source\repos\SignalR\SignalR\Views\BookItem\Index.cshtml"
WriteAttributeValue("", 866, item.ID, 866, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(875, 35, true);
            WriteLiteral(">Edit</a> |\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 910, "\"", 942, 2);
            WriteAttributeValue("", 917, "/BookItem/Delete/", 917, 17, true);
#line 41 "C:\Users\duski\source\repos\SignalR\SignalR\Views\BookItem\Index.cshtml"
WriteAttributeValue("", 934, item.ID, 934, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(943, 55, true);
            WriteLiteral(">Delete</a>\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 44 "C:\Users\duski\source\repos\SignalR\SignalR\Views\BookItem\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1009, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SignalR.Models.BookItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
