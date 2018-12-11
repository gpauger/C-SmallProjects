using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDrill4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Give me another number (optional) or just press enter:");
            bool ifSuccess = int.TryParse(Console.ReadLine(), out int num2);
            //instantiates the class
            Class1 n = new Class1();
            //Calls the method
            n.Combine(num1, num2);
            Console.ReadLine();

        }
    }
}
