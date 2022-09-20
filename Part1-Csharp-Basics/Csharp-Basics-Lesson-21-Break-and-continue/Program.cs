using System;

namespace Csharp_Basics_Lesson_21_Break_and_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Break and continue in For loops

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)// We stop at 4
                {
                    Console.WriteLine("We stop at 4.");
                    break;
                }
                Console.WriteLine($"The number is {i}");
            }
                     
            for (int k = 0; k < 10; k++)
            {
                if (k == 4)
                {
                    Console.WriteLine("We pass 4.");
                    continue;
                }
                Console.WriteLine($"The number is {k}");
            }
           
            for (int j = 0; j < 10; j++)
            {

                if (j % 2 == 0)// We skip the even numbers
                {
                    Console.Write("We print only the odd number - ");
                    continue;
                }
                Console.WriteLine(j);
            }

            Console.WriteLine("**************************************************");

            // Break and continue in while loops
            int n = 0;
            while (n < 10)
            {
                Console.WriteLine($"The number is {n}");
                n++;
                if (n == 4)
                {
                    Console.WriteLine("We stop at 4.");
                    break;
                }
            }

            int m = 0;
            while (m < 10)
            {
                if (m == 4)
                {
                    m++;
                    Console.WriteLine("We pass 4.");
                    continue;
                }
                Console.WriteLine($"The number is {m}");
                m++;
            }

            Console.Read();

        }
    }
}
