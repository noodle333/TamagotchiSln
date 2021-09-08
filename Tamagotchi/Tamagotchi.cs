using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private int hunger;

        private int boredom;

        private List<string> words = new List<string>();

        private bool isAlive = true;

        private Random gen = new Random();

        public string name;

        public void Feed()
        {
            hunger--;
            Console.WriteLine("You have fed your Tamagotchi!");
        }

        public void Hi()
        {  
            int rWord = gen.Next(words.Count);
            Console.WriteLine("Your Tamagotchi says:");
            Console.WriteLine(words[rWord]);
            ReduceBoredom();
        }

        public void Teach(string word)
        {
            Console.WriteLine("Which word would you like to teach your Tamagotchi?");
            words.Add(Console.ReadLine());
            Console.WriteLine("Your Tamagotchi learnt a new word!");
            ReduceBoredom();
        }

        public void Tick()
        {
            hunger++;
            boredom++;

            //Set alive value for tamagotchi
            if (hunger > 10 || boredom > 10)
            {
                isAlive = false;
            } 
            else
            {
                isAlive = true;
            }

        }

        public void PrintStats()
        {
            Console.WriteLine(hunger);
            Console.WriteLine(boredom);
            if (isAlive)
            {
                Console.WriteLine("Your Tamagotchi is alive!");
            }
            else {
                Console.WriteLine("Your Tamagotchi is dead!");
            }

        }

        public bool GetAlive()
        {
            if (isAlive)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }

        private void ReduceBoredom()
        {
            boredom--;
            Console.WriteLine("Your Tamagotchi had fun!");
        }

    }

}