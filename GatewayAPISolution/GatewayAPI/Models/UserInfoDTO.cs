using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GatewayAPI.Models
{
    public class UserInfoDTO
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Email cannot be empty")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Fullname cannot be empty")]
        [System.ComponentModel.DisplayName("Full Name")]
        public string FullName { get; set; }
        [DisplayName("Nickname")]
        public string NickName { get; set; }
        [Required(ErrorMessage = "Date of birth cannot be empty")]
        [DisplayName("Birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //[DateAttribute(ErrorMessage = "You have to be at least 18 years old")]
        public DateTime DOB { get; set; }
        [Required(ErrorMessage = "Gender cannot be empty")]
        public string Gender { get; set; }
        public string? About { get; set; }

        bool value = false;
        public bool IsActive
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }
}
