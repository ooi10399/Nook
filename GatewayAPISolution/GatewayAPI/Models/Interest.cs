using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GatewayAPI.Models
{
    public class Interest
    {
        public Interest()
        {
            this.Rentees = new HashSet<Rentee>();
        }

        [Key]
        public int IntId { get; set; }
        public string IntName { get; set; }

        public virtual ICollection<Rentee> Rentees { get; set; }
    }
}
