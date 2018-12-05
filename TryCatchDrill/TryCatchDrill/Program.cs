using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> numlist = new List<int>() { 2, 4, 6, 8 };
                Console.WriteLine("Pick a number to divide by...");
                int y = Convert.ToInt32(Console.ReadLine());
                foreach (int num in numlist)
                {
                    int x = num;
                    int z = x / y;
                    Console.WriteLine(x + " / " + y + "  = " + z);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, your entry was in the wrong format.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Sorry, it is not safe to divide by 0.");
            }
            finally
            {
                Console.WriteLine("Thanks for playing.");
                Console.ReadLine();
            }
        }
    }
}


