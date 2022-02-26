﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NookMainApp.Models
{
    public class Rentee : UserInfo
    {
        public Rentee()
        {
            this.Interests = new HashSet<Interest>();
        }

        public virtual ICollection<Interest> Interests { get; set; }
       
        public double Fee { get; set; }
    }
}
