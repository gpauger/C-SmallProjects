using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstDrill1
{
    class Program
    {
        static void Main(string[] args)
        {

            //creates a constant string that can be reused by calling the variable 'welcome'
            const string welcome = "Hello and welcome!  Please enter your name:";
            Console.WriteLine(welcome);
            //creates generic varialbe which C# should recognize as a string
            var name = Console.ReadLine();
            //can't figure out why this wont instantiate
            User user1 = new User(name); 
          
            Console.WriteLine("Thanks " + user1.Name);
            Console.WriteLine("Your ID is: " + user1.ID );
            Console.WriteLine("You have " + user1.Trials + " free trials remaining.");
            Console.ReadLine();
        }
         
    }
}
