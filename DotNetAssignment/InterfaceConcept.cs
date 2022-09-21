using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignment
{

    //an interface contain only the signature of the functionality or properties that the interface provide
    //all methods present in interface is by default abstract and public (we dont need to put explicitly)
    //the main reason of using interface is it can be used in multiple inheritance also used in dependency injection


    //If we have inherit 2 interface and both of them have same name for the method then how can we use both method from both interface?
   //ans : By explicit implementaion
    interface IEmployee
    {
        void DisplayDetails();
    }
    interface IEmployee2
    {
        void DisplayDetails();
        void DisplayDetailsEmployee2();
    }

    //multiple inheritance(an interface can also inherit another interface)
    interface IEmployee3 : IEmployee, IEmployee2
    {
        void DisplayDetailsEmployee3();
    }

    class PartTimeEmployee : IEmployee3
    {

      
        void IEmployee.DisplayDetails()
        {
            Console.WriteLine("Implementing IEmployee interface DisplayDetails method in PartTimeEmployee class.");
        }
        void IEmployee2.DisplayDetails()
        {
            Console.WriteLine("Implementing IEmployee2 interface DisplayDetails method in PartTimeEmployee class.");
        }

        //implicit implementaions
        public void DisplayDetailsEmployee2()
        {
            Console.WriteLine("Implementing IEmployee2 interface DisplayDetailsEmployee2 method in PartTimeEmployee class.");
        }

        public void DisplayDetailsEmployee3()
        {
            Console.WriteLine("Implementing IEmployee3 interface DisplayDetailsEmployee3 method in PartTimeEmployee class.");
        }

      
    }
}


//interface contains only abstract mehtods/members
//a class can inherit a interface but vise versa is not allowed
//interface cant have fields




