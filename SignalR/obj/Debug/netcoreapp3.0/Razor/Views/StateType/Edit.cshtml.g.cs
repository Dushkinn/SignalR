#pragma checksum "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5910a5ed3dc75bc11843cd7eeaa31788df812b53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StateType_Edit), @"mvc.1.0.view", @"/Views/StateType/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/StateType/Edit.cshtml", typeof(AspNetCore.Views_StateType_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5910a5ed3dc75bc11843cd7eeaa31788df812b53", @"/Views/StateType/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cda95d27bd1cd512491c238ac23dca4804fffe8", @"/Views/_ViewImports.cshtml")]
    public class Views_StateType_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignalR.Models.StateType>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(124, 91, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>Author</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
            EndContext();
#line 15 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Edit.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(274, 23, false);
#line 17 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(316, 89, false);
#line 20 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Edit.cshtml"
       Write(Html.ValidationSummary(true, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(420, 33, false);
#line 21 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Edit.cshtml"
       Write(Html.HiddenFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(455, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(510, 89, false);
#line 23 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Edit.cshtml"
           Write(Html.LabelFor(model => model.StateName, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(599, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(618, 98, false);
#line 24 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Edit.cshtml"
           Write(Html.EditorFor(model => model.StateName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(716, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(735, 112, false);
#line 25 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.StateName, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(847, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
            BeginContext(880, 138, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Update\" class=\"btn btn-default\" />\r\n            </div>\r\n");
            EndContext();
#line 31 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/StateType/Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(1029, 88, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div>\r\n    <a href=\"/StateType/Index\">Back to List</a>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignalR.Models.StateType> Html { get; private set; }
    }
}
#pragma warning restore 1591
