using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDrill1
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + firstName + " " + lastName);
        }
        public void Quit(bool iquit)
        {
            if (iquit == true)
            { Console.WriteLine("You have quit."); }
            else {
                Console.WriteLine("You did not quit.");
            }
        }
    }
}
