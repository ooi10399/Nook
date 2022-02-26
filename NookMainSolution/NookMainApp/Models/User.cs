using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NookMainApp.Models
{
    public class User
    {
        [Required(ErrorMessage = "Email cannot be empty")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [DisplayName("Email Address (Username)")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }
        public string Token { get; set; }
        [DisplayName("Account Type")]
        [Required(ErrorMessage = "Account type cannot be empty")]
        public string UserType { get; set; }
        [Display(Name = "Image URL")]
        public string Image { get; set; }
    }
}
