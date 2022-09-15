using System;

namespace Csharp_Basics_Lesson_4_Naming_Conventions_And_Coding_Standards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Naming conventions and coding standards

            // Naming conventions

            /*
            The general rules for naming variables are:
               Names can contain letters, digits and the underscore character(_)
               Names must begin with a letter
               Names should start with a lowercase letter and it cannot contain whitespace
               Names are case sensitive("myNum" and "mynum" are different variables)
               Reserved words (like C# keywords, for example int, double, float, for and so on) cannot be used as names
            */

            int a = 1;

            int b2 = 2;

            int num_one = 3;

            bool _isRegister = true;

            // Coding standards

            /*
             Reasonable variable name
             Proper method name
             */
           
            int revolutionPerMinute = 60; // Good                       
            int rpm = 60; // It's OK, but not so easy to understand what rpm actually is

            Console.Read();
        }
    }
}
