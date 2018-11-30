using System;
using System.Collections.Generic;


namespace ArraysDrill
{
    class Program
    {
        static void Main()
        {
            string[] lineup =
            {
                "Jeff Teague", "Andrew Wiggins", "Robert Covington", "Taj Gibson", "Karl Anthony Towns"
            };
            int[] statline = { 24, 8, 4 };
            string message1 = "\n \t Enter number to view position (1=PG, 2=SG, 3=SF, 4=PF, 5=C)";
            Console.WriteLine("...And now, the starting five for your Minnesota Timberwolves!");
            
            Console.WriteLine(message1);
            int input = Convert.ToInt16(Console.ReadLine());
            int id = 0;
            string error1 = "Please Enter a valid numerical value!";
            while (!int.TryParse(Console.ReadLine(), out id)) //works for non numbers but still have issues if its an invalid number
            {
                Console.WriteLine(error1);
                Console.WriteLine(message1);
            }
            switch (input - 1)
            {
                case 1:
                    Console.WriteLine(numArray[input - 1]);
                    break;
                default:
                    Console.WriteLine(error1);
                    break;


            };


            // At this point, you have a valid value...
            Console.WriteLine(lineup[id]);
            Console.WriteLine("Check out this player's stats. \n\t press 0 to view Points per game \n\t press 1 to view Rebounds per game \n\t press 2 to view Assists per game");
                
            int stat = 0;
            while (!int.TryParse(Console.ReadLine(), out stat)) //works for non numbers but still have issues if its an invalid number
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.WriteLine("\n\t press 0 to view Points per game \n\t press 1 to view Rebounds per game \n\t press 2 to view Assists per game");
            }
            Console.WriteLine(statline[stat]);
            Console.ReadLine();




        }
    }
}
