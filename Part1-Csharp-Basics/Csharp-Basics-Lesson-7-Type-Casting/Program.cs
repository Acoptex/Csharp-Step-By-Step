using System;

namespace Csharp_Basics_Lesson_7_Type_Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Type Casting
            /*  
             Implicit Casting (automatically) - converting a smaller type to a larger type size
                        char -> int -> long -> float -> double

            Explicit Casting (manually) - converting a larger type to a smaller size type
                        double -> float -> long -> int -> char
             */
            int myInt1 = 10;
            double myDouble1 = myInt1;       // Automatic casting: int to double

            Console.WriteLine(myInt1);      // Outputs 10
            Console.WriteLine(myDouble1);   // Outputs 10

            double myDouble2 = 9.99;
            int myInt2 = (int)myDouble2;    // Manual casting: double to int

            Console.WriteLine(myDouble2);   // Outputs 9.99
            Console.WriteLine(myInt2);      // Outputs 9

            // Type Conversion Methods
            /*
            Convert.ToBoolean 
            Convert.ToDouble 
            Convert.ToString 
            Convert.ToInt32 // int
            Convert.ToInt64 // long             
             */
            int myInt3 = 101;
            double myDouble3 = 3.99;
            bool myBool = true;
            string isTrue = "true";

            Console.WriteLine(Convert.ToString(myInt3));    // convert int to string
            Console.WriteLine(Convert.ToDouble(myInt3));    // convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble3));  // convert double to int
            Console.WriteLine(Convert.ToBoolean(isTrue));   // convert string to boolean
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string



            Console.Read();
        }
    }
}
