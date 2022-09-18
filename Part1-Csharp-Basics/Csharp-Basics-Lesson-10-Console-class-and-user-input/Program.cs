using System;

namespace Csharp_Basics_Lesson_10_Console_class_and_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console class and user input
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.Write("Type any text and press Enter: ");
            string userInput = Console.ReadLine();
            Console.WriteLine($"You have typed -> {userInput}");

            Console.WriteLine("****************************************");

            Console.WriteLine("Type the string and hit Enter key: ");
            int anciValue = Console.Read();
            Console.WriteLine($"ANCII value is {anciValue}");

            Console.WriteLine("****************************************");

            

            Console.ReadKey();
        }
    }
}
