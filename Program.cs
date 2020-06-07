using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {

            Tesla car = new Tesla()
            {
                MainColor = "black",
                MaximumOccupancy = "20",
                BatteryKWh = 10.0
            };
            Zero motorcycle = new Zero()
            {
                MainColor = "black",
                MaximumOccupancy = "20",
                BatteryKWh = 15.0
            };

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                motorcycle,
                car

            };

            Console.WriteLine("Electric Vehicles");
            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage:N2}");
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                // This should charge the vehicle to 100%
                ev.ChargeBattery();
            }

            foreach (IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage:N2}");
            }

            /***********************************************/

            Cessna plane = new Cessna()
            {
                MainColor = "blue",
                MaximumOccupancy = "6",
                FuelCapacity = 30.0
            };
            Ram truck = new Ram()
            {
                MainColor = "red",
                MaximumOccupancy = "20",
                FuelCapacity = 20.0
            };

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                truck,
                plane
            };

            Console.WriteLine("Gas Vehicles");
            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage:N2}");
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                // This should completely refuel the gas tank
                gv.RefuelTank();
            }

            foreach (IGasVehicle gv in gasVehicles)
            {
                Console.WriteLine($"{gv.CurrentTankPercentage:N2}");
            }
        }
    }
}