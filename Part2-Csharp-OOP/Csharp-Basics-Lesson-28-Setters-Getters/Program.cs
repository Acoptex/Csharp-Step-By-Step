using System;

namespace Csharp_Basics_Lesson_28_Setters_Getters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box myBox = new Box();
            // myBox.length = 5; // you can not access it if length member variable is set to private
            // myBox.SetLength(-2); // you need a Set method to access it // if SetLength() is set to private - it's not possible to access

            myBox.height = 4;
            myBox.width = 5;

            Console.WriteLine($"The length is {myBox.GetLength()}");
            Console.WriteLine($"The volume of box is {myBox.GetVolume()}");

            myBox.DisplayInfo();

            Console.Read();

        }
    }
}
