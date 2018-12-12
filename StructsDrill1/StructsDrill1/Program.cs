using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructsDrill1
{
    class Program
    {
        static void Main(string[] args)
        {  //instantiates a new number
            Number x = new Number()
            { Amount = 0.75M };  //sets number's value property
            Console.WriteLine(x.Amount);
            Console.ReadLine();
        }
    }
}
