#pragma checksum "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Rentee\GetRenteeDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43a49d1af446fef0f3290eccd06d41a124b244ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rentee_GetRenteeDetails), @"mvc.1.0.view", @"/Views/Rentee/GetRenteeDetails.cshtml")]
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
#line 1 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\_ViewImports.cshtml"
using NookMainApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\_ViewImports.cshtml"
using NookMainApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43a49d1af446fef0f3290eccd06d41a124b244ad", @"/Views/Rentee/GetRenteeDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c75c31fa8b4040dd849d9e53cb36c89d23d97a", @"/Views/_ViewImports.cshtml")]
    public class Views_Rentee_GetRenteeDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NookMainApp.Models.Rentee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetAllRentees", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Rentee\GetRenteeDetails.cshtml"
  
    ViewData["Title"] = "Friend Info";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Some info about your friend..</h2>\r\n\r\n<hr />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 231, "\"", 275, 1);
#nullable restore
#line 15 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Rentee\GetRenteeDetails.cshtml"
WriteAttributeValue("", 237, Html.DisplayFor(model => model.Image), 237, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"profile image\" width=\"200\" style=\"object-fit: cover; object-position: left;\">\r\n    </div>\r\n\r\n    <div class=\"col-md-8\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 21 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Rentee\GetRenteeDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 24 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Rentee\GetRenteeDetails.cshtml"
           Write(Html.DisplayFor(model => model.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 27 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Rentee\GetRenteeDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 30 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Rentee\GetRenteeDetails.cshtml"
           Write(Html.DisplayFor(model => model.DOB));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 33 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Rentee\GetRenteeDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 36 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Rentee\GetRenteeDetails.cshtml"
           Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 39 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Rentee\GetRenteeDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.About));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 42 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Rentee\GetRenteeDetails.cshtml"
           Write(Html.DisplayFor(model => model.About));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 45 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Rentee\GetRenteeDetails.cshtml"
           Write(Html.DisplayNameFor(model => model.Fee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 48 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Rentee\GetRenteeDetails.cshtml"
           Write(Html.DisplayFor(model => model.Fee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n            <div>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1603, "\"", 1688, 1);
#nullable restore
#line 53 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Rentee\GetRenteeDetails.cshtml"
WriteAttributeValue("", 1610, Url.Action("CreateAppointment", "Appointment", new { UserId = Model.UserId }), 1610, 78, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Make appointment</a>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43a49d1af446fef0f3290eccd06d41a124b244ad10115", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n            </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NookMainApp.Models.Rentee> Html { get; private set; }
    }
}
#pragma warning restore 1591
