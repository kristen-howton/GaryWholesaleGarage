using System;

namespace Garage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public void ChargeBattery()
        {
            // method definition omitted
        }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} zero zips by you. Yeeeeeowwww!");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The zero carefully turns {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} zero gently rolls to a stop.");
        }
    }
}