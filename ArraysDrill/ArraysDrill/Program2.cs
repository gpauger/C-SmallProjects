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
            string message1 = "\n \t Enter number to view position (1=PG, 2=SG, 3=SF, 4=PF, 5=C)";
            string error1 = "Please enter a valid number.";
            Console.WriteLine("...And now, the starting five for your Minnesota Timberwolves!");
            Console.WriteLine(message1);

            bool done = false;
            while (!done)
            {
                int input = Convert.ToInt16(Console.ReadLine());
                switch (input - 1)
                {
                    case 0:
                        Console.WriteLine(lineup[0]);
                        done = true;
                        break;
                    case 1:
                        Console.WriteLine(lineup[1]);
                        done = true;
                        break;
                    case 2:
                        Console.WriteLine(lineup[2]);
                        done = true;
                        break;
                    case 3:
                        Console.WriteLine(lineup[3]);
                        done = true;
                        break;
                    case 4:
                        Console.WriteLine(lineup[4]);
                        done = true;
                        break;
                    default:
                        Console.WriteLine(error1);
                        break;
                }
            }
           int[] statline = { 24, 8, 4 }; //generic statline for all players ;-(
            Console.WriteLine("Check out this player's stats. \n\t press 0 to view Points per game \n\t press 1 to view Rebounds per game \n\t press 2 to view Assists per game");

            bool done2 = false;
            while (!done2)
            {
                int stat = Convert.ToInt16(Console.ReadLine());
                switch (stat)
                {
                    case 0:
                        Console.WriteLine("He averages "+ statline[0] + " per game.");
                        done2 = true;
                        break;
                    case 1:
                        Console.WriteLine("He averages " + statline[1] + " per game.");
                        done2 = true;
                        break;
                    case 2:
                        Console.WriteLine("He averages " + statline[2] + " per game.");
                        done2 = true;
                        break;
                    default:
                        Console.WriteLine(error1);
                        break;
                }
            }
            List<string> game = new List<string>();
            game.Add("vs. L.A. Lakers");
            game.Add("at Portland Trailblazers");
            game.Add("vs. N.Y. Knicks");
            Console.WriteLine("Check out the Timberwolves upcomming games. \n\t press 0 to view Monday's game \n\t press 1 to view Thursday's game \n\t press 2 to view Saturday's game");

            bool done3 = false;
            while (!done3)
            {
                int input3 = Convert.ToInt16(Console.ReadLine());
                switch (input3)
                {
                    case 0:
                        Console.WriteLine(game[0]);
                        done3 = true;
                        break;
                    case 1:
                        Console.WriteLine(game[1]);
                        done3 = true;
                        break;
                    case 2:
                        Console.WriteLine(game[2]);
                        done3 = true;
                        break;
                    default:
                        Console.WriteLine(error1);
                        break;
                }
            }
            Console.ReadLine();




        }
    }
}
