using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.DTOs.ErrorMessages
{
    class ProductErrorMessage
    {
        public string Id { get; set; }

        public string ProductName { get; set; }

        public string InStock { get; set; }

        public string Price { get; set; }

        public string CatalogId { get; set; }

        public string OtherMessage { get; set; }
    }
}
