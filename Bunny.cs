using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual_Pet
{
    public class Bunny
    {

        //Create 5 Fields in class Bunny

        private string name = "Twitch";
        private bool isHungry;
        private bool isBored;
        private string colorFur;
        private int age;



        //Create 4 Properties in class Bunny
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
                return "Twitch has been fed!";
            }
        }

        //method to see if Twitch is bored

        public string  BoredBunny()
        {
            if (isBored == false)
            {
             return   "Twitch is happy and alert!";
                
            }
            else 
            {
              return "Twitch is very bored and is getting into mischief!";
            }
           
        }

        
        
           
        

    }
}
