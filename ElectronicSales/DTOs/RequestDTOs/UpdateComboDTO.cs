using ElectronicSales.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.DTOs.RequestDTOs
{
    class UpdateComboDTO : Combo
    {
        public new string OriginalPrice { get; set; }
        public new string Price { get; set; }
        public List<int> DeletedProductIds { get; set; }
        public List<int> InsertedProductIds { get; set; }
    }
}
