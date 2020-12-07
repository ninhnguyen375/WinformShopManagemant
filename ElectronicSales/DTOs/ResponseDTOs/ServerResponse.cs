using ElectronicSales.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.DTOs.ResponseDTOs
{
    class ServerResponse<D, M>
    {
        public D Data { get; set; }

        public bool IsSuccess { get; set; }

        public M Messages { get; set; }

        public Pagination Pagination { get; set; }
    }
}
