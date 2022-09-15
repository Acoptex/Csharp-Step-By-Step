using System;

namespace Csharp_Basics_Lesson_8_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# strings and string methods

            string firstName = "Aleksandr";
            string secondName = "Cuchriajev";
            // 1. String concatination
            Console.WriteLine("1. String concatination");
            string fullName = firstName + " " + secondName;
            //string fullName = string.Concat(firstName, " ", secondName);
            Console.WriteLine(fullName + "\n");

            // 2. String formating
            Console.WriteLine("2. String formating");
            Console.WriteLine("{0} {1} \n", firstName, secondName);

            // 3. String interpolation
            Console.WriteLine("3. String interpolation");
            Console.WriteLine($"{firstName} {secondName}\n");

            // 4. Verbatim strings
            Console.WriteLine("4. Verbatim strings. Ignore any spaces and escape characters");
            Console.WriteLine(@"{firstName} {secondName}\n");
            Console.WriteLine(@"c:\Windows\current\user");

            // 5. String methods
            Console.WriteLine("5. String methods");

            Console.WriteLine(fullName.ToUpper());// ALEKSANDR CUCHRIAJEV
            Console.WriteLine(fullName.ToLower());// aleksandr cuchriajev

            string newString = "    How to remove the empty space    ";    
            Console.WriteLine(newString.Trim());

            Console.WriteLine(fullName.Substring(2));// String starting from index 2 -> "eksandr Cuchriajev"
            Console.WriteLine(newString.IndexOf("x"));// Result -1 means that no charackter in this string
            Console.WriteLine(newString.IndexOf("s"));// Index 28

            Console.WriteLine(String.IsNullOrWhiteSpace(firstName));// False

            Console.WriteLine(String.Format("My name is {0}", firstName));
            Console.Read();

        }
    }
}
