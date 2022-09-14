using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class OperatingClass
    {
        public static double Area(double r)
        {
            return Math.PI * Math.Pow(r, 2);

        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }
    }
}
