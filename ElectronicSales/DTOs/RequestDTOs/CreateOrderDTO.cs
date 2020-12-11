using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.DTOs.RequestDTOs
{
    class CreateOrderDTO
    {
        public decimal TotalPrice { get; set; }

        public string DeliveryAddress { get; set; }

        public int CustomerId { get; set; }

        public List<OrderDetailDTO> OrderDetails { get; set; }

        public class OrderDetailDTO
        {
            public int Amount { get; set; }

            public decimal TotalPrice { get; set; }

            public int? ProductId { get; set; }

            public int? ComboId { get; set; }
        }
    }
}
