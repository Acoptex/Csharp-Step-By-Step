using System;

namespace Csharp_Basics_Lesson_19_Loops_While_and_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# loops While and Do/While

            /*
             
            Syntax:
             
            while (condition) 
            {
                // code block to be executed
            }
             
             */
            Console.WriteLine("Let's print the numbers from 0 to 9");
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine($"The number is {i}");
                i++;
            }
            Console.WriteLine("*************************************");
            
            int k = 0;
            string userInput = "";
            while (userInput == "")
            {
                Console.WriteLine("Press Enter key to increase amount by one.");
                Console.WriteLine("Press any key + Enter key to quit");
                userInput = Console.ReadLine();
                k++;
                if (userInput != "") k--;
                Console.WriteLine($"The counter result is {k}");
            }
            Console.WriteLine($"There are {k} people in the room. Press Enter key to close the program");
            Console.WriteLine("*************************************");

            /*
             
             Syntax:
                do 
                {
                    // code block to be executed
                }
                while (condition);
             
             */

            Console.WriteLine("Let's print the numbers from 0 to 9");
            int m = 0;
            do
            {
                Console.WriteLine($"The number is {m}");
                m++;
            }
            while (m < 10);
            
            Console.WriteLine("*****************************************");
            
            int lengthOfText = 0;
            string ourText = "";
            
            do
            {
                Console.Write("Please enter your friends' names: ");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                ourText += nameOfAFriend;
            } while (lengthOfText < 15);
           
            Console.WriteLine("This is your string -> " + ourText);


            Console.Read();
        }
    }
}
