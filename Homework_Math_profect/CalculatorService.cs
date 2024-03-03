using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Math_profect
{
    internal class CalculatorService
    {
        public double Calculate(double num1, double num2, char op)
        {
            double result = 0.0;

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero!");
                    }
                    break;
                default:
                    Console.WriteLine("Error: Invalid operator!");
                    break;
            }

            return result;
        }
    }
}
