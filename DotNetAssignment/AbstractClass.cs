using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignment
{
    //abstract class practical example
    //class that contain abstract keyword in the declaration
    //it is used to put common charecteristics of its subclasses(we create a class as a abstract which we don't want to instantiate)
    public abstract class Person
    {
        public string FristName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }

        //abstract method contains only the declaration part not the implementaion or body
        public abstract void DisplayDetails();
    }

   
    public class Student :Person
    {
        //Rollnumber  is internal so we can access it anywhere in the current project/assembly/namespace but not outside
        internal int RollNumber { get; set; }

        public int Fees { get; set; }

        //overriding
        //if we overriding abstract class abstract method in child class we have to use override keyword
        //but in case of interface we did not use override keyword while giving implemetation of a interface method in implementaion class
        public override void DisplayDetails()
        {
            Console.WriteLine($"Student name is {this.FristName} {this.LastName}");
            Console.WriteLine($"Student Roll number is {this.RollNumber}");
        }
    }

    public class Teacher : Person
    {
        public int Salary { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine($"Teacher name is {this.FristName} {this.LastName}");
            Console.WriteLine($"Teacher salary is  {this.Salary}");
        }
    }

}



//abstract classes are used to declare common characteristics of subclasses
//it can only be used as a base class for other classes that extend the abstract class
//abstract class may or may not contain abstract mehtod(method without body)
//like any other classes abstract class can contain fields that describe the characteristics and methods that describe the action
//an abstract class can implement code with non abstract method
//abstract class can have modifiers for methods and properties
//abstract class can have constants and fields
//abstract class can have constructors

