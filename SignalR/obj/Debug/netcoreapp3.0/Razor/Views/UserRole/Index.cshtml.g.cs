#pragma checksum "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/UserRole/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c797603914f1718e3688fd6320fe8884c0580b9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRole_Index), @"mvc.1.0.view", @"/Views/UserRole/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserRole/Index.cshtml", typeof(AspNetCore.Views_UserRole_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c797603914f1718e3688fd6320fe8884c0580b9e", @"/Views/UserRole/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cda95d27bd1cd512491c238ac23dca4804fffe8", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRole_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SignalR.Models.UserRole>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/UserRole/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(135, 106, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(242, 40, false);
#line 15 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/UserRole/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(282, 98, true);
            WriteLiteral("\r\n            </th>\r\n          \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 22 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/UserRole/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(429, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(478, 39, false);
#line 26 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/UserRole/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(517, 70, true);
            WriteLiteral("\r\n            </td>\r\n           \r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 587, "\"", 619, 2);
            WriteAttributeValue("", 594, "/UserRole/Edit/", 594, 15, true);
#line 30 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/UserRole/Index.cshtml"
WriteAttributeValue("", 609, item.Role, 609, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(620, 31, true);
            WriteLiteral(">Edit</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 651, "\"", 685, 2);
            WriteAttributeValue("", 658, "/UserRole/Delete/", 658, 17, true);
#line 31 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/UserRole/Index.cshtml"
WriteAttributeValue("", 675, item.Role, 675, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(686, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 34 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/UserRole/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(744, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SignalR.Models.UserRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
