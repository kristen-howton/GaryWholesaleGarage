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
            truck.Turn("left");
            truck.Stop();

            Console.WriteLine("");

            plane.Drive();
            plane.Turn("right");
            plane.Stop();

            Console.WriteLine("");

            car.Drive();
            car.Turn("left");
            car.Stop();

            Console.WriteLine("");

            motorcycle.Drive();
            motorcycle.Turn("right");
            motorcycle.Stop();

            List<Ram> trucks = new List<Ram>();
            trucks.Add(truck);
        }
    }
}