using System;

namespace Csharp_Basics_Lesson_17_Csharp_Exceptions_Try_Catch_Finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Exceptions - Try..Catch..Finally

            /*
             
            try 
            {
                //  Block of code to try
            }
            catch (Exception e)
            {
                //  Block of code to handle errors
            }
            finally
            {
                //  Block of code executed after try and catch regardless of the result
            }
             */

            // Throwing an exception
            //Console.Write("Please enter a number: ");
            //string userInput = Console.ReadLine();
            //try
            //{
            //    int userInputConverted = int.Parse(userInput);
            //}
            //catch (Exception)           
            //{
            //   throw;
            //}

            // Writing system message in Console

            //Console.Write("Please enter a number: ");
            //string userInput = Console.ReadLine();
            //try
            //{
            //    int userInputConverted = int.Parse(userInput);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //    Console.WriteLine("Something went wrong.");
            //}

            // Writing own message in Console

            //int num1 = 5, num2 = 0;
            //try
            //{
            //    int result = num1 / num2;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Can't devide by zero!");
            //}

            //Console.Write("Please enter a number: ");
            //string userInput = Console.ReadLine();
            //try
            //{                
            //    int userInputConverted = Int32.Parse(userInput);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Please enter only number.");
            //}
            //finally
            //{
            //    Console.WriteLine("The 'try catch' is finished.");
            //}

            // The throw statement allows you to create a custom error

            int age = 18; // if less 18 -> custom error message
            if (age < 18)
                {
                    throw new ArithmeticException("Access denied - You must be at least 18 years old.");
                }
            else
                {
                    Console.WriteLine("Access granted!");
                }                             

            Console.Read();




        }
    }
}
