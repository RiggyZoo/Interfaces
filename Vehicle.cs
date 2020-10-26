using System;


namespace ConsoleApp3
{
    /// <summary>
    /// This is the base class.
    /// It has a virtual method in it that outputs a short description.
    /// There is also a virtual method that returns the parking coefficient
    /// By default, this coefficient is 1.2, but some heirs have their own coefficient.
    /// To initialize the properties length and width use a number in meters like 1.2
    /// To initialize the properties Weight use a number in kilograms like 1000.
    /// </summary>
    public  class Vehicle 
    {
        public  double Length { get; set; }

        public  double Width { get; set; }

        public  double Weight { get; set; }
        

        public virtual void GetDescribtion()
        {
            Console.WriteLine($"Length:{Length}\nWidth:{Width}\nWeight:{Weight}\n");
         
        }

        public  virtual double GetParkingСoef()
        {
            return 1.20;
        }

        
    }
    
}