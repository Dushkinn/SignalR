#pragma checksum "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "654986043c49710f79bfcdb11ca71d1ef1db83a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StateType_Index), @"mvc.1.0.view", @"/Views/StateType/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StateType/Index.cshtml", typeof(AspNetCore.Views_StateType_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"654986043c49710f79bfcdb11ca71d1ef1db83a9", @"/Views/StateType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cda95d27bd1cd512491c238ac23dca4804fffe8", @"/Views/_ViewImports.cshtml")]
    public class Views_StateType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SignalR.Models.StateType>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(136, 121, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    \r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(258, 45, false);
#line 17 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StateName));

#line default
#line hidden
            EndContext();
            BeginContext(303, 98, true);
            WriteLiteral("\r\n            </th>\r\n          \r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 24 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(450, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(499, 44, false);
#line 28 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StateName));

#line default
#line hidden
            EndContext();
            BeginContext(543, 69, true);
            WriteLiteral("\r\n            </td>\r\n          \r\n            <td>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 612, "\"", 643, 2);
            WriteAttributeValue("", 619, "/StateType/Edit/", 619, 16, true);
#line 32 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Index.cshtml"
WriteAttributeValue("", 635, item.Id, 635, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(644, 31, true);
            WriteLiteral(">Edit</a> |\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 675, "\"", 708, 2);
            WriteAttributeValue("", 682, "/StateType/Delete/", 682, 18, true);
#line 33 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Index.cshtml"
WriteAttributeValue("", 700, item.Id, 700, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(709, 47, true);
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 36 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(767, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SignalR.Models.StateType>> Html { get; private set; }
    }
}
#pragma warning restore 1591
