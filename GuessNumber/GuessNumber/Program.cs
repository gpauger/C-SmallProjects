using System;


namespace GuessNumber
{
    class Program
    {
        static void Main()
        {
                Console.WriteLine("Let's play a game. Guess a number between 0-100.");
                int rand = (new Random()).Next(0, 100);
                int guess = Convert.ToInt32(Console.ReadLine());
                do
                {
                    while (guess < rand)
                    {
                        Console.WriteLine("Guess higher!");
                    guess = Convert.ToInt32(Console.ReadLine());
                    }
                    while (guess > rand)
                    {
                        Console.WriteLine("Guess lower!");
                        guess = Convert.ToInt32(Console.ReadLine());
                    }
                }
                while (guess != rand);
            Console.WriteLine("You guessed it!!!");
            Console.ReadLine();
        }
    }
}
