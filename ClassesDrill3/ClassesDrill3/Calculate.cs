using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDrill3
{
    public class Calculate
    {
        int rounded; //saved vairable for third method
        //creates first method used in Program.cs
        public void Double(int num1)
        {
            int num2 = num1 * 2;
            Console.WriteLine(num2);
        }

        //creates second method used in Program.cs
        public void Double(decimal num1)  //name still Double even though this method tripples to satisfy drill requirement
        {
            decimal num2 = num1 * 3;
            Console.WriteLine(Convert.ToInt16(num2) + " I rounded.  Sue me.");
            rounded = Convert.ToInt16(num2);
        }

        //creates third method used in Program.cs
        public void Double(string num1)  //name still Double even though this method tripples to satisfy drill requirement
        {
            try
            {
                decimal converted1= Convert.ToDecimal(num1); //tihs is silly but the expected input is a string
                int converted2 = Convert.ToInt16(converted1); //that converts to a decimal more readily than an int.
            int num2 = rounded - converted2;
                Console.WriteLine("I was only off by : " + Convert.ToInt16(num2) + " What?  I like to round things.");
            }
            catch (FormatException)
            { Console.WriteLine("Sorry, I cant read what you wrote.  Goodbye."); }
        }
    }

}
