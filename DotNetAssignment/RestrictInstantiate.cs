using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetAssignment
{

    //How can we restrict a class that no one can create object of the class?
    //by making a class as a static/abstract we can restrict it's instantiation
    //we make static class if we need to put fix data in a class
    static class Company
    {
        public static string CompanyName { get; set; }
        public static int EstablishYear { get; set; }

        //initializing using static constructor
        static Company()
        {
            CompanyName = "Kellton";
            EstablishYear = 1990;
        }
        public static void GetDetails()
        {
            Console.WriteLine($"Company name is {CompanyName}");
            Console.WriteLine($"Establish year is {EstablishYear}");
        }

    }
    //also a static class can't be inherited by subclasses
    public class Employees
    {
        public void Display()
        {
            //can't create object of static class so to access its members we use class name

            // Company company = new Company();

            Company.GetDetails();
        }
    }
}
