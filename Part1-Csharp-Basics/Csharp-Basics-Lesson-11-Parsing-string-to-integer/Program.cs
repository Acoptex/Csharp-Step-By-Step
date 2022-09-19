using System;

namespace Csharp_Basics_Lesson_11_Parsing_string_to_integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parsing strings to integers

            // 1. First method

            Console.Write("Enter your age: ");
            // int userAge1 = Console.ReadLine(); -> error message: Cannot implicitly convert type 'string' to 'int'
            int userAge1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Your age is " + userAge1);
            Console.WriteLine("***********************************************************************************************************");
            string stringResult = "25" + "20";
            int integerResult = Int32.Parse("25") + Int32.Parse("20");
            Console.WriteLine("Result from strings concatination - {0} and result from sum of numbers - {1}", stringResult, integerResult);
            Console.WriteLine("***********************************************************************************************************");

            // 2. Second method

            Console.Write("Enter your age: ");
            int userAge2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is " + userAge2);
             Console.WriteLine("***********************************************************************************************************");
            // 3. Third method
            
            Console.Write("What is the temperature outside? ");
            string temperatureInput = Console.ReadLine();
            int numberTemperature;
            int.TryParse(temperatureInput, out numberTemperature);
            Console.WriteLine($"The temperature outside is {numberTemperature}");       
            
            Console.Read();
        }
    }
}
