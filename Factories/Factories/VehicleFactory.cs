using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factories
{
    internal class VehicleFactory
    {


        public IVehicle MakeVehicle(string userInput, string color, bool isDriveable)
        {
            switch (userInput.ToLower())
            {
                case "4 wheels":
                    return new Car() { Color = color, IsDriveable = isDriveable};
                case "2 wheels":
                    return new Motorcycle() { Color = color, IsDriveable = isDriveable };
                case "18 wheels":
                    return new Semi() { Color = color, IsDriveable = isDriveable };
                default:
                    return new Car() { Color = color, IsDriveable = isDriveable };
            }
        }


}
}
