using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.Models
{
    class Combo
    {
        public int Id { get; set; }

        public string ComboName { get; set; }

        public int DiscountPercent { get; set; }

        public decimal OriginalPrice { get; set; }

        public decimal Price { get; set; }

        public string IdString { get; set; }

        public List<Product> products { get; set; }
    }
}
