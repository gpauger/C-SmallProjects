using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill165
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool validAnswer = false;
            int age = 0;
            while (!validAnswer)
            {
                Console.WriteLine("Please enter your age:");
                var response = Console.ReadLine();
                validAnswer = int.TryParse(response, out age);
                
                try
                {
                    
                    if (age < 0)
                    {
                        throw new ExceptionNeg();
                    }
                    if (age == 0)
                    {
                        throw new Exception0();
                     
                    }
                    Int32 YearOfBirth = 2018 - age;
                    Console.WriteLine("You were born in the year " + YearOfBirth + ".");
                    Console.ReadLine();
                }
                catch (Exception0)
                {
                    Console.WriteLine("Sorry, you cannot possibly be 0 years old.");
                    validAnswer = false;
                }
                catch (ExceptionNeg)
                {
                    Console.WriteLine("Sorry, you cannot possibly be negative years old.");
                    validAnswer = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Sorry, something has gone wrong.  Please contact the program administrator.");
                }


            }
        }
            
    }
}
