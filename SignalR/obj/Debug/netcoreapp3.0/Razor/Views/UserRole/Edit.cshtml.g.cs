#pragma checksum "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "067f579902ce2f32e12012ab3f11912bf068cab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRole_Edit), @"mvc.1.0.view", @"/Views/UserRole/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserRole/Edit.cshtml", typeof(AspNetCore.Views_UserRole_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"067f579902ce2f32e12012ab3f11912bf068cab6", @"/Views/UserRole/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfffc8099bda8c783b0cdbe95ce2a59f497502d5", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRole_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignalR.Models.UserRole>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(123, 94, true);
            WriteLiteral("\r\n<h2>Edit</h2>\r\n\r\n<h4>User Role</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
            EndContext();
#line 15 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Edit.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(276, 23, false);
#line 17 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(318, 89, false);
#line 20 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Edit.cshtml"
       Write(Html.ValidationSummary(true, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(422, 35, false);
#line 21 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Edit.cshtml"
       Write(Html.HiddenFor(model => model.Role));

#line default
#line hidden
            EndContext();
            BeginContext(459, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(514, 84, false);
#line 23 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Edit.cshtml"
           Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(598, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(617, 93, false);
#line 24 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Edit.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(710, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(729, 107, false);
#line 25 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(836, 22, true);
            WriteLiteral("\r\n            </div>\r\n");
            EndContext();
            BeginContext(872, 138, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Update\" class=\"btn btn-default\" />\r\n            </div>\r\n");
            EndContext();
#line 31 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(1021, 33, true);
            WriteLiteral("    </div>\r\n</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1054, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "067f579902ce2f32e12012ab3f11912bf068cab66997", async() => {
                BeginContext(1076, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1092, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignalR.Models.UserRole> Html { get; private set; }
    }
}
#pragma warning restore 1591
