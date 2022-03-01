using NookMainApp.Constant;
using NookMainApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NookMainApp.ViewModels
{
    public class AppointmentViewModel
    {
        public int AppointmentId { get; set; }
        public string RenteeUserName { get; set; }
        public Rentee Rentee { get; set; }
        public string RenterUserName { get; set; }
        public Renter Renter { get; set; }
        [Display(Name = "Start At")]
        public DateTime StartDateTime { get; set; }
        [Display(Name = "End At")]
        public DateTime EndDateTime { get; set; }
        [Display(Name = "Hourly Fees (SG$)")]
        public double Fees { get; set; }
        [Display(Name = "Total Fees (SG$)")]
        public double TotalFees { get; set; }
        public string Remark { get; set; }
        public DateTime PlacementDate { get; set; }
        public DateTime UpdateDate { get; set; }
        [Required(ErrorMessage = "select one item")]
        public AppointmentStatus Status { get; set; }
    }
}
