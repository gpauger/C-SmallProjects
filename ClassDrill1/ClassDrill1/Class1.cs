using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill1
{
    public class Class1
    {   //method 1, adding number to itself
        public double AddedTo(double num1)
        {
            double result = num1 + num1;
            
            return result;
        }
        //method 2, multiply by itself
        public double MultBy(double num1)
        {
            double result = num1 * num1;

            return result;
        }
        //method 3, multiply by itself
        public double PowerOf(double num1)
        {
            double result = Math.Pow(num1, num1);

            return result;
        }
    }
}
