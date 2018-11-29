using System;

namespace PackageApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            Console.WriteLine("Please enter the package weight:");
            decimal weight = Convert.ToInt32(Console.ReadLine());
            string error ="Package is too big to be shipped via Package Express. Have a nice day!";
            if (weight > 50)
            {
                Console.WriteLine(error);
            }
            else
            {
                Console.WriteLine("Please enter the package height:");
                decimal height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package width:");
                decimal width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the package length:");
                decimal length = Convert.ToInt32(Console.ReadLine());
                decimal volume = height + length + width;
                decimal cost = volume * weight / 100;
                if (50 >= volume)
                {
                    Console.WriteLine("Your estimated total for shipping will be $" + cost + ".  Thank you.");
                }
                else { 
                Console.WriteLine(error);
                }
                    
            }
            Console.ReadLine();      
            }
            
        }
    }

