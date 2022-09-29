



using Factories;

Console.WriteLine("What type of vehicle do you want? (4 wheels = car | 2 wheels = motorcycle | 18 wheels = Semi)");
string userinput = Console.ReadLine();

Console.WriteLine("What color of vehicle do you want?");
string userinputColor = Console.ReadLine();

Console.WriteLine("Do you want your vehicle to be driveable? (True or False)");
bool userinputDriveable = Convert.ToBoolean(Console.ReadLine());


VehicleFactory setter = new VehicleFactory();
IVehicle vehicle = setter.MakeVehicle(userinput, userinputColor.ToLower(), userinputDriveable);

vehicle.Drive();