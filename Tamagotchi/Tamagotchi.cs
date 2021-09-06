using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private int hunger;

        private int boredom;

        private List<string> words = new List<string>();

        private bool isAlive;

        private Random gen = new Random();

        public string name;

        public void Feed()
        {
            hunger--;
        }

        public void Hi()
        {  
            int rWord = gen.Next();

            Console.WriteLine(rWord);

            ReduceBoredom();
        }

        public void Teach(string word)
        {
            Console.WriteLine("Which word would you like to teach your pet?");
            words.Add(Console.ReadLine());

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
                Console.WriteLine("Your tamagotchi is alive!");
            }
            else {
                Console.WriteLine("Your tamagotchi is dead!");
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
        }

    }

}