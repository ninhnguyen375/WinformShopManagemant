﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.Models
{
    class ComboOfOrder : Combo
    {
        public int OrderDetailId { get; set; }

        public int Amount { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
