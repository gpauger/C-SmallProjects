using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace InOutDrill1
{
    class Program
    {
        static void Main(string[] args)
        {//this would work just as well for text, which seems fine for this drill.  Could change num to int instead of string but would need a couple of casts.
            Console.WriteLine("Please enter a number: ");
            string num = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\gpaug\Dropbox\Tech Academy\C-SmallProjects\InOutDrill1\log.txt", true))
            {
                file.WriteLine(num);
            };
            string text = File.ReadAllText(@"C:\Users\gpaug\Dropbox\Tech Academy\C-SmallProjects\InOutDrill1\log.txt");
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
