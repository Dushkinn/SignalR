#pragma checksum "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "695c152175f34434d95cee88ca328bf5af9e655d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Create), @"mvc.1.0.view", @"/Views/User/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Create.cshtml", typeof(AspNetCore.Views_User_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"695c152175f34434d95cee88ca328bf5af9e655d", @"/Views/User/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6782bfbfb275a1da52ab16110f509f98b863209f", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignalR.Models.ViewModel.UserViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(51, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 6 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(144, 133, true);
            WriteLiteral("\r\n<h2>Create</h2>\r\n\r\n<h4>Book</h4>\r\n<hr />\r\n\r\n\r\n<div class=\"form-group\">\r\n\r\n\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
            EndContext();
#line 23 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(336, 23, false);
#line 25 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(378, 89, false);
#line 28 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
       Write(Html.ValidationSummary(true, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(482, 33, false);
#line 29 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
       Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(517, 54, true);
            WriteLiteral("            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(572, 88, false);
#line 31 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
           Write(Html.LabelFor(model => model.FullName, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(660, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(679, 97, false);
#line 32 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
           Write(Html.EditorFor(model => model.FullName, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(776, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(795, 111, false);
#line 33 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.FullName, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(906, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(983, 88, false);
#line 36 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
           Write(Html.LabelFor(model => model.Password, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1071, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1090, 97, false);
#line 37 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
           Write(Html.EditorFor(model => model.Password, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1187, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1206, 111, false);
#line 38 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Password, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1317, 76, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1394, 92, false);
#line 41 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
           Write(Html.LabelFor(model => model.selectedRole, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(1486, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1505, 65, false);
#line 42 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
           Write(Html.DropDownList("selectedRole", (MultiSelectList)ViewBag.Roles));

#line default
#line hidden
            EndContext();
            BeginContext(1570, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1589, 115, false);
#line 43 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.selectedRole, "", new { htmlAttributes = new { @class = "text-danger" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1704, 160, true);
            WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n            </div>\r\n");
            EndContext();
#line 48 "C:\Users\duski\source\repos\SignalR\SignalR\Views\User\Create.cshtml"
        }

#line default
#line hidden
            BeginContext(1875, 39, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignalR.Models.ViewModel.UserViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
