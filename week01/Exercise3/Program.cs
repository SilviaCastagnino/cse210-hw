using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Random randomGenerator = new Random();
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;
            int attempts = 0;
            Console.WriteLine("Guess the magic number between 1 and 100!");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }

                else
                {
                    Console.WriteLine($"Congratulation, you guessed in {attempts} tries!");
                }
            }
            Console.Write("Would you like to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thanks for playing!");
    }
}