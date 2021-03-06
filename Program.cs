﻿using System;


namespace Virtual_Pet
{
    class Program
    {
        static void Main(string[] args)
        {

            int userChoice;

            Bunny userBunny = new Bunny(true, true, "black", 1);

            Console.WriteLine("Hello, Let's meet your Virtual Pet.");
            Console.WriteLine("Your Pet is a Bunny!");

            do
            {


                userBunny.Tick();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("To see your bunny's name, type 1");
                Console.WriteLine("To feed your bunny, type 2");
                Console.WriteLine("To see if your bunny needs some attention, type 3");
                Console.WriteLine("To see how old your bunny is, type 4");
                Console.WriteLine("To see what color fur your bunny has, type 5");
                Console.WriteLine("To see your bunny's details, type 6");
                Console.WriteLine("To change the color of your bunny's fur, type 7");
                Console.WriteLine("To play with your bunny, type 8");
                Console.WriteLine("To quit, type 9");
                userChoice = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                switch (userChoice)
                {
                    case 1:
                        userBunny.BunnyName();
                        break;

                    case 2:
                        Console.WriteLine();
                        Console.WriteLine("Would you like to give Twitch some food? Please type yes or no");
                        string food = Console.ReadLine();
                        Console.WriteLine(userBunny.FeedTwitch(food));
                        break;

                    case 3:
                        Console.WriteLine(userBunny.BoredBunny());
                        break;

                    case 4:
                        Console.WriteLine(userBunny.Name + " is " + userBunny.Age + " years old.");
                        break;

                    case 5:
                        Console.WriteLine(userBunny.Name + " has " + userBunny.ColorFur + " fur.");
                        break;

                    case 6:
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Your Bunny's name is " + userBunny.Name);
                        Console.WriteLine(userBunny.FeedTwitch("yes"));
                        Console.WriteLine(userBunny.BoredBunny());
                        Console.WriteLine(userBunny.Name + " is " + userBunny.Age + " years old.");
                        Console.WriteLine(userBunny.Name + " has " + userBunny.ColorFur + " fur.");
                        break;

                    case 7:
                        Console.WriteLine();
                        Console.WriteLine(userBunny.Name + " has " + userBunny.ColorFur + " fur.");
                        Console.WriteLine();
                        Console.WriteLine("What color would you like to make Twitch's fur?, please enter a color.");                        
                        string newFur = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Twitch's fur is now " + userBunny.FurChange(newFur) + " !");                       
                        break;

                    case 8:
                        Console.WriteLine();
                        Console.WriteLine("Would you like to give Twitch a toy? Please type yes or no");
                        string toy = Console.ReadLine();
                        Console.WriteLine(userBunny.GiveToy(toy));
                        break;
                }
                
            } while (userChoice != 9);


        }


    }
}

