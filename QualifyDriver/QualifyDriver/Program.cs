using System;


namespace QualifyDriver
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? true or false");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int tix = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Qualified?");
            bool qualified = (age > 15 && !dui && tix <= 3);
            Console.WriteLine(qualified);
            Console.ReadLine();

           
        }
    }
}
