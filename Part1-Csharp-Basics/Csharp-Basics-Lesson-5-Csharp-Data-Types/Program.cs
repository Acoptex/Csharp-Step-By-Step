using System;

namespace Csharp_Basics_Lesson_5_Csharp_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Data Types

            //1.Numbers
            
            // Integer types
            int myInt = 5;                      
            long myLong = 1455555555555555L;
            Console.WriteLine(myInt);
            Console.WriteLine(myLong);

            // Floating point types
            float myFloat = 4.4598F;            
            double myDouble = 45.4589D;         
            decimal myDecimal = 145.12569888M;
            Console.WriteLine(myFloat);
            Console.WriteLine(myDouble);
            Console.WriteLine(myDecimal);

            // Scientific Numbers
            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);
            
            // 2.Booleans. Can be true or false
            bool myBoolean = true;
            Console.WriteLine(myBoolean);

            // 3.Characters
            char myLetter = 'A';
            Console.WriteLine(myLetter);


            // 4.String
            string myText = "Hello World";
            Console.WriteLine(myText);

            Console.Read();
        }
    }
}
