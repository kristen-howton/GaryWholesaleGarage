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
            Console.WriteLine($"The {MainColor} ZOOOOOM!!");
        }
        public virtual void Turn()
        {
            Console.WriteLine($"The {MainColor} turns right!!");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"The {MainColor} silently stops!!");
        }
    }
}