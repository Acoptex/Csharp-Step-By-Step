using System;

namespace Csharp_Basics_Lesson_15_Ternary_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Short Hand If...Else (Ternary Operator)
            // Syntax:
            /*
             
             variable = (condition) ? expressionTrue :  expressionFalse;

             */

            // condition has to be either true or false

            // The conditional operator is right-associative
            // It means, that
            // a ? b : c ? d : e
            // is evaluated as
            // a ? b : (c ? d : e)

            // The conditional Operator cannot be overloaded.

            int age = 12;

            //if (age < 16)
            //{
            //    Console.WriteLine("Your age is below 16.");
            //}
            //else if (age < 19)
            //{
            //    Console.WriteLine("Your age is between 16 and 18.");
            //}
            //else
            //{
            //    Console.WriteLine("You are more than 18 years old.");
            //}

            Console.Write("What is your age? ");

            string userAge = Console.ReadLine();
            
            int.TryParse(userAge, out age);

            string result = (age<16)? "Your age is below 16.": (age < 19)? "Your age is between 16 and 18.": "You are more than 18 years old.";
            
            Console.WriteLine(result);


            Console.Read();

        }
    }
}
