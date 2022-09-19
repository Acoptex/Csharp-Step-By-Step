using System;

namespace Csharp_Basics_Lesson_14_Charp_conditions_and_if_else_if_else_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# conditions and if else if else statements

            // C# has the following conditional statements:
            // Use if to specify a block of code to be executed, if a specified condition is true
            // Use else to specify a block of code to be executed, if the same condition is false
            // Use else if to specify a new condition to test, if the first condition is false
            // Use switch to specify many alternative blocks of code to be executed

            // The if Statement
            /* Syntax:
             
             if (condition) 
             {
                  // block of code to be executed if the condition is True
             }

             */
            int age = 21;

            if (age > 18)
            {
                Console.WriteLine("You are good to go.");
            }
            // The Else statement

            /* Syntax:
             
             if (condition) 
             {
                  // block of code to be executed if the condition is True
             }
             else
             {
                  // block of code to be executed if the condition is False
             }

             */
            age = 15;
            if (age > 18)
            {
                Console.WriteLine("You are good to go.");
            }
            else 
            { 
                Console.WriteLine("You are too young."); 
            }

            // else if statement
            /*
            
            if (condition1)
            {
                // block of code to be executed if condition1 is True
            } 
            else if (condition2) 
            {
              // block of code to be executed if the condition1 is false and condition2 is True
            } 
            else
            {
             // block of code to be executed if the condition1 is false and condition2 is False
            }

            */

            age = 12;
            if (age < 16)
            {
                Console.WriteLine("Your age is below 16.");
            }
            else if (age < 19)
            {
                Console.WriteLine("Your age is between 16 and 18.");
            }
            else
            {
                Console.WriteLine("You are more than 18 years old.");
            }


            Console.Read();
        }
    }
}
