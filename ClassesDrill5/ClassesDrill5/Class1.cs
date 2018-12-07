using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDrill5
{
    public class Class1 
    {//Creating method 1
        public void Divided(int x)
        {
            int output = x / 2;
          
            Console.WriteLine("The number (int) you entered divided by 2 = " + output);
        }
        //creating method 2 with output parameter
        public void ThankYou(out string ret)
        {
            ret = "Thank you!";
            Console.WriteLine(ret);
          
        }
        //Creating method 3 overloaded method 1
        public void Divided(double y)
        {
            double output = y / 2;
            Console.WriteLine("The number (double) you entered divided by 2 = " + output);
        }
        
    }
    //creating a static class
    public static class MyMsg
    {
        public static void Log(string msg)
        { Console.WriteLine("Goodbye!"); }
        
    }
}
