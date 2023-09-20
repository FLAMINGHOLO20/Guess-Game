namespace Guess_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aesome Guessing Game";
            Console.WriteLine(@"     
   _____ _           _       _____         _   
  / ____| |         | |     / ____|       | |  
 | (___ | |__   __ _| |_   | |  __  __   _| |_ 
  \___ \| '_ \ / _` | __|  | | |_ \| | | | __|
  ____) | | | | (_| | |_   | |__| | |_| | |_ 
 |_____/|_| |_|\__,_|\__|   \_____|\__,_|\__|");
            Console.WriteLine("\nPress any key to start the game...\n");
            Console.ReadKey();
            Console.Clear();
            Game2.Play();
            Console.ReadKey();
            DisplayEndScreen();
        }

        public static void DisplayEndScreen()
        {
            Console.Clear();
            Console.WriteLine("\nCongratulations! You won the Guessing Game!");
            Console.WriteLine(@"     
_____          __  __ ______    ______      ________ _____  
/ ____|   /\   |  \/  |  ____|  / __ \ \    / /  ____|  __ \ 
| (___    /  \  | \  / | |__    | |  | \ \  / /| |__  | |__) |
\___ \  / /\ \ | |\/| |  __|   | |  | |\ \/ / |  __| |  _  / 
____) |/ ____ \| |  | | |____  | |__| | \  /  | |____| | \ \ 
|_____/_/    \_\_|  |_|______|  \____/   \/   |______|_|  \_\
                                                               
                                                                    ");
            Console.WriteLine("Thank you for playing the Guessing Game!");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}