using System;

namespace Garage
{
    public class Vehicle
    {
        public string MainColor { get; set; }
        public string MaximumOccupancy { get; set; }

        //virtual gives other modules right to use this method
        public virtual void Drive()
        {
            Console.WriteLine("The vehicle drives by!!");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle turns a random {direction}!");
        }
        public virtual void Stop()
        {
            Console.WriteLine("The vehicle stops.");
        }
    }
}