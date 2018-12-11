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
                LastName = "Student"
            };
            //Calls the method SayName from class: Employee
            sample.SayName();
            Console.ReadLine();
        }
    }
}
