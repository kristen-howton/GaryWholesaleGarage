using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle // Electric car
    {
        public double BatteryKWh { get; set; }
        public double CurrentChargePercentage
        {
            get
            {
                return (_currentBatteryLevel / BatteryKWh) * 100;
            }
        }
        private double _currentBatteryLevel = 0;

        public void ChargeBattery()
        {
            _currentBatteryLevel = BatteryKWh;
        }
        public override void Drive()

        {
            Console.WriteLine($"The {MainColor} tesla blazes by you.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The tesla squelas around a {direction} turn.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} tesla silently stops as if it never moved.");
        }
    }
}