using System;
using System.Collections.Generic;

namespace tamagucci
{
    public class Tamagotchi
    {
        private int hunger = 0;
        private int boredom = 0;
        private List<string> list = new List<string>();
        private bool isAlive = true;
        private static Random generator = new Random();
        public string name = "";

        public void Feed()
        {
            hunger -= 2;
        }
        public void Hi()
        {
            int sizeOfList = list.Count;
            int randomWord = generator.Next(sizeOfList);

            string word = list[randomWord];
            System.Console.WriteLine();
            System.Console.WriteLine(word);

            ReduceBoredom();

        }
        public void Teach(string word)
        {
            list.Add(word);

            ReduceBoredom();

        }
        public void Tick()
        {
            if (hunger == 10 || boredom == 10)
            {
                isAlive = false;
                Environment.Exit(0);
            }
            else
            {
                hunger++;
                boredom++;
            }

        }
        public void PrintStats()
        {
            System.Console.WriteLine("hunger: " + hunger);
            System.Console.WriteLine("boredom: " + boredom);
            System.Console.WriteLine("isAlive: " + isAlive);

        }
        public bool GetAlive()
        {
            return isAlive;
        }
        private void ReduceBoredom()
        {
            boredom -= 2;
        }

    }
}
