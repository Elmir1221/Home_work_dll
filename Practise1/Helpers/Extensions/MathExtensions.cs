using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise1.helpers.Extensions
{
    internal static class MathExtensions
    {
        public static int SumOfNumbs(this int num1, int num2)
        {


            return num1+num2;
        }

        //public static double SquareOfNumbs(this int a)
        //{
        //    return Math.Pow(a, 2);
        //}

        public static double PowerOfNumbs(this int a, int pow)
        {
            return Math.Pow(a, pow);
        }

    }

}
