using System;

namespace ConsoleApp3
{
    /// <summary>
    /// This class inherits from the Vechicle class.
    /// This class does not have a specific parking coefficient.
    /// It uses the coefficient specified in the base class.
    /// </summary>
    public class CarSkoda : Vehicle
    {
        public string Name => "Skoda";
        
        public override void GetDescribtion()
        {
            Console.WriteLine($"This is Truck which is made by {Name}");
            base.GetDescribtion();
        }
        
    }
}