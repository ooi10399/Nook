using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NookApplication.Models
{
    public class Rentee : User
    {
        public Rentee()
        {
            this.Interests = new HashSet<Interest>();
        }

        public virtual ICollection<Interest> Interests { get; set; }
        public double Fee { get; set; }
    }
}
