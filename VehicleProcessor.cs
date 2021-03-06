using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    /// <summary>
    /// This class is responsible for performing calculations
    /// </summary>
    public class VehicleProcessor: IVehicle
    { 
        /// <param name="things">The parameter is an List<> of Vehicle. Classes that inherits from the main class Vehicle</param>
        /// <returns> Returns the total value of the weight calculated from each Vehicle</returns>
        public  double GetAllWeight(List<Vehicle> things) 
        { 
            var allWeight = new double(); 
            foreach (var item in things) 
            { 
                allWeight = (int) (allWeight + item.Weight); 
            } 

            return allWeight; 
        } 
        
        
        /// <returns> total integer of classes</returns>
        public int GetParkingSpots(List<Vehicle> things)
        {
            return things.Count;
        }
        
        /// <returns> Returns the total value of the height calculated from each Vehicle</returns>
        public  double GetAllLength(List<Vehicle> things) 
        { 
            var allHeight = new double(); 
            foreach (var item in things) 
            { 
                allHeight += item.Length; 
            } 

            return allHeight; 
        }

        /// <returns>Returns total square of parking places need to build parking place.</returns>
        public double GetTotalParkingSquare(List<Vehicle> things)
        {
            var totalSquare = new double();
            foreach (var car in things)
            {
                
                totalSquare += GetParkingSquare(car);
            }

            return totalSquare;
        }


        /// <param name="item">The parameter is any class that inherits from the main class Vehicle</param>
       /// <returns>Parking square for specified parameter </returns>
        public double GetParkingSquare(Vehicle item)
        {
            return item.Length*item.Width*item.GetParkingСoef();
        }
       
      
       
    } 
}
