#pragma checksum "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3eb9a1c996a0a2b4310365db221bd216afbf54b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_RenteeAppointmentDetails), @"mvc.1.0.view", @"/Views/Appointment/RenteeAppointmentDetails.cshtml")]
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
#line 1 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\_ViewImports.cshtml"
using NookMainApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\_ViewImports.cshtml"
using NookMainApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eb9a1c996a0a2b4310365db221bd216afbf54b6", @"/Views/Appointment/RenteeAppointmentDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c75c31fa8b4040dd849d9e53cb36c89d23d97a", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_RenteeAppointmentDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NookMainApp.ViewModels.AppointmentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllRenteeAppointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
  
    ViewData["Title"] = "RenteeAppointmentDetails";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>RenteeAppointmentDetails</h1>\r\n\r\n<div>\r\n    <h4>AppointmentViewModel</h4>\r\n    <hr />\r\n");
#nullable restore
#line 12 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
     if (Model.Renter != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=\"", 258, "\"", 296, 1);
#nullable restore
#line 14 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
WriteAttributeValue("", 264, Url.Content(Model.Renter.Image), 264, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"No Image\" style=\"width:100%\" />\r\n");
#nullable restore
#line 15 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Renter.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
       Write(Html.DisplayFor(model => model.Renter.NickName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.StartDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
       Write(Html.DisplayFor(model => model.StartDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.EndDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
       Write(Html.DisplayFor(model => model.EndDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalFees));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
       Write(Html.DisplayFor(model => model.TotalFees));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Remark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
       Write(Html.DisplayFor(model => model.Remark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.PlacementDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
       Write(Html.DisplayFor(model => model.PlacementDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Ooi\Desktop\Nook\NookMainSolution\NookMainApp\Views\Appointment\RenteeAppointmentDetails.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eb9a1c996a0a2b4310365db221bd216afbf54b69783", async() => {
                WriteLiteral("Back to Appointments");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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