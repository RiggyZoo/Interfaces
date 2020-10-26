using System.Collections.Generic;

namespace ConsoleApp3
{
    public interface IVehicle
        {
            public double GetAllWeight(List<Vehicle> things);
           
            public double GetAllLength(List<Vehicle> things);
            public double GetParkingSquare(Vehicle item);

            public int GetParkingSpots(List<Vehicle>things);
            

        }
    
}