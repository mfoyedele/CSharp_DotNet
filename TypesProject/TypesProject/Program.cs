using System;

namespace TypesProject
{
    class Program
    {
        int x; //Non-Static variable
        static int y = 200; //Static variable
        const float pi = 3.14f; // Constatic variable
        readonly bool flag;
        public Program(int x)
        {
            this.x = x;
            this.flag = true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(y);
            Console.WriteLine(pi);
            Program p1 = new Program(15);
            Program p2 = new Program(50);
            Console.WriteLine(p1.x + " " + p2.x);            
            Console.ReadLine();
        }
    }
}
