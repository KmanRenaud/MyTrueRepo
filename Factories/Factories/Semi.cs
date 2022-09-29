using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
    internal class Semi : IVehicle
    {

        public string Color { get; set; }
        public bool IsDriveable { get; set; }

        public void Drive()
        {
            if (IsDriveable == true)
            {
                Console.WriteLine($"Sorry I cant talk right now, im driving my {Color} semi truck.");
            }
            else
            {
                Console.WriteLine($"Sorry I cant talk right now, im fixing my {Color} semi truck.");
            }
        }

    }
}
