using System;

namespace TypesProject
{
    class Program
    {
        int x = 100; //Non-Static variable
        static int y = 200; //Static variable

        public Program(int x)
        {
            this.x = x;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(y);
            Program p1 = new Program(15);
            Program p2 = new Program(50);
            Console.WriteLine(p1.x + " " + p2.x);            
            Console.ReadLine();
        }
    }
}
