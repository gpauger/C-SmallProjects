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
            
         
            Console.WriteLine("Would you like to quit? (y/n)");
            
            string response = Console.ReadLine();
            bool ret = false;
            if (response == "y")
            { ret = true; }
            else { ret = false; }

            //create polymorphism IQuittable
            IQuittable quitting = new Employee();
            quitting.Quit(ret);
          
            Console.ReadLine();
        }
    }
}
