using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create an instance of a company. Name it whatever you like.
            Company ACoolCompany = new Company("The Coolest", new DateTime(1999, 10, 3));
            Console.WriteLine(ACoolCompany.Name);
            // Create three employees
            Employee tiffany = new Employee()
            {
                FirstName = "tiffany",
                LastName = "smith",
                Title = "awesome"
            };

            Employee john = new Employee()
            {
                FirstName = "john",
                LastName = "doe",
                Title = "dude"
            };

            Employee jane = new Employee()
            {
                FirstName = "jane",
                LastName = "doe",
                Title = "lady"
            };
            // Assign the employees to the company
            ACoolCompany.Employees.Add(jane);
            ACoolCompany.Employees.Add(john);
            ACoolCompany.Employees.Add(tiffany);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */

            ACoolCompany.ListEmployees();

        }
    }
}