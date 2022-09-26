using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    internal class TempConverter
    {
        public static double FtoC(double f)
        {
            return (f-32) * 5 / 9;
        }

        public static double CtoF(double c)
        {
            return (c * 9 / 5) - 32;
        }


    }
}
