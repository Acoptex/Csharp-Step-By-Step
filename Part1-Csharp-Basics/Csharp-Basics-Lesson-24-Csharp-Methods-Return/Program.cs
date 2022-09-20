using System;

namespace Csharp_Basics_Lesson_24_Csharp_Methods_Return
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            // C# Methods
            // Return method - method which returns a value
            Console.WriteLine($"The result is {MyMethod(5)}"); // Result 2 + 5 = 7

            Console.WriteLine(Add(11, 22));                 // Result 11+22 =33
            Console.WriteLine(Add(Add(11, 22), 10));        // Result 33+10 = 43
            Console.WriteLine(Deduct(5, 2));                // Result 5-2 = 3
            Console.WriteLine(Multiply(3, 5));              // Result 3*5 = 15
            Console.WriteLine(Divide(11, 5));               // Result 11/5 = 2.2
            Console.Read();
        }   

    static int MyMethod(int x)
    {
        return 2 + x;
    }
    static int Add(int num1, int num2)
    {
        int result = num1 + num2;
        return result; // return num1 + num2;        
    }
    static int Deduct(int num1, int num2)
    {
        return num1 - num2;      
    }
        static int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    static double Divide(double num1, double num2)
    {
        return num1 / num2;
    }

    }
}
