using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDrill1
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee
            {
                firstName = "Sample",
                lastName = "Student"
            };
            sample.SayName();
          
            Console.ReadLine();
        }
    }
}
