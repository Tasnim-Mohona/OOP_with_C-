using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.AnimalKingdom
{
    class Animal
    {
        // Fields
        private int age;
        private double weight;

        // Constructor
        public Animal(int age, double weight)
        {
            this.age = age;
            this.weight = weight;
        }

        // Method to Simulate Eating Food
        public void eatFood() 
        {
            Console.Out.WriteLine("Animal is eating food");
        }

        // Overloaded method with no parameters
        public void eatFood(String foodType) {
            Console.Out.Write("Animal is eating " + foodType);
        }

        // Method to print the age NS WEIGHT OF THE ANIMAL
        public void printInfo() 
        {
            Console.Out.WriteLine("My age is " + age + ", my weight is " + weight);

        }

        // Overloaded printInfo with extra parameter
        public void printInfo(string additionalInfo) {
            Console.Out.Write("My age is " + age +", my weight is " + weight + " ." + additionalInfo);
        }

        // Getters for age and weight (Optional)
        public int getAge() 
        {
            return age;
        }

        public double getWeight()
        {
            return weight;
        }


        // Setters for age and weight (Optional)
        public void setAge(int age)
        {
            this.age = age;
        }

        public void setweight(double weight)
        {
            this.weight = weight;
        }
    }
}
