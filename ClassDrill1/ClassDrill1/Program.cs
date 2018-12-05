using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDrill1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number.");
            double input = Convert.ToDouble(Console.ReadLine());
            Class1 example = new Class1();
            example.Result1 = input + input;
            example.Result2 = input * input;
            example.Result3 = Math.Pow(input,input);
            Console.WriteLine(input + " added to itself = " + example.Result1);
            Console.WriteLine(input + " multiplied by itself = " + example.Result2);
            Console.WriteLine(input + " to the power of itself = " + example.Result3);
            Console.ReadLine();
        }
    }
}
