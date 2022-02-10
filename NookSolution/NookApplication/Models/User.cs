using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NookApplication.Models
{
    public class User
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string NickName { get; set; }
        public DateTime DOB { get; set; }
        public bool Gender { get; set; }
        string Password { get; set; }
        public string About { get; set; }

    }
}
