using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace codewaer
{

    public class Kata
    {
        public static bool Check(object[] a, object x)
        {

            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a.Contains(x))
                {
                    return true;
                }
            }
            return false;

        }
    }
}
