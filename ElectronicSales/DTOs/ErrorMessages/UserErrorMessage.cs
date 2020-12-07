using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.DTOs.ErrorMessages
{
    class UserErrorMessage
    {
        public string Id { get; set; }

        public string FullName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string OldPassword { get; set; }

        public string NewPassword { get; set; }

        public string RoleName { get; set; }

        public string OtherMessage { get; set; }
    }
}
