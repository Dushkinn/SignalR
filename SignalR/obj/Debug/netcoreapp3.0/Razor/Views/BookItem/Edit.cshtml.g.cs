#pragma checksum "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookItem/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2dc75c869565bba91137c34ec81e3c7922f6b17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookItem_Edit), @"mvc.1.0.view", @"/Views/BookItem/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BookItem/Edit.cshtml", typeof(AspNetCore.Views_BookItem_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2dc75c869565bba91137c34ec81e3c7922f6b17", @"/Views/BookItem/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cda95d27bd1cd512491c238ac23dca4804fffe8", @"/Views/_ViewImports.cshtml")]
    public class Views_BookItem_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignalR.Models.ViewModel.BookItemViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookItem/Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(142, 91, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Author</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
            EndContext();
#line 15 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookItem/Edit.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(292, 23, false);
#line 17 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookItem/Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(334, 89, false);
#line 20 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookItem/Edit.cshtml"
       Write(Html.ValidationSummary(true, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(438, 33, false);
#line 21 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookItem/Edit.cshtml"
       Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(473, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(528, 89, false);
#line 23 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookItem/Edit.cshtml"
           Write(Html.LabelFor(model => model.Book.Name, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(617, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(636, 98, false);
#line 24 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookItem/Edit.cshtml"
           Write(Html.EditorFor(model => model.Book.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(734, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(753, 112, false);
#line 25 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookItem/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Book.Name, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(865, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(942, 95, false);
#line 28 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookItem/Edit.cshtml"
           Write(Html.LabelFor(model => model.State.StateName, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1056, 104, false);
#line 29 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookItem/Edit.cshtml"
           Write(Html.EditorFor(model => model.State.StateName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1160, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1179, 118, false);
#line 30 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookItem/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.State.StateName, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1297, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
            BeginContext(1332, 138, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Update\" class=\"btn btn-default\" />\r\n            </div>\r\n");
            EndContext();
#line 36 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookItem/Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(1481, 87, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div>\r\n    <a href=\"/BookItem/Index\">Back to List</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignalR.Models.ViewModel.BookItemViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
