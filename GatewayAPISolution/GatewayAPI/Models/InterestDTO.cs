using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GatewayAPI.Models
{
    public class InterestDTO
    {
        public InterestDTO()
        {
            this.Rentees = new HashSet<RenteeDTO>();
        }

        [Key]
        public int IntId { get; set; }
        public string IntName { get; set; }

        public virtual ICollection<RenteeDTO> Rentees { get; set; }
    }
}
