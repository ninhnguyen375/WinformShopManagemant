using ElectronicSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.DTOs.RequestDTOs
{
    class CreateComboDTO : Combo
    {
        public new string OriginalPrice { get; set; }
        public new string Price { get; set; }
        public List<int> ProductIds { get; set; }
    }
}
