using System;

namespace DemoProject
{
    class Program
    {
        int i; bool b;
        static void Main(string[] args)
        { 
            Program p = new Program();
            Console.WriteLine("Value of i is: " + p.i);
            Console.WriteLine("Value of p is: " + p.b);

            Console.ReadLine();
        }
    }
}