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
            Console.WriteLine($"The {MainColor} ram growls by you. Rrrrrumbbble.");
        }
        public override void Turn()
        {
            Console.WriteLine($"The ram carefully turns right.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} ram gently rolls to a stop.");
        }
    }
}