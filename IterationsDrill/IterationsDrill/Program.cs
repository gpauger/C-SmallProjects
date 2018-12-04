using System;
using System.Collections.Generic;

namespace IterationsDrill
{
    class Program
    {
        static void Main(string[] args)
        { //step 1 create and print array from user input
            string[] fullname = new string[3];
            for (int i = 0, j = 0; i < fullname.Length; i++, j++)
            {
                string[] namepart = { "first", "middle", "last" };
                Console.Write("What is your " + namepart[j] + " name?");
                fullname[i] = Console.ReadLine(); }
            Console.WriteLine("Hello");
            for (int k = 0; k < fullname.Length; k++)
            { Console.WriteLine(fullname[k]); }

            //part 2-5 create then fix infinite loop, uses ">", ">=" as conditionals
            List<int> counting = new List<int>();
            for (int a = 0; a <= 10; a++)  //changed "a >= 0" to "a <= 10 to fix infinite loop
            {
                counting.Add(a);
            }
            Console.WriteLine("I just counted to " + counting[10]);
            //part 6-8 creates a searchable list of strings
            List<string> pets = new List<string>()
            { "dog", "cat", "fish", "hamster", "horse", "snake", "lizard", "mouse", "rat", };
            Console.WriteLine("What type of pet are you interested in?");
            string petsearch = Console.ReadLine();
            for (int b = 0; b < pets.Count; b++)
            { if (petsearch == pets[b])
                {
                    Console.WriteLine(pets[b] + " is index number " + pets.IndexOf(petsearch));
                    break;
                }
                else if (b == pets.Count-1){
                    Console.WriteLine("Sorry, that pet is not listed in our index.");
                    break;
                        }
            }

            //part 9-10 creates a searchable list of strings
            List<string> names = new List<string>()
            { "Dan", "Daniel", "David", "Doug", "Dwight", "Dan", "David", "David", "Dave", };
            Console.WriteLine("Search this list of boys whose first names start with the letter D:");
            string namesearch = Console.ReadLine();
            for (int c = 0; c < names.Count; c++)
            {
                if (names[c] == namesearch)
                {
                    Console.WriteLine(namesearch + " is index number " + names.IndexOf(namesearch, c));
                }
                else if (c == names.Count - 1)
                {
                    Console.WriteLine("Sorry, that name is not on our list.");
                    break;
                }
            }

            //part 11 creates a  list of strings and reports how many times it appears on the list.
            List<string> days = new List<string>()
            { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday", "Monday", "Tuesday" };
           
                foreach (string day in days)
            {
                int count = 0;
                string daysearch = day;
                for (int d = 0; d < names.Count; d++)
                {
                    if (daysearch == days[d]) { count++; }
                }
                Console.WriteLine(day + ": " + count);
            } 
              

                Console.ReadLine();
        }
    }
}
