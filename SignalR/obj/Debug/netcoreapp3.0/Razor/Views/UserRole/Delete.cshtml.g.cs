#pragma checksum "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da834ba86c4175d37789aa57e73cd85d92e2f920"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserRole_Delete), @"mvc.1.0.view", @"/Views/UserRole/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserRole/Delete.cshtml", typeof(AspNetCore.Views_UserRole_Delete))]
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
#line 1 "C:\Users\duski\source\repos\SignalR\SignalR\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\duski\source\repos\SignalR\SignalR\Views\_ViewImports.cshtml"
using IdentityDemo;

#line default
#line hidden
#line 3 "C:\Users\duski\source\repos\SignalR\SignalR\Views\_ViewImports.cshtml"
using IdentityDemo.Models;

#line default
#line hidden
#line 4 "C:\Users\duski\source\repos\SignalR\SignalR\Views\_ViewImports.cshtml"
using IdentityDemo.Models.AccountViewModels;

#line default
#line hidden
#line 5 "C:\Users\duski\source\repos\SignalR\SignalR\Views\_ViewImports.cshtml"
using IdentityDemo.Models.ManageViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da834ba86c4175d37789aa57e73cd85d92e2f920", @"/Views/UserRole/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6782bfbfb275a1da52ab16110f509f98b863209f", @"/Views/_ViewImports.cshtml")]
    public class Views_UserRole_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignalR.Models.UserRole>
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
#line 4 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(125, 170, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>User Role</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(296, 40, false);
#line 17 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(336, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(380, 36, false);
#line 20 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(416, 30, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n");
            EndContext();
#line 24 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Delete.cshtml"
     using (Html.BeginForm("DeleteUserRole" , "UserRole"))
    {
        

#line default
#line hidden
            BeginContext(522, 23, false);
#line 26 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(558, 35, false);
#line 28 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Delete.cshtml"
   Write(Html.HiddenFor(model => model.Role));

#line default
#line hidden
            EndContext();
            BeginContext(603, 85, true);
            WriteLiteral("        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> \r\n            ");
            EndContext();
            BeginContext(688, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "da834ba86c4175d37789aa57e73cd85d92e2f9206161", async() => {
                BeginContext(710, 12, true);
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
            BeginContext(726, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\duski\source\repos\SignalR\SignalR\Views\UserRole\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(735, 8, true);
            WriteLiteral("</div>\r\n");
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
