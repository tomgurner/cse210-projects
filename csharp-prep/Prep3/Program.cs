using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {

            Random randomGenerator = new Random();
            int magNum = randomGenerator.Next(1, 101);
            int numberOfTries = 0;

            int guess = -1;

            while (guess != magNum)
            {
                Console.WriteLine("What is guess? ");
                guess = int.Parse(Console.ReadLine());
                numberOfTries++;

                if (magNum > guess)
                {
                    Console.WriteLine("Higher");
                }

                else if (magNum < guess)
                {
                    Console.WriteLine("Lower");
                }

                else
                {
                    Console.WriteLine("That's IT! You guessed in " + numberOfTries + " guesses. ");
                }
            }

            Console.WriteLine("Would you like to play agian? Yes/No");
            string playAgainInput = Console.ReadLine().ToLower();

            if (playAgainInput != "yes")
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Thank you for playing. ");
    }
}