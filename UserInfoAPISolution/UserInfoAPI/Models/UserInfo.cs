using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UserInfoAPI.Models
{
    public class DateAttribute : RangeAttribute
    {
        public DateAttribute()
          : base(typeof(DateTime), DateTime.Now.AddYears(-100).ToShortDateString(), DateTime.Now.AddYears(-18).ToShortDateString()) { }
    }

    public class UserInfo
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
        public string? Image { get; set; }

        //set all user as active
        bool value = true;
        public bool IsActive
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }
}
