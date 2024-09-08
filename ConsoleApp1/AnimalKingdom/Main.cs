using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.AnimalKingdom
{
    class Main
    {
        public static void main(String[] args) {

            // Create instances of Animal class and use it's method

            Animal myAnimal = new Animal(5, 10.5);

            // Using the methods
            myAnimal.printInfo();
            myAnimal.eatFood();

        }
    }
}
