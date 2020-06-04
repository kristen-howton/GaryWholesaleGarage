using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            // method definition omitted
        }
        //override to allow to change
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} ram zips by you!");
        }
    }
}