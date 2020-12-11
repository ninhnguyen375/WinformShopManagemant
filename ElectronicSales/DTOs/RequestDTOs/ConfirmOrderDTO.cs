using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.DTOs.RequestDTOs
{
    class ConfirmOrderDTO
    {
        public int EmployeeId { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
