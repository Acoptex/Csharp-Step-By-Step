using System;

namespace Csharp_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise Arrays / For loop
            // Create an array myFriends with the names of five friends
            // greet all of them with a for loop
            string[] myFriends1 = { "Sonya", "Alex", "Randy", "Andre", "Dan" };
            for (int i=0; i < myFriends1.Length; i++)
            {
                Console.WriteLine($"Hi {myFriends1[i]}");
            }

            Console.WriteLine("*******************************************************");

            // Exercise Arrays / Foreach loop
            // Create an array myFriends2 with the names of five friends
            // greet all of them with a foreach loop

            string[] myFriends2 = { "Sonya", "Alex", "Randy", "Andre", "Dan" };
            foreach (string name in myFriends2)
            {
                Console.WriteLine($"Hi {name}");
            }

            Console.Read();

        }
    }
}
