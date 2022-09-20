using System;

namespace Csharp_Basics_Lesson_23_Csharp_Methods_Void
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //C# Methods
            // Void methods doesn't return anything
            /*
             
             static void MethodName(parameter1, parameter2,....) 
             {
                // code to be executed
             }
             
            MethodName(argument1, argument2...)
             
             */
            
            // 1. Method without parameter / parameters
            static void ExampleMethod()
            {
                Console.WriteLine("I am called from method.");
            }

            ExampleMethod();
            ExampleMethod();
            ExampleMethod();
            Console.WriteLine("****************************************************");
            
            // 2. Method with parameter / parameters
            static void GreetPerson(string firstName, string lastName)
            {
                Console.WriteLine($"Hi, {firstName} {lastName}");
            }

            GreetPerson("Alex","Best");
            GreetPerson("Olga","Best");
            GreetPerson("Paul","Best");
            Console.WriteLine("****************************************************");
            
            // 3. Method with default parameter / parameters
            static void PrintCountry(string country = "LITHUANIA")
            {
                Console.WriteLine(country);
            }

            PrintCountry("CHINA");
            PrintCountry("INDIA");
            PrintCountry();
            PrintCountry("JAPAN");
            Console.WriteLine("****************************************************");

            // 4. Method with named arguments
            static void MyChildren(string child1, string child2, string child3)
            {
                Console.WriteLine("The youngest child is: " + child2);
            }

            MyChildren(child3: "Alex", child1: "Sonya", child2: "Paul");
            Console.WriteLine("****************************************************");

            // 5. Method can be located outside the Main method too
            AnotherMethod();

            Console.Read();
        }
        static void AnotherMethod()
        {
            Console.WriteLine("I am called from the Method which is outside of the Main method");
        }
    }
}
