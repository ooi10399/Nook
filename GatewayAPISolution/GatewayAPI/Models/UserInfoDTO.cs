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
        public string UserId { get; set; }
        public string FullName { get; set; }
        public string NickName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DOB { get; set; }
        public string Gender { get; set; }
        public string? About { get; set; }
        public string Image { get; set; }

        bool value = false;
        public bool IsActive
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }
}
