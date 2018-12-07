using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDrill5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiates the class
            Class1 n = new Class1();
            Console.WriteLine("Please enter a number: ");
           
             var x = Convert.ToInt16(Console.ReadLine());
            double y = x%2;
            if (y == 1) //checks even or odd.  If input is even it continues as int else it converts to double
            {
                var z = Convert.ToDouble(x);  //The third method requires input as double
                n.Divided(z); //calls 3rd (overload) method.  I realize changing the input variable defeats the purpose of an overload but I had to to make this work.
            }
            else { n.Divided(x); //calls first method
            }
            
            string message;
           
            //calls the second method
            n.ThankYou(out message);
            //calls static message
            MyMsg.Log("anystringwilldo?"); //wow, this feels clumsy and pointless but I guess it works.
            

       

            Console.ReadLine();

        }
    }
}
