#pragma checksum "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88c69accc9dd9691846fd01a941ebf2015996ea7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointment_AllAppointment), @"mvc.1.0.view", @"/Views/Appointment/AllAppointment.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88c69accc9dd9691846fd01a941ebf2015996ea7", @"/Views/Appointment/AllAppointment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0c75c31fa8b4040dd849d9e53cb36c89d23d97a", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointment_AllAppointment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NookMainApp.Models.Appointment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
  
    ViewData["Title"] = "My Appointments";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>My Appointments</h2>\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 137, "\"", 182, 1);
#nullable restore
#line 9 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
WriteAttributeValue("", 144, Url.Action("GetAllRentees", "Rentee"), 144, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Back</a>\r\n\r\n<hr />\r\n\r\n");
#nullable restore
#line 13 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div ip=\"viewbagMessage\">");
#nullable restore
#line 15 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                        Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 16 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table\r\n       id=\"table\"\r\n       data-toggle=\"table\"\r\n       data-search=\"true\">\r\n    <thead>\r\n        <tr>\r\n            <th data-sortable=\"true\">\r\n                ");
#nullable restore
#line 25 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
           Write(Html.DisplayNameFor(model => model.AppointmentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th data-sortable=\"true\">\r\n                ");
#nullable restore
#line 28 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
           Write(Html.DisplayNameFor(model => model.RenteeUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th data-sortable=\"true\">\r\n                ");
#nullable restore
#line 31 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th data-sortable=\"true\">\r\n                ");
#nullable restore
#line 34 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
           Write(Html.DisplayNameFor(model => model.EndDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th data-sortable=\"true\">\r\n                ");
#nullable restore
#line 37 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 50 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.AppointmentId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 53 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.RenteeUserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 56 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.StartDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 59 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                   Write(Html.DisplayFor(modelItem => item.EndDateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 62 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                         if (item.Status == NookMainApp.Constant.AppointmentStatus.Pending)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-warning\">");
#nullable restore
#line 64 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 65 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                         if (item.Status == NookMainApp.Constant.AppointmentStatus.Completed)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-secondary\">");
#nullable restore
#line 68 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                                                 Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 69 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                         if (item.Status == NookMainApp.Constant.AppointmentStatus.Confirm)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-success\">");
#nullable restore
#line 72 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                                               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 73 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                         if (item.Status == NookMainApp.Constant.AppointmentStatus.Cancel)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"text-danger\">");
#nullable restore
#line 76 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                                              Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 77 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n");
#nullable restore
#line 79 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                     if (item.Status == NookMainApp.Constant.AppointmentStatus.Pending)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 82 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                       Write(Html.ActionLink("Edit", "Edit", new { id = item.AppointmentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 83 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                       Write(Html.ActionLink("Details", "Details", new { id = item.AppointmentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 84 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                       Write(Html.ActionLink("Cancel", "Delete", new { id = item.AppointmentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 86 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                     if (item.Status == NookMainApp.Constant.AppointmentStatus.Confirm)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 90 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                       Write(Html.ActionLink("Details", "Details", new { id = item.AppointmentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                            ");
#nullable restore
#line 91 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                       Write(Html.ActionLink("Cancel", "Delete", new { id = item.AppointmentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 93 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                     if (item.Status == NookMainApp.Constant.AppointmentStatus.Completed || item.Status == NookMainApp.Constant.AppointmentStatus.Cancel)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 97 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                       Write(Html.ActionLink("Details", "Details", new { id = item.AppointmentId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n");
#nullable restore
#line 99 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </tr>\r\n");
#nullable restore
#line 103 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 103 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
             
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"8\">\r\n                    Sorry, there is no appointment at the moment.\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 112 "C:\Users\ACER\Documents\ahyun_workLife\Collabera\team2Assignment\NOOK to GitHub\28022022_v4_createApptFixed\NookMainSolution\NookMainApp\Views\Appointment\AllAppointment.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NookMainApp.Models.Appointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
