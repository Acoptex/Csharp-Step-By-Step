using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics_Lesson_28_Setters_Getters
{
    internal class Box
    {
        // member variables
        private int length = 8;
        public int height;
        public int width;
        //public int volume; -> not required if you use the GetVolume()

        // 1. Encapsulation. First way to access the private member variable
        //public void SetLength(int length) 
        //{
        //    if (length < 0){
        //        throw new Exception("Length can not be below 0");
        //    }
        //    this.length = length;
        //}
        private void SetLength(int length) // only access from Box class or derived classes
        {
            if (length < 0)
            {
                throw new Exception("Length can not be below 0");
            }
            this.length = length;
        }
        public int GetLength()
        {
            return this.length;
        }
        public int GetVolume()
        {
            return this.length * this.height * this.width;
        }     


        // Member method
        public void DisplayInfo()
        {
            // Console.WriteLine($"The box volume: {length} x {width} x {height} = {volume = length * width * height}");
            Console.WriteLine($"The box volume: {length} x {width} x {height} = {GetVolume()}");
        }

        

    }
}
