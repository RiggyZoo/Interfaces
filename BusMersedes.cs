using System;

namespace ConsoleApp3
{
    public class BusMersedes : Vehicle
    {
        /// <summary>
        /// This class inherits from the Vechicle class.
        /// This class has a specific parking coefficient. It is already given, do not change it.
        /// </summary>
        public string Name => "Mersedes";
        
        
        // Parking coefficient is a private properties because it cannot be change from outside. 
        private double ParkingСoef => 1.46;
        
        public override void GetDescribtion()
        {
            Console.WriteLine($"This is Truck which is made by {Name}");
            base.GetDescribtion();
        }

        public override double GetParkingСoef()
        {
            return ParkingСoef;
        }

       
    }
}