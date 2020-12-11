using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.DTOs.ErrorMessages
{
    class OrderErrorMessage
    {
        public string Id { get; set; }

        public string TotalPrice { get; set; }

        public string DeliveryAddress { get; set; }

        public string DeliveryDate { get; set; }

        public string EmployeeId { get; set; }

        public string CustomerId { get; set; }

        public string OtherMessage { get; set; }
    }
}
