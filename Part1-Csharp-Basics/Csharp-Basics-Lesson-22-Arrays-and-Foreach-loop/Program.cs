using System;

namespace Csharp_Basics_Lesson_22_Arrays_and_Foreach_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# arrays and Foreach loop


            // 1.
            // Declare an array
            string[] currency;
            // Add values, using new
            //currency = new string[2]; // or
            currency = new string[] {"USD", "EUR"};


            // 2. Create an array of four elements, and add values later

            string[] students = new string[5];
            students[0] = "Max";
            students[1] = "Olga";
            students[2] = "Jolanta";
            students[3] = "Nikola";
            students[4] = "Edikas";           

            // 3. Create an array of four elements and add values right away 

            string[] cars = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // 4. Create an array of four elements without specifying the size 
            string[] myCars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // 5. Create an array of elements, omitting the new keyword, and without specifying the size

            //  Index          0       1       2      3         4
            string[] names = { "Alex", "Olga", "Max", "Bill","Alexander" };
            int[] myNumbers = { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("************************* Change an array element ***************************");
            names[1] = "Radek";
            Console.WriteLine(names[1]);

            Console.WriteLine("************************* Length of array ***********************************");
            Console.WriteLine($"The length of array names is {names.Length}");

            Console.WriteLine("************************* Using for loop with array *************************");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine(students[i]);
            }

            Console.WriteLine("************************* Foreach loop ***********************************");
            /*
             
            Syntax:
            foreach (type variableName in arrayName) 
            {
                // code block to be executed
            }             
             
             */

            foreach (int i in myNumbers) { Console.WriteLine(i); }

            Console.WriteLine("*************************** Sort array **********************************");
            int[] numbers = { 5, 1, 8, 9 };
            Array.Sort(numbers);
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.Read();
        }
    }
}
