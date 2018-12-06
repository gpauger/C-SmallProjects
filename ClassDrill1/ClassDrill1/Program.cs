using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill1
{
     class Program
    {
      
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            double a = Convert.ToDouble(Console.ReadLine()) ;
            double ret;
            Class1 n = new Class1();

            //calling method 1
            ret = n.AddedTo(a);
            Console.WriteLine(a + " added to itself is :  " + ret);

            double ret2;
            Class1 o = new Class1();
            //calling method 2
            ret2 = o.MultBy(a);
            Console.WriteLine(a + " multiplied by itself is : " + ret2);
          

            double ret3;
            Class1 p = new Class1();
            //calling method 3
            ret3 = p.PowerOf(a);
            Console.WriteLine(a + " to the power of itself is : " + ret3);
            Console.ReadLine();
        }
    }
}



