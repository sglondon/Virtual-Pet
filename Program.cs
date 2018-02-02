using System;

namespace Virtual_Pet
{
    class Program
    {
        static void Main(string[] args)
        {

            int userChoice;

            Bunny userBunny = new Bunny(false, "3", "black");

            do
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Hello! Let's meet your Virtual Pet!");
                Console.WriteLine("Your Pet is a Bunny!");
                Console.WriteLine("To see your pet's name, type 1");
                Console.WriteLine("To see if your pet is hungry, type 2");
                Console.WriteLine("To see if your pet needs some attention, type 3");
                Console.WriteLine("To see your pet's details, type 5");
                Console.WriteLine("To quit, type 8");

                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        userBunny.BunnyName(); 
                        break;

                    case 2:
                        Console.WriteLine(userBunny.FeedTwitch());
                        break;

                    case 3:
                        userBunny.BoredBunny();
                        break;

                    case 5:
                        Console.WriteLine("Your Bunny's name is " + userBunny.Name);
                        Console.WriteLine(userBunny.FeedTwitch());
                        Console.WriteLine("Your Bunny is " + userBunny.IsBored);
                        break;
                }

            } while (userChoice != 8);
        }
        }
    }

