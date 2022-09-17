using System;

namespace Csharp_Basics_Lesson_9_Strings_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String methods

            string greeting = "Hello, World!";
            Console.WriteLine();
            Console.WriteLine($"The length of the {greeting} is: {greeting.Length} symbols");

            Console.WriteLine(greeting.ToUpper());   // Outputs "HELLO, WORLD!"
            Console.WriteLine(greeting.ToLower());   // Outputs "hello, world!"

            Console.Read();
        }
    }
}
