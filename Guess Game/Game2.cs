using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_Game
{
    public class Game2
    {
        private static Random random = new Random();
        private static int attempt = 0;
        private static int target = random.Next(1, 101);

        public static void Play()
        {
            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("I'm thinking of a number between 1 and 10. Can you guess what it is?");
            Console.WriteLine("Let's get started!\n");
            Console.WriteLine(target);
            while (true)
            {
                attempt++;
                Console.Write("Your guess: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int userGuess))
                {
                    if (userGuess == target)
                    {
                        Console.WriteLine($"\nCongratulations! You guessed the number {target} correctly in {attempt} attempts.");
                        break;
                    }
                    else if (userGuess < target)
                    {
                        Console.WriteLine("Too low! Try a higher number.\n");
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try a lower number.\n");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.\n");
                }
            }
        }
    }
}
