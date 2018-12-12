using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsDrill1
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the day of the week:");
            string daystring = Console.ReadLine();
            try
            {//this next line somehow checks the entered string against the enums, sets dayval = matching enum.  Necessary?
                DaysOfTheWeek dayval = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), daystring);
                //sets int d = enum value.  Actual conversion of enum to int is pretty basic.
                int d = Convert.ToInt16(dayval);
                Console.WriteLine(dayval + " has an enum value of: " + d);
                
            }
            catch
            {
                Console.WriteLine("Please enter the actual day of the week:");
            }
            ;
            
           
            Console.ReadLine();
        }
    }
}
