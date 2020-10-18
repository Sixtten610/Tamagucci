using System;

namespace tamagucci
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi tamagotchi = new Tamagotchi();

            NameTamagotchi(tamagotchi);

            GameLogic(tamagotchi);

        }

        static void NameTamagotchi(Tamagotchi tamagotchi)
        {
            System.Console.Write("enter tamagotchis name: ");
            tamagotchi.name = Console.ReadLine();
            Console.Clear();
        }

        static void GameLogic(Tamagotchi tamagotchi)
        {
            bool loop = tamagotchi.GetAlive();
            while (loop == true)
            {

                tamagotchi.PrintStats();
                System.Console.WriteLine("\nteach - teaches a new word\nhi - greet " + tamagotchi.name + 
                "\nfeed - feed tamagotchi\nskip - do nothing");
                GetAnswer(tamagotchi);

                System.Console.WriteLine("\n\n\npress 'enter' to continue");
                Console.ReadLine();
                Console.Clear();
            }

        }

        static void GetAnswer(Tamagotchi tamagotchi)
        {
            bool loop = true;
            while (loop == true)
            {
                string input = Console.ReadLine();

                if (input == "teach")
                {
                    System.Console.Write("write word: ");
                    input = Console.ReadLine();
                    tamagotchi.Teach(input);
                    loop = false;
                }
                else if (input == "hi")
                {
                    tamagotchi.Hi();
                    loop = false;
                }
                else if (input == "feed")
                {
                    tamagotchi.Feed();
                    loop = false;
                }
                else if (input == "skip")
                {
                    tamagotchi.Tick();
                    loop = false;
                }
                else
                {
                    System.Console.WriteLine(input + " does not exist"); 
                }

            }

        }

    }
}
