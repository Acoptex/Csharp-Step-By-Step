using System;

namespace Csharp_Basics_Lesson_13_Math_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Math class has many methods that allows you to perform mathematical tasks on numbers.

            // 1. Math.Max(x,y)

            int num1 = 5;
            int num2 = 10;
            Console.WriteLine($"The maximum number of {num1} and {num2} is {Math.Max(num1, num2)}");
            Console.WriteLine("******************************************************************");

            // 2. Math.Min(x,y)

            int num3 = 5;
            int num4 = 10;
            Console.WriteLine($"The maximum number of {num3} and {num4} is {Math.Min(num3, num4)}");
            Console.WriteLine("******************************************************************");

            // 3. Math.Sqrt(x)

            float num5 = 10.0f;
            Console.WriteLine($"The square root of {num5} is {Math.Sqrt(num5)}");
            Console.WriteLine("******************************************************************");

            // 4. Math.Abs(x)

            int num6 = -5;
            Console.WriteLine($"The absolute (positive) value of {num6} is {Math.Abs(num6)}");
            Console.WriteLine("******************************************************************");

            // 5. Math.Round()
            float num7 = 9.99f;
            Console.WriteLine($"rounds a {num7} to the nearest whole number  -> {Math.Round(num7)}");
            Console.WriteLine("******************************************************************");

            Console.Read();

        }
    }
}
