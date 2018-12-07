using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDrill3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a number and I will double it:");
            int amount = Convert.ToInt16(Console.ReadLine());
            //instantiate the calss
            Calculate n = new Calculate();
            //call the method
            n.Double(amount);

            Console.WriteLine("Too easy, give me a decimal and I will tripple it:");
            decimal amount2 = Convert.ToDecimal(Console.ReadLine());
            n.Double(amount2);

            Console.WriteLine("What should I have said? :");
            string amount3 = Console.ReadLine();
            n.Double(amount3);
            Console.ReadLine();
        }
    }
}
