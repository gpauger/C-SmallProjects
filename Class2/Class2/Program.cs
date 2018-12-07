using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");

            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            double y = Convert.ToDouble(Console.ReadLine());
            
            //instantiates class2
            Class2 comp = new Class2();
            //calls the method from class2
            
            comp.Combine(x, y);
            comp.Combine(num1: x, num2: y);
            Console.ReadLine();


        }
    }
}
