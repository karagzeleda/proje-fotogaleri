﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {

        [Key]
        public int AdminID { get; set; }

        [StringLength(50)]
        public string AdminAd { get; set; }
        public string AdminSifre { get; set; }



    }
}
