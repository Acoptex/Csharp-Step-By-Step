using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Basics_Lesson_26_OOP_Classes
{
    // This class is a blueprint for a datatype

    internal class Person
    {
        // Class Members
        // fields (or attributes)
        //string firstName = "Alex";    // private variable, you can not access it
        public string firstName = "Sam";// public variable, default value
        public string lastName;         // public variable
        
        // member method
        public void IntroduceMyself()
        {
            Console.WriteLine($"Hi, my name is {firstName}");
        }
    }   
           
     
    

}
