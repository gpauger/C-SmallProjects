using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDrill4
{
    public class Class1
    {
        //creates method used in Program.cs
        public void Combine(double num1, string num2 = "default")
        {
            bool isNumeric = double.TryParse(num2, out double num2b);
            if (isNumeric == true)
            {
                double num3 = num1 + num2b;
                Console.WriteLine("Your numbers added together equal: " + num3);
            }
            else
            {
                double num3 = num1 + num1;
                Console.WriteLine("Your number added to itself is: " + num3);
            }
            
        }
    }
}
