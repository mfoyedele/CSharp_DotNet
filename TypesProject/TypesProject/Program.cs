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
            Console.ReadLine();
        }
    }
}
