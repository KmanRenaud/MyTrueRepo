using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadDaMethod
{
    internal class Methods
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(decimal num1, decimal num2, bool isDollar)
        {
            if (num1 + num2 < 1 && num1 + num2 > -1 && num1 + num2 != 0)
            {
                decimal n = num1 + num2;
                return $"{n} cents";
            }
            if (num1 + num2 == 1 || num1 + num2 == -1)
            {
                isDollar = true;
            }
            else
            {
                isDollar = false;
            }
            if (isDollar == true)
            {
                return $"{num1 + num2} dollar";
            }
            else
            {
                return $"{num1 + num2} dollars";
            }
        }
    }
}
