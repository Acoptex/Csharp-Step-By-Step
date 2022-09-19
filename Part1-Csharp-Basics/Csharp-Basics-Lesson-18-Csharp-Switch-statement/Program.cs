using System;

namespace Csharp_Basics_Lesson_18_Csharp_Switch_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# switch

            /*Syntax:
             
            switch(expression) 
            {
             case x:
                // code block
                break;
             case y:
                // code block
                break;
             default:
                // code block
                break;
             }             
             
             */
            //Console.Write("Please input the weekday as a number from 1 to 7: ");
            //string userInput = Console.ReadLine();
            //try
            //{
            //    int day = Int32.Parse(userInput);

            //    switch (day)
            //    {
            //        case 1:
            //            Console.WriteLine("Monday");
            //            break;
            //        case 2:
            //            Console.WriteLine("Tuesday");
            //            break;
            //        case 3:
            //            Console.WriteLine("Wednesday");
            //            break;
            //        case 4:
            //            Console.WriteLine("Thursday");
            //            break;
            //        case 5:
            //            Console.WriteLine("Friday");
            //            break;
            //        case 6:
            //            Console.WriteLine("Saturday");
            //            break;
            //        case 7:
            //            Console.WriteLine("Sunday");
            //            break;
            //        default:
            //            Console.WriteLine("Imput not recognized.");
            //            break;
            //    }
            //}
            //catch (FormatException) {
            //    Console.WriteLine("Wrong format. Try again.");
            //}

            Console.Write("Please input the weekday as a number from 1 to 7: ");
            string userInput = Console.ReadLine();
            try
            {
                int day = Int32.Parse(userInput);

                if (day == 1)
                {
                    Console.WriteLine("Monday");
                }
                else if (day == 2)
                {
                    Console.WriteLine("Tuesday");
                }
                else if (day == 3)
                {
                    Console.WriteLine("Wednesday");
                }
                else if (day == 4)
                {
                    Console.WriteLine("Thursday");
                }
                else if (day == 5)
                {
                    Console.WriteLine("Friday");
                }
                else if (day == 6)
                {
                    Console.WriteLine("Saturday");
                }
                else if (day == 7)
                {
                    Console.WriteLine("Sunday");
                }
                else
                {
                    Console.WriteLine("Imput not recognized.");
                } 
            }
            catch (FormatException)
            {
                Console.WriteLine("Wrong format. Try again.");
            }

            Console.Write("Please enter a username: ");
            string username = Console.ReadLine().ToLower();

            switch (username)
            {
                case "alex":
                    Console.WriteLine("Username is Alex");
                    break;
                case "root":
                    Console.WriteLine("Username is Root");
                    break;
                default:
                    Console.WriteLine("Username is Unknown");
                    break;
            }

            Console.Read();
        }
    }
}
