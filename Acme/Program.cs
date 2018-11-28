using System;


namespace Acme
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            string s = "Welcome to Acme Accounting System";
            string t = "Remember, we are ''Accounting'' on you!";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
            Console.SetCursorPosition((Console.WindowWidth - t.Length) / 2, Console.CursorTop);
            Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
