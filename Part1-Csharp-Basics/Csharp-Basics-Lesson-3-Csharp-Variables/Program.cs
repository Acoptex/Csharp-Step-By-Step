using System;

namespace Csharp_Basics_Lesson_3_Csharp_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Variables
            // Syntax: type variableName = value;
            
            int num1, num2, num3;
            num1 = num2 = num3 = 20;

            int x = 1, y = 2, z = 14;
            
            int num4 = 10;

            int num5;
            num5 = 15;

            int num6 = 16;
            num6 = 19; // num6 is now 19

            // Other variables
            sbyte x = 120;
            short y = 12000;
            float myFloat = 4.59F;
            double num7 = 5.99D;
            decimal myDecimal = 145.1236M;
            char letter = 'D';
            bool isTrue = true;
            string name = "Acoptex";

            Console.WriteLine("{0} {1} {2}", num1, num2, num3);
            Console.WriteLine("{0} {1} {2}", x, y, z);
            Console.WriteLine(num4);
            Console.WriteLine(num5);
            Console.WriteLine(num6);
            Console.WriteLine(num7);
            Console.WriteLine(letter);
            Console.WriteLine(isTrue);
            Console.WriteLine(name);
            Console.Read();
        }
    }
}
