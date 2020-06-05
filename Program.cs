using System;
using System.Collections.Generic;

// namespace Garage
// {
//     class Program
//     {
//         static void Main(string[] args)
// {
// Cessna plane = new Cessna()
// {
//     MainColor = "blue",
//     MaximumOccupancy = "6",
//     FuelCapacity = 20.0
// };
// Ram truck = new Ram()
// {
//     MainColor = "red",
//     MaximumOccupancy = "20",
//     FuelCapacity = 20.0
// };
// Tesla car = new Tesla()
// {
//     MainColor = "black",
//     MaximumOccupancy = "20",
//     BatteryKWh = 20.0
// };
// Zero motorcycle = new Zero()
// {
//     MainColor = "black",
//     MaximumOccupancy = "20",
//     BatteryKWh = 20.0
// };
// truck.Drive();
// truck.Turn("left");
// truck.Stop();

// Console.WriteLine("");

// plane.Drive();
// plane.Turn("right");
// plane.Stop();

// Console.WriteLine("");

// car.Drive();
// car.Turn("left");
// car.Stop();

// Console.WriteLine("");

// motorcycle.Drive();
// motorcycle.Turn("right");
// motorcycle.Stop();

// List<Ram> trucks = new List<Ram>();
// trucks.Add(truck);

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {

            Zero fxs = new Zero();
            Zero fx = new Zero();
            Tesla modelS = new Tesla();

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                fx,
                fxs,
                modelS
            };

            Console.WriteLine("Electric Vehicles");
            foreach (EV ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            foreach (EV ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (EV ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
            }

            /***********************************************/

            Ram ram = new Ram();
            Cessna cessna150 = new Cessna();

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                ram,
                cessna150
            };

            Console.WriteLine("Gas Vehicles");
            foreach (GV gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }

            foreach (GV gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (GV gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage}");
            }
        }
    }
}
// }
// }
// }