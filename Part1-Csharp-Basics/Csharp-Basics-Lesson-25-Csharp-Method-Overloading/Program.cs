using System;

namespace Csharp_Basics_Lesson_25_Csharp_Method_Overloading
{
    internal class Program
    {
        // C# Method Overloading
        //static void Main(string[] args)
        //{
            
        //    int myNum1 = MethodSumInt(4, 2);
        //    double myNum2 = MethodSumDouble(2.5, 3.3);
        //    Console.WriteLine("Result - sum of int: " + myNum1);
        //    Console.WriteLine("Result - sum of double: " + myNum2);
        //}
        //static int MethodSumInt(int x, int y)
        //{
        //    return x + y;
        //}

        //static double MethodSumDouble(double x, double y)
        //{
        //    return x + y;
        //}

        static int MyMethod(int x, int y)
        {
            return x + y;
        }

        static double MyMethod(double x, double y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            int myNum1 = MyMethod(4, 2);
            double myNum2 = MyMethod(2.5, 3.3);
            Console.WriteLine("Result - sum of int: " + myNum1);
            Console.WriteLine("Result - sum of double: " + myNum2);
        }

    }
}
