using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GatewayAPI.Models
{
    public class RenteeDTO : UserInfoDTO
    {
        public RenteeDTO()
        {
            this.Interests = new HashSet<InterestDTO>();
        }

        public virtual ICollection<InterestDTO> Interests { get; set; }
        public double Fee { get; set; }
    }
}
