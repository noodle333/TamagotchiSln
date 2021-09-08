using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi pet = new Tamagotchi();
            ChooseName(pet);
            GameLoop(pet);
            Console.WriteLine("Your Tamagotchi died :(! Better luck next time.");
            Console.ReadLine();
        }

        static void ChooseName(Tamagotchi t)
        {
            Console.WriteLine("What would you like to name your Tamagotchi?");
            t.name = Console.ReadLine();
        }

        static void GameLoop(Tamagotchi t)
        {
            bool isPetAlive = t.GetAlive();
            string playerChoice = "0";

            while (isPetAlive)
            {
                Console.WriteLine("What would you like to do? Input one of the following numbers:");
                Console.WriteLine("1: Feed, 2: Speak, 3: Teach, 4: See stats.");
                playerChoice = Console.ReadLine();
                PlayerAction(playerChoice, t);
                t.Tick();
                isPetAlive = t.GetAlive();
            }
        }

        static void PlayerAction(string c, Tamagotchi t)
        {
            if (c == "1")
            {
                t.Feed();
            }
            else if (c == "2")
            {
                t.Hi();
            }
            else if (c == "3")
            {
                Console.WriteLine("Which word would you like to teach your pet?");
                t.Teach(Console.ReadLine());
            }
            else if (c == "4")
            {
                t.PrintStats();
            }
            else 
            {
                Console.WriteLine("Incorrect input. Please input a number between 1-4.");
            }       
        }
    }
}
