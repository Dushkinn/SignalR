#pragma checksum "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "82819e95a3e264885f7fe68899059b4eb315685d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookType_Create), @"mvc.1.0.view", @"/Views/BookType/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/BookType/Create.cshtml", typeof(AspNetCore.Views_BookType_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"82819e95a3e264885f7fe68899059b4eb315685d", @"/Views/BookType/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cda95d27bd1cd512491c238ac23dca4804fffe8", @"/Views/_ViewImports.cshtml")]
    public class Views_BookType_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignalR.Models.BookType>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(34, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(127, 137, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n<h4>BookType</h4>\r\n<hr />\r\n\r\n\r\n<div class=\"form-group\">\r\n\r\n\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
            EndContext();
#line 22 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Create.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(323, 23, false);
#line 24 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(365, 89, false);
#line 27 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Create.cshtml"
       Write(Html.ValidationSummary(true, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(469, 33, false);
#line 28 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Create.cshtml"
       Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(504, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(559, 91, false);
#line 30 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Create.cshtml"
           Write(Html.LabelFor(model => model.Discription, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(650, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(669, 100, false);
#line 31 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Create.cshtml"
           Write(Html.EditorFor(model => model.Discription, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(769, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(788, 114, false);
#line 32 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Discription, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(902, 168, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-outline-success\" />\r\n            </div>\r\n");
            EndContext();
#line 37 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/BookType/Create.cshtml"
        }

#line default
#line hidden
            BeginContext(1081, 39, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignalR.Models.BookType> Html { get; private set; }
    }
}
#pragma warning restore 1591
