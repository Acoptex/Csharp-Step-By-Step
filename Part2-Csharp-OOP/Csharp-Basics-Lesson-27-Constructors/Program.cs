using System;

namespace Csharp_Basics_Lesson_27_Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an object of the Car Class (this will call the constructor)
            Car audi = new Car();
            
            Car ford = new Car("Ford", "X5");
            // Console.WriteLine(ford.carName);// You can't access the value of carName as it is private

            Car opel = new Car("Opel", "Astra", 2005);

            Car nissan = new Car("Nissan", "Micra", 2015, "black");
            
            nissan.SimpleMethod();

            Console.Read();

        }
    }
}
