using System;

namespace TypesProject
{
    class Program
    {
        int x = 100; //Non-Static variable
        static int y = 200; //Static variable
        static void Main(string[] args)
        {
            Console.WriteLine(y);
            Program p1 = new Program();
            Console.WriteLine(p1.x);
            Console.ReadLine();
        }
    }
}
