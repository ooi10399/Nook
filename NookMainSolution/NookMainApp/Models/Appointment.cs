using NookMainApp.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NookMainApp.Models
{
    public class Appointment
    {
        [Display(Name ="Id")]
        public int AppointmentId { get; set; }
        [Display(Name = "Rentee")]
        public string RenteeUserName { get; set; }
        [Display(Name = "Renter")]
        public string RenterUserName { get; set; }
        [Display(Name = "Start")]
        public DateTime StartDateTime { get; set; }
        [Display(Name = "End")]
        public DateTime EndDateTime { get; set; }
        [Display(Name = "Hourly Rate")]
        public double Fees { get; set; }
        public string Remark { get; set; }
        public DateTime PlacementDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public AppointmentStatus Status { get; set; }
    }
}
