using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NookApplication.Models
{
    public class Rentee : User
    {
        List<Interest> interests;
        double Fee { get; set; }
    }
}
