using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.DTOs.ErrorMessages
{
    class ComboErrorMessage
    {
        public string Id { get; set; }

        public string ComboName { get; set; }

        public string OriginalPrice { get; set; }

        public string DiscountPercent { get; set; }

        public string Price { get; set; }

        public string OtherMessage { get; set; }
    }
}
