using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Game1
{
    static Random RandomNumber = new Random();
    static int Guess = 0;
    static int Attemp = 0;
    static string Input = "";
    static int Target = RandomNumber.Next(10) + 1;
    

    public static void Play()
    {
        Console.WriteLine("Guess what number between 1 and 10 I am thinking of...");
        Input = Console.ReadLine();
        Attemp++;
        if (int.TryParse(Input, out Guess))
        {
            if (Guess == Target)
            {
                Console.WriteLine($"Congratulations! You guessed the number Correct on {Attemp} attemp. I was looking for {Target}");
            }
            else
            {
                Console.WriteLine($"Too bad! Try again!");
                Play();
            }
        }
        else 
        {
            Console.WriteLine("Please enter a number");
            Console.WriteLine("Press enter to continue...");
            Play();
        }
    }
}
