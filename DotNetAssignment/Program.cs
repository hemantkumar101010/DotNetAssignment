namespace DotNetAssignment
{
    internal class Program
    {
        public static void Main()
        {
            Student student = new Student();

            student.FristName = "Hemant";
            student.LastName = "Kumar";
            student.Age = 24;
            student.RollNumber = 100;
            student.DisplayDetails();

            Console.WriteLine("--------------------------");

            Teacher teacher = new Teacher();

            teacher.FristName = "Rahul";
            teacher.LastName = "Rawat";
            teacher.Age = 24;
            teacher.Salary = 50000;
            teacher.Phone = 2312332;
            teacher.DisplayDetails();

            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");

            //PartTimeEmployee partTimeEmployee = new PartTimeEmployee();
            //partTimeEmployee.DisplayDetails();
            //partTimeEmployee.DisplayDetailsEmployee2();




            // Question 8 : If we have inherit 2 interface and both of them have same name for the method then how can we use both method from both interface?
            //ans 8 : By explicit implementaion

            //parents class reference variable can hold derived class object
            IEmployee2 employee = new PartTimeEmployee();
            employee.DisplayDetails();

            IEmployee employe2 = new PartTimeEmployee();
            employe2.DisplayDetails();





            //Question : How can we restrict a class that no one can create object of the class?
            Console.WriteLine("--------------------------");

            Employees employees = new Employees();

            employees.Display();




            Console.WriteLine("--------------------------");
            //Question : value type and reference tyep


            //value type struct
            Customer customer = new Customer();
            customer.Id = 100;

            Customer customer1 = customer;
            Customer customer2 = customer1;

            customer.Id = 101;
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer1.Id);
            Console.WriteLine(customer2.Id);

            Console.WriteLine("--------------------------");

            //reference type "Class"

            Customer1 c = new Customer1();
            c.Id = 100;

            Customer1 c1 = c;
            Customer1 c2 = c1;

            c.Id = 101;
            Console.WriteLine(c.Id);
            Console.WriteLine(c1.Id);
            Console.WriteLine(c2.Id);
        }
    }
}

