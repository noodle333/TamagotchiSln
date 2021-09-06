using System;

namespace Tamagotchi
{
    class Program
    {
        public void Main(string[] args)
        {
            Tamagotchi pet = new Tamagotchi();

            ChooseName(pet);


        }

        public void ChooseName(Tamagotchi t)
        {
            Console.WriteLine("What would you like to name your Tamagotchi?");
            
            t.name = Console.ReadLine();

        }
    }
}
