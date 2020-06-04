using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna plane = new Cessna()
            {
                MainColor = "blue",
                MaximumOccupancy = "6",
                FuelCapacity = 20.0
            };
            Ram truck = new Ram()
            {
                MainColor = "red",
                MaximumOccupancy = "20",
                FuelCapacity = 20.0
            };
            Tesla car = new Tesla()
            {
                MainColor = "black",
                MaximumOccupancy = "20",
                BatteryKWh = 20.0
            };
            Zero motorcycle = new Zero()
            {
                MainColor = "black",
                MaximumOccupancy = "20",
                BatteryKWh = 20.0
            };
            truck.Drive();
            plane.Drive();
            car.Drive();
            motorcycle.Drive();

            List<Ram> trucks = new List<Ram>();
            trucks.Add(truck);
        }
    }
}