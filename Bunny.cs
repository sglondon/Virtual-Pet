using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pet
{
    public class Bunny
    {

        //Create  Fields in class Bunny

        private string name = "Twitch";
        private bool isHungry;
        private bool isBored;
        private string colorFur;
        private int age;





        //Create Properties in class Bunny
        //we're only going to use a get in the name, so
        //property so the user can't change it

        public string Name
        {
            get { return this.name; }
        }


        public bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }


        public bool IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value; }
        }

        public string ColorFur
        {
            get { return this.colorFur; }
            set { this.colorFur = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }



        //Create Constructors

        //default Constructor will also set our bunny's name

        public Bunny()
        {
            this.name = "Twitch";
        }



        public Bunny(bool isHungry, bool isBored, string colorFur, int age)
        {

            this.isHungry = isHungry;
            this.isBored = isBored;
            this.colorFur = colorFur;
            this.age = age;


        }



        //Create our Methods()
        // display pet's name
        //feed pet
        //check if pet is bored
        //check pet's fur color
        //change pet's fur color with user input
        //display pet's age



        public void BunnyName()
        {

            Console.WriteLine("Your Bunny's name is Twitch!");
        }


        //method to feed Twitch


        public string FeedTwitch()
        {
            if (isHungry == true)
            {
                return "Twitch is hungry and needs to be fed!";
            }
            else
            {
                return "Twitch is not hungry, he has been fed!";
            }
        }

        //method to see if Twitch is bored

        public string BoredBunny()
        {
            if (isBored == false)
            {
                return "Twitch is happy and alert!";

            }
            else
            {
                return "Twitch is very bored and is getting into mischief!";
            }
        }

        //method to change the color of Twitch's fur
        //using user input

        public string FurChange(string newFur)
        {
            this.colorFur = newFur;
            return newFur;
        }

        //method to change the value of isBored
        //by giving the pet a toy

        public string GiveToy(string toy)
        {
            if (toy == "yes")
            {
                isBored = false;
                return "Twitch now has a ball :)";
            }
            else if (toy == "no") ;
            isBored = true;
            return "Twitch has nothing to play with :(";
        }


        public void ChangeAge()
        {
            this.age = ++age;
        }


        public void Tick()
        {
            Console.WriteLine("Where is Twitch?");
            ChangeAge();
            Console.WriteLine("Twitch is " + age + " years old.");



        //    int count = 0;
            //string[] behaviors = new string[3];
            //behaviors[0] = "Twitch has lost his tail!";
            //behaviors[1] = "Twitch's ear's are growing!";
            //behaviors[2] = "Twitch has hopped away!";

            //for (int i = 0; i < behaviors.Length; i++)

            //do
            //{


            ////    Console.WriteLine(count);
            //    //   count++;

            //    if (count == 0)
            //    {
            //        Console.WriteLine(behaviors[0]);
            //        count++;

            //    }
            //    else if (count == 1)
            //    {
            //        Console.WriteLine(behaviors[1]);
            //        count++;
            //    }
            //    else if (count == 2)
            //    {
            //        Console.WriteLine(behaviors[2]);
            //        count++;
            //    }


            //} while (count < 3);

            

    }
    }
}

















