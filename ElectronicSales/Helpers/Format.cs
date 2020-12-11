using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.Helpers
{
    class Format
    {
        public static string getDisplayString(object obj, string fieldName)
        {
            var value = obj.GetType().GetProperty(fieldName).GetValue(obj, null);

            if (obj == null || value == null)
            {
                return "---";
            }

            if(value.GetType().ToString().Contains("Decimal"))
            {
                decimal d = (decimal)value;
                return d.ToString("N");
            }

            return value.ToString();
        }
    }
}
