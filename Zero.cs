using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage
        {
            get
            {
                return _currentBatteryLevel / BatteryKWh * 100;
            }
        }
        private double _currentBatteryLevel = 0;
        public void ChargeBattery()
        {
            _currentBatteryLevel = BatteryKWh;
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