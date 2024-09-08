using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.AnimalKingdom
{
    class Monkey : Animal
    {
        // Additional field for Moneky 
        private String foodType;

        // Constructor for Moneky
        public Monkey(int age, double weight, String foodType): base(age,weight)
        {
            // Call the Parent (Animal) constructor 
            this.foodType = foodType;
        }

        // Override the eatFood method

            public override void eatFood(String foodType)
        {
            Console.Out.Write("This monkey loves" + foodType + ".");
        }
           
    }
}

