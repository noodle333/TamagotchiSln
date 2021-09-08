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
            //Randomize amount of decreased hunger
            int rNumber = gen.Next(1, 4);
            hunger -= rNumber;
            Console.WriteLine("You have fed your Tamagotchi!");
        }

        public void Hi()
        {  
            //Say a random word
            int rWord = gen.Next(words.Count);
            Console.WriteLine("Your Tamagotchi says:");
            Console.WriteLine(words[rWord]);
            ReduceBoredom();
        }

        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();
        }

        public void Tick()
        {
            hunger++;
            boredom++;

            //Set tamagotchi alive value
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
                Console.ReadLine();   
            }
        }

        public bool GetAlive()
        {
            //Check if tamagotchi is alive
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
            //Randomize amount of decreased boredom
            int rNumber = gen.Next(1, 4);
            boredom -= rNumber;
            Console.WriteLine("Your Tamagotchi had fun!");
        }
    }
}