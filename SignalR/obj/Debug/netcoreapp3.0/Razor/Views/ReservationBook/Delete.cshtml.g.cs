#pragma checksum "C:\Users\duski\source\repos\SignalR\SignalR\Views\ReservationBook\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88be1f512afe8eacb149534fc7b031e6468b62c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReservationBook_Delete), @"mvc.1.0.view", @"/Views/ReservationBook/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ReservationBook/Delete.cshtml", typeof(AspNetCore.Views_ReservationBook_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88be1f512afe8eacb149534fc7b031e6468b62c8", @"/Views/ReservationBook/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6782bfbfb275a1da52ab16110f509f98b863209f", @"/Views/_ViewImports.cshtml")]
    public class Views_ReservationBook_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignalR.Models.ReservationBook>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\duski\source\repos\SignalR\SignalR\Views\ReservationBook\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(132, 169, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Language</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(302, 38, false);
#line 17 "C:\Users\duski\source\repos\SignalR\SignalR\Views\ReservationBook\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(340, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(384, 34, false);
#line 20 "C:\Users\duski\source\repos\SignalR\SignalR\Views\ReservationBook\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(418, 30, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n");
            EndContext();
#line 24 "C:\Users\duski\source\repos\SignalR\SignalR\Views\ReservationBook\Delete.cshtml"
     using (Html.BeginForm("DeleteReservationBook" , "ReservationBook"))
    {
        

#line default
#line hidden
            BeginContext(538, 23, false);
#line 26 "C:\Users\duski\source\repos\SignalR\SignalR\Views\ReservationBook\Delete.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(574, 33, false);
#line 28 "C:\Users\duski\source\repos\SignalR\SignalR\Views\ReservationBook\Delete.cshtml"
   Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
            EndContext();
            BeginContext(617, 73, true);
            WriteLiteral("        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> \r\n");
            EndContext();
#line 31 "C:\Users\duski\source\repos\SignalR\SignalR\Views\ReservationBook\Delete.cshtml"
    }

#line default
#line hidden
            BeginContext(697, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignalR.Models.ReservationBook> Html { get; private set; }
    }
}
#pragma warning restore 1591
