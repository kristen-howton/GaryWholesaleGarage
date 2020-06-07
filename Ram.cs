using System;

namespace Garage
{
    public class Ram : Vehicle, IGasVehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }
        public double CurrentTankPercentage
        {
            get
            {
                return (_currentFuelLevel / FuelCapacity) * 100;
            }
        }
        private double _currentFuelLevel = 0;
        public void RefuelTank()
        {
            _currentFuelLevel = FuelCapacity;
        }
        //override to allow to change
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} ram growls by you. Rrrrrumbbble.");
        }
        public override void Turn(string direction)
        {
            Console.WriteLine($"The ram carefully turns {direction}.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} ram gently rolls to a stop.");
        }
    }
}