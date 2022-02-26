using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NookAppointmentAPI.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public string RenteeUserName { get; set; }
        public string RenterUserName { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public double Fees { get; set; }
        public string Remark { get; set; }
        public DateTime PlacementDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public string Status { get; set; }

    }
}
