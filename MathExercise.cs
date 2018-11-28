using System;


namespace MathExercise
{
    class MathExercise
    {
        static void Main()
        {    //This section multiplies a given number by 50
            Console.WriteLine("I can do math.  Watch.  Give me a number.");
            long num1 = Convert.ToInt64(Console.ReadLine());
            long product = num1 * 50;
            Console.WriteLine(num1 + " Times 50 = " + product);

            //This section adds 25 to a given number
            Console.WriteLine("Give me another number.");
            long num2 = Convert.ToInt64(Console.ReadLine());
            long sum = num2 + 25;
            Console.WriteLine(num2 + " plus 25 = " + sum);

            //This section divides a given number by 12.5
            Console.WriteLine("Give me another number.");
            long num3 = Convert.ToInt64(Console.ReadLine());
            decimal dec1 = 12.5m;
            decimal quotient = num3 / dec1;
            Console.WriteLine(num3 + " divided by 12.5 = " + quotient);

            //This section returns true or false if number given is greater than 50
            Console.WriteLine("Give me another number.");
            long num4 = Convert.ToInt64(Console.ReadLine());
            bool big50 = num4 > 50;
            Console.WriteLine(num4  + " is > 50: " + big50);

            //This section divides a given number by seven and prints the remainder
            Console.WriteLine("Last one. Give me another number.");
            long num5 = Convert.ToInt64(Console.ReadLine());
            long whole = num5 / 7;
            long remainder = num5 % 7;
            Console.WriteLine(num5 + " divided by 7 is " + whole + " with a remainder of " + remainder);
            Console.WriteLine("Impressed aren't you?");
            Console.ReadLine();
            


        }
    }
}
