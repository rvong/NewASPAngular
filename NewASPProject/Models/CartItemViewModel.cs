﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewASPProject.Models
{
    public class CartItemViewModel
    {
        public string PName { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }
    }
}