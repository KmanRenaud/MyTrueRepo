using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewaer
{

    public static class Kata
    {
        public static bool IsTwinPrime(int n)
        {
            int a = 0;
            for (int i = n; i > 1; i--)
            {
                if (n % i != 0 && (n + 2) % (i + 2) != 0 && (n - 2) % (i - 2) != 0)
                {
                    a += 1;
                }
            }
            if (a == n)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
