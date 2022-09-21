using System;

namespace Csharp_Basics_Lesson_26_OOP_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // A class is a template for objects, and an object is an
            // instance of a class.
            // When the individual objects are created, they inherit
            // all the variables and methods from the class.

            Person alex = new Person();
            alex.firstName = "Alex";
            alex.lastName = "Best";
            alex.IntroduceMyself();

            Person sam = new Person();
            sam.firstName = "Sam";
            sam.lastName = "Best";
            sam.IntroduceMyself();

            Console.Read();

        }
    }
}
