using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_extantion_array
{
    internal static class EmailVerificataion
    {
        public static bool ContainsAtSymbol(this string str)
        {
            return str.Contains("@");
        }

      
        public static bool IsPasswordLengthValid(this string password)
        {
            return password.Length > 8;
        }




    }
}
