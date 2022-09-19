using System;

namespace Csharp_Basics_Lesson_16_Nested_if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nested if statements

            bool isRegistered = true;

            Console.Write("Username: ");
            string userName = Console.ReadLine();
           
            if (isRegistered)
            {
                Console.WriteLine("You are registered.");

                if (userName != "")
                {
                    Console.WriteLine($"Welcome, {userName}");

                    // This code will be executed, if userName is "Alex"
                    if (userName.Equals("Admin"))
                    {
                        Console.WriteLine("Hi Admin.");
                    }
                }
            }

            // You will get the same result by using logical AND
            if (isRegistered && userName != "" && userName.Equals("Admin"))
            {
                Console.WriteLine("You are registered.");
                Console.WriteLine($"Hello {userName}");
                Console.WriteLine("Hi Admin.");
            }

            Console.Read();

        }
    }
}
