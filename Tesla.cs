using System;

namespace Garage
{
    public class Tesla : Vehicle // Electric car
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()

        {
            Console.WriteLine($"The {MainColor} tesla blazes by you.");
        }
        public override void Turn()
        {
            Console.WriteLine($"The tesla squelas around a right turn.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} tesla silently stops as if it never moved.");
        }
    }
}
