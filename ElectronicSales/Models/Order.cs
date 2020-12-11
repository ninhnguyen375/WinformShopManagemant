using System;
using System.Collections.Generic;

namespace ElectronicSales.Models
{
    class Order
    {
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public string DeliveryAddress { get; set; }

        public string Status { get; set; } // New, Accepted, Refused

        public int? EmployeeId { get; set; }

        public int CustomerId { get; set; }

        public string IdString { get; set; }

        public User Employee { get; set; }

        public User Customer { get; set; }

        public List<ProductOfOrder> Products { get; set; }

        public List<ComboOfOrder> Combos { get; set; }
    }
}