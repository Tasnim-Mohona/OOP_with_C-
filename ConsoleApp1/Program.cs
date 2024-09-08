using System;

namespace ConsoleApp1
{
    class Program
    {
        void print(String a, String b) {
            Console.WriteLine(a+b);
                
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           /* I1 i1 = new I1();*/
            M2 m2 = new M2();
            Mohona mohona = new Mohona(m2);
            
     
        }
    }

    class Mohona
    {
        public Mohona(I1 m2) { 
                
        }
    }

    class M2 : I1
    {
        public void printInfo()
        {
            Console.Write("Print something");
           
        }
    }


    interface I1 {

        public void printInfo();

    }

/*    public static void main(string[] args) 
    {
    

    }*/
}
