using System;

namespace GuessTheNumberGame //made by openai!
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate a random number between 1 and 100 (inclusive)
            Random random = new Random();
            int targetNumber = random.Next(1, 101);

            Console.WriteLine("Welcome to the Guess the Number game!");
            Console.WriteLine("I have chosen a number between 1 and 100 (inclusive). Try to guess it!");

            int attempts = 0;
            int maxAttempts = 10;

            while (attempts < maxAttempts)
            {
                Console.Write("Enter your guess: ");
                if (!int.TryParse(Console.ReadLine(), out int guess))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }

                attempts++;

                if (guess == targetNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the number {targetNumber} in {attempts} attempts.");
                    break;
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine("Your guess is too low. Try again!");
                }
                else
                {
                    Console.WriteLine("Your guess is too high. Try again!");
                }
            }

            if (attempts == maxAttempts)
            {
                Console.WriteLine($"Sorry, you have reached the maximum number of attempts ({maxAttempts}). The correct number was {targetNumber}.");
            }
        }
    }
}
