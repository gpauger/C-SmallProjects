using System;

namespace SalaryCompare
{
    class SalaryCompare
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            decimal rate1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            decimal hrs1 = Convert.ToDecimal(Console.ReadLine());
            
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            decimal rate2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            decimal hrs2 = Convert.ToDecimal(Console.ReadLine());

            decimal weekly1 = rate1 * hrs1;
            decimal weekly2 = rate2 * hrs2;
            decimal yearly1 = weekly1 * 52;
            decimal yearly2 = weekly2 * 52;

            Console.WriteLine("Person 1 will make $" + weekly1 + " per week or $" + yearly1 + " per year.");
            Console.WriteLine("Person 2 will make $" + weekly2 + " per week or $" + yearly2 + " per year.");

            bool compare = yearly1 > yearly2;

            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(compare);
            Console.ReadLine();


        }
    }
}
