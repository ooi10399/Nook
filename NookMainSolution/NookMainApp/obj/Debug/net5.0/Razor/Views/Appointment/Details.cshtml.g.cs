<<<<<<< HEAD
#pragma checksum "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "555207b21b9e318be2c44d7b64c6dd763eab551b"
=======
#pragma checksum "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f0eda9fc13fa791622104b7313cf9b5a3068a8e"
>>>>>>> 0b197130debfe7af23e58bfea3c024f2cddad58e
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_Details), @"mvc.1.0.view", @"/Views/Appointment/Details.cshtml")]
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
<<<<<<< HEAD
#line 1 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\_ViewImports.cshtml"
=======
#line 1 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\_ViewImports.cshtml"
>>>>>>> 0b197130debfe7af23e58bfea3c024f2cddad58e
using NookMainApp;

#line default
#line hidden
#nullable disable
#nullable restore
<<<<<<< HEAD
#line 2 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\_ViewImports.cshtml"
=======
#line 2 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\_ViewImports.cshtml"
>>>>>>> 0b197130debfe7af23e58bfea3c024f2cddad58e
using NookMainApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f0eda9fc13fa791622104b7313cf9b5a3068a8e", @"/Views/Appointment/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c75c31fa8b4040dd849d9e53cb36c89d23d97a", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NookMainApp.ViewModels.AppointmentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllAppointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<<<<<<< HEAD
#line 3 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
=======
#line 3 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
>>>>>>> 0b197130debfe7af23e58bfea3c024f2cddad58e
  
    ViewData["Title"] = "Appointment Details";

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>AppointmentViewModel</h4>\r\n    <hr />\r\n\r\n    <div>\r\n        <img");
            BeginWriteAttribute("src", " src=", 198, "", 235, 1);
#nullable restore
#line 14 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
WriteAttributeValue("", 203, Url.Content(Model.Rentee.Image), 203, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"No Image\" width=\"100\" />\r\n    </div>\r\n\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AppointmentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayFor(model => model.AppointmentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Rentee.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Rentee.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayFor(model => model.StartDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 37 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EndDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 40 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayFor(model => model.EndDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 43 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalFees));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 46 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayFor(model => model.TotalFees));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 49 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PlacementDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 52 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayFor(model => model.PlacementDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 55 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Remark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 58 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Remark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 61 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 64 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "555207b21b9e318be2c44d7b64c6dd763eab551b9595", async() => {
                WriteLiteral("Back to Appointment List");
=======
            WriteLiteral("\r\n<h2>Your appointment details..</h2>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f0eda9fc13fa791622104b7313cf9b5a3068a8e4154", async() => {
                WriteLiteral("Back");
>>>>>>> 0b197130debfe7af23e58bfea3c024f2cddad58e
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
            WriteLiteral("\r\n<hr />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 287, "\"", 325, 1);
#nullable restore
#line 13 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
WriteAttributeValue("", 293, Url.Content(Model.Rentee.Image), 293, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""profile image"" width=""200"" style=""object-fit: cover; object-position: left;"">
    </div>

    <div class=""col-md-8"">
        <dl class=""row"">
            <dt class=""col-sm-4"">
            </dt>
            <dd class=""col-sm-8"">
                ");
#nullable restore
#line 21 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.HiddenFor(model => model.AppointmentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 24 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Rentee.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 27 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.DisplayFor(model => model.Rentee.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 30 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 33 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.DisplayFor(model => model.StartDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 36 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.EndDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 39 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.DisplayFor(model => model.EndDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 42 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Fees));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 45 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.DisplayFor(model => model.Fees));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 48 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalFees));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 51 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.DisplayFor(model => model.TotalFees));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 54 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Remark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 57 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.DisplayFor(model => model.Remark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-4\">\r\n                ");
#nullable restore
#line 60 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-8\">\r\n                ");
#nullable restore
#line 63 "C:\Users\johan\source\repos\NookTemp\NookMainSolution\NookMainApp\Views\Appointment\Details.cshtml"
           Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f0eda9fc13fa791622104b7313cf9b5a3068a8e11442", async() => {
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NookMainApp.ViewModels.AppointmentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
