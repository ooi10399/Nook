#pragma checksum "C:\Users\Ooi\Desktop\Nook Edit\NookMainSolution\NookMainApp\Views\Renter\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5bdda15d68250a7db67341ddebea21627c7124f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Renter_Index), @"mvc.1.0.view", @"/Views/Renter/Index.cshtml")]
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
#line 1 "C:\Users\Ooi\Desktop\Nook Edit\NookMainSolution\NookMainApp\Views\_ViewImports.cshtml"
using NookMainApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ooi\Desktop\Nook Edit\NookMainSolution\NookMainApp\Views\_ViewImports.cshtml"
using NookMainApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5bdda15d68250a7db67341ddebea21627c7124f", @"/Views/Renter/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c75c31fa8b4040dd849d9e53cb36c89d23d97a", @"/Views/_ViewImports.cshtml")]
    public class Views_Renter_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NookMainApp.Models.Renter>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info mt-auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ooi\Desktop\Nook Edit\NookMainSolution\NookMainApp\Views\Renter\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Your friends at Nook..</h2>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\Ooi\Desktop\Nook Edit\NookMainSolution\NookMainApp\Views\Renter\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card m-2\" style=\"width:300px\">\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 276, "\"", 323, 1);
#nullable restore
#line 13 "C:\Users\Ooi\Desktop\Nook Edit\NookMainSolution\NookMainApp\Views\Renter\Index.cshtml"
WriteAttributeValue("", 282, Html.DisplayFor(modelItem => item.Image), 282, 41, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image\" style=\"width:100%\">\r\n            <div class=\"card-body d-flex flex-column\">\r\n                <h4 class=\"card-title\">");
#nullable restore
#line 15 "C:\Users\Ooi\Desktop\Nook Edit\NookMainSolution\NookMainApp\Views\Renter\Index.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                <p class=\"card-text\">");
#nullable restore
#line 16 "C:\Users\Ooi\Desktop\Nook Edit\NookMainSolution\NookMainApp\Views\Renter\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => item.About));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                <p class=\"card-text\">\r\n                    ");
#nullable restore
#line 19 "C:\Users\Ooi\Desktop\Nook Edit\NookMainSolution\NookMainApp\Views\Renter\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 20 "C:\Users\Ooi\Desktop\Nook Edit\NookMainSolution\NookMainApp\Views\Renter\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5bdda15d68250a7db67341ddebea21627c7124f6244", async() => {
                WriteLiteral("View details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 26 "C:\Users\Ooi\Desktop\Nook Edit\NookMainSolution\NookMainApp\Views\Renter\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NookMainApp.Models.Renter>> Html { get; private set; }
    }
}
#pragma warning restore 1591
