#pragma checksum "C:\Users\johan\GitLocalRepos\Nook\NookMainSolution\NookMainApp\Views\Rentee\GetAllRentees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f9fc3047d95f3b565083c93673048039567b37f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rentee_GetAllRentees), @"mvc.1.0.view", @"/Views/Rentee/GetAllRentees.cshtml")]
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
#nullable restore
#line 1 "C:\Users\johan\GitLocalRepos\Nook\NookMainSolution\NookMainApp\Views\_ViewImports.cshtml"
using NookMainApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\johan\GitLocalRepos\Nook\NookMainSolution\NookMainApp\Views\_ViewImports.cshtml"
using NookMainApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9fc3047d95f3b565083c93673048039567b37f", @"/Views/Rentee/GetAllRentees.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c75c31fa8b4040dd849d9e53cb36c89d23d97a", @"/Views/_ViewImports.cshtml")]
    public class Views_Rentee_GetAllRentees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NookMainApp.Models.Rentee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\johan\GitLocalRepos\Nook\NookMainSolution\NookMainApp\Views\Rentee\GetAllRentees.cshtml"
  
    ViewData["Title"] = "Friend List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Meet your new friends!</h2>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 12 "C:\Users\johan\GitLocalRepos\Nook\NookMainSolution\NookMainApp\Views\Rentee\GetAllRentees.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card m-2\" style=\"width:300px\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 317, "\"", 364, 1);
#nullable restore
#line 15 "C:\Users\johan\GitLocalRepos\Nook\NookMainSolution\NookMainApp\Views\Rentee\GetAllRentees.cshtml"
WriteAttributeValue("", 323, Html.DisplayFor(modelItem => item.Image), 323, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image\" style=\"width:100%\">\r\n            <div class=\"card-body d-flex flex-column\">\r\n                <h4 class=\"card-title\">");
#nullable restore
#line 17 "C:\Users\johan\GitLocalRepos\Nook\NookMainSolution\NookMainApp\Views\Rentee\GetAllRentees.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p class=\"card-text\">");
#nullable restore
#line 18 "C:\Users\johan\GitLocalRepos\Nook\NookMainSolution\NookMainApp\Views\Rentee\GetAllRentees.cshtml"
                                Write(Html.DisplayFor(modelItem => item.About));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <p class=\"card-text\">\r\n                    ");
#nullable restore
#line 21 "C:\Users\johan\GitLocalRepos\Nook\NookMainSolution\NookMainApp\Views\Rentee\GetAllRentees.cshtml"
               Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 22 "C:\Users\johan\GitLocalRepos\Nook\NookMainSolution\NookMainApp\Views\Rentee\GetAllRentees.cshtml"
               Write(Html.DisplayFor(modelItem => item.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 844, "\"", 918, 1);
#nullable restore
#line 25 "C:\Users\johan\GitLocalRepos\Nook\NookMainSolution\NookMainApp\Views\Rentee\GetAllRentees.cshtml"
WriteAttributeValue("", 851, Url.Action("GetRenteeDetails", "Rentee", new { id = item.UserId }), 851, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info mt-auto\">Make appointment</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 28 "C:\Users\johan\GitLocalRepos\Nook\NookMainSolution\NookMainApp\Views\Rentee\GetAllRentees.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NookMainApp.Models.Rentee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
