using System;
using System.Collections.Generic;


namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            var procesor = new VehicleProcessor();
            var car1 = new TruckBmw {Length = 2.7, Width = 4.5, Weight = 1254};
            var truckParkingsquare = procesor.GetParkingSquare(car1);
            
            car1.GetDescribtion();
            Console.WriteLine($"Parking square for truck is {truckParkingsquare} ");

            List<Vehicle> items = new List<Vehicle>
            {
                new TruckBmw {Length = 2.56, Width = 1.98, Weight = 2543},
                new BusMersedes{Length = 4.21, Width = 1.78, Weight = 3632},
                new CarSkoda {Length = 2.05, Width = 1.7, Weight = 2543}
            };
            
            
            Console.WriteLine($"Parking square needed for build is {procesor.GetTotalParkingSquare(items)}");



        }
    }
}