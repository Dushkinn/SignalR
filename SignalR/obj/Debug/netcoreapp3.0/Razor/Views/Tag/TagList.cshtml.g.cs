#pragma checksum "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/Tag/TagList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4474892d1ad698e52f11e410261eed21fef67b21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tag_TagList), @"mvc.1.0.view", @"/Views/Tag/TagList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tag/TagList.cshtml", typeof(AspNetCore.Views_Tag_TagList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4474892d1ad698e52f11e410261eed21fef67b21", @"/Views/Tag/TagList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cda95d27bd1cd512491c238ac23dca4804fffe8", @"/Views/_ViewImports.cshtml")]
    public class Views_Tag_TagList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SignalR.Models.ViewModel.TagsListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/Tag/TagList.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(105, 268, true);
            WriteLiteral(@"
 

<table class=""table mt-4"">
    <thead>
        <tr>
            <th>
                Name
            </th>
            <th>
                Discription
            </th>
            <th>

            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 25 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/Tag/TagList.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#line 27 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/Tag/TagList.cshtml"
             foreach (var item in Model.TagsList)
            {

#line default
#line hidden
            BeginContext(479, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(552, 39, false);
#line 31 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/Tag/TagList.cshtml"
                   Write(Html.DisplayFor(modelitem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(591, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(671, 46, false);
#line 34 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/Tag/TagList.cshtml"
                   Write(Html.DisplayFor(modelitem => item.Discription));

#line default
#line hidden
            EndContext();
            BeginContext(717, 81, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 798, "\"", 822, 2);
            WriteAttributeValue("", 805, "Tag/edit/", 805, 9, true);
#line 37 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/Tag/TagList.cshtml"
WriteAttributeValue("", 814, item.ID, 814, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(823, 39, true);
            WriteLiteral(">edit</a> |\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 862, "\"", 888, 2);
            WriteAttributeValue("", 869, "Tag/delete/", 869, 11, true);
#line 38 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/Tag/TagList.cshtml"
WriteAttributeValue("", 880, item.ID, 880, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(889, 63, true);
            WriteLiteral(">delete</a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 41 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/Tag/TagList.cshtml"
            }

#line default
#line hidden
#line 41 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/Tag/TagList.cshtml"
             

        }
        else
        {


#line default
#line hidden
            BeginContext(1007, 40, true);
            WriteLiteral("            <h1>The list is empty</h1>\r\n");
            EndContext();
#line 48 "/Users/nikitadushkin/Projects/SignalR/SignalR/Views/Tag/TagList.cshtml"
        }

#line default
#line hidden
            BeginContext(1058, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SignalR.Models.ViewModel.TagsListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
