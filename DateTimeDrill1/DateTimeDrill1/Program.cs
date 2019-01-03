using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDrill1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("The current time is: " + DateTime.Now);
            Console.WriteLine("Please enter a number: ");
            Int16 x = Convert.ToInt16(Console.ReadLine());
            DateTime future = dateTime.AddHours(x);
       
            Console.WriteLine("In " + x + " hours, it will be: " + future);
            Console.ReadLine();

        }
    }
}
