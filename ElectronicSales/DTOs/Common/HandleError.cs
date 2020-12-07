using ElectronicSales.DTOs.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicSales.DTOs.Common
{
    static class HandleError<M>
    {
        public static string GetErrorString( M messages)
        {
            string t = "";
            foreach (PropertyInfo propertyInfo in messages.GetType().GetProperties())
            {
                if (propertyInfo.GetValue(messages, null) != null)
                {
                    t += propertyInfo.GetValue(messages, null) + "\n";
                }
            }
            return t;
        }
    }
}
