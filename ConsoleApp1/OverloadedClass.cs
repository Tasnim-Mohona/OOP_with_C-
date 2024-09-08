using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class OverloadedClass
    {
        static string print(string a)
        {
            return a;
        }

        static int print(int a)
        {
            return a;
        }

        static string print(string a, string b)
        {
            return a + b;
        }








        public static void Main(string[] args)
        {

            /*OverloadedClass overloadedClassObj = new OverloadedClass();*/

            Console.Out.WriteLine(print("Mohona", "Indrani"));
        }
    }
}