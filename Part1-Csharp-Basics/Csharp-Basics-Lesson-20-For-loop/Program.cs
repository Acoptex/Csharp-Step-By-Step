using System;

namespace Csharp_Basics_Lesson_20_For_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# For loop

            /* 
             Syntax:

                 for (statement 1; statement 2; statement 3) 
                 {
                     // code block to be executed
                 }

             */
           
            Console.WriteLine("Let's print numbers from 0 to 9");
           
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"The number is {i}");
            }

            Console.WriteLine("**********************************");
            
            for (int k = 0; k <= 10; k+=2)
            {
                Console.WriteLine($"The number is {k}");
            }

            Console.WriteLine("**********************************");

            for (int m = 12; m >=0; m -= 3)
            {
                Console.WriteLine($"The number is {m}");
            }
            Console.Read();
        }
    }
}
