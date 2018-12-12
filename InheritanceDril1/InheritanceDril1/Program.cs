using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDril1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializes the class: Employee
            Employee sample = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 8675309
            };
            Employee sample2 = new Employee()
            {
                FirstName = "Sample2",
                LastName = "Student2",
                Id = 8675309
            };
            //Calls the method SayName from class: Employee
            sample.SayName();
            Console.WriteLine("ID: " + sample.Id);
            Console.WriteLine("Two employees have the same ID number:");
            //Calls the method from Employee.
            Console.WriteLine(sample ==  sample2);
            Console.ReadLine();
        }
    }
}
