using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Adder
    {
        static int add(int a, int b) 
        {
            return a + b;
        }

        static double add(double a, int b) 
        {

            return a + b;
        }

        class TestOverloading3 
        {
            public static void main(String[] args)
            {
                Console.Out.WriteLine(Adder.add(11, 11));
            }
        }
    }
}
