using System;


namespace DailyReport
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string s = "The Tech Academy";
            string t = "Student Daily Report";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.SetCursorPosition((Console.WindowWidth - t.Length) / 2, Console.CursorTop);
            Console.WriteLine(t);
            Console.WriteLine("What course are you on?");
            string courseOn = Console.ReadLine();
            Console.WriteLine("What page number?");
            uint pageOn = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine("Do you need help with anything?  Please answer 'true' or 'false'.");
            bool needHelp = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Where there any positive experiences you would like to share?  Please give specifics.");
            string posExp = Console.ReadLine();
            Console.WriteLine("Is there any feedback you'd like to share?  Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            byte studyHours = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly.  Have a great day!");
            Console.ReadLine();

        }
    }
}
