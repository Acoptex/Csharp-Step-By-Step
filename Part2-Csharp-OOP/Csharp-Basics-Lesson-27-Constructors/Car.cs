using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics_Lesson_27_Constructors
{
    internal class Car
    {
        // Create the fields
        string carName; // private variables
        string carModel;
        int carYear;
        string carColor;

        // Contructor's name should be the same as class name
        // Create a constructor without parameters for the Car class
        // Default constructor
        public Car()
        {
            Console.WriteLine("I am called from constructor without parameters");
        }
        // Create a class constructor with multiple parameters for the Car class
        public Car(string carName, string carModel)
        {
            this.carName = carName;
            this.carModel = carModel;
            Console.WriteLine("I am called from constructor with parameters");
            Console.WriteLine($"The car is {carName} {carModel}");
        }
        //public Car(string carName1, string carModel1)
        //{
        //    carName = carName1;
        //    carModel = carModel1;
        //    Console.WriteLine("I am called from constructor with parameters");
        //    Console.WriteLine($"The car is {carName} {carModel}");
        //}
        public Car(string carName, string carModel, int carYear)
        {
            this.carName = carName;
            this.carModel = carModel;
            this.carYear = carYear;
            Console.WriteLine("I am called from constructor with parameters");
            Console.WriteLine($"The car is {carYear} {carName} {carModel}");
        }
        public Car(string carName, string carModel, int carYear, string carColor)
        {
            this.carName = carName;
            this.carModel = carModel;
            this.carYear = carYear;
            this.carColor=carColor;

            Console.WriteLine("I am called from constructor with parameters");
            Console.WriteLine($"The car is {carColor} {carYear} {carName} {carModel}");
        }
        // Member method
        public void SimpleMethod()
        {
            Console.WriteLine("I am called from Simple method.");
        }
    }
    
   
}
