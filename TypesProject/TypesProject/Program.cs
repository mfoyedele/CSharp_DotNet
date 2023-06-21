using System;

namespace TypesProject
{
    class Program
    {
        int x; //Non-Static/Instance variable
        static int y = 200; //Static variable
        const float pi = 3.14f; // Constatic variable
        readonly bool flag;
        public Program(int x, bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(y);
            Console.WriteLine(pi);
            Program p1 = new Program(15, true);
            Program p2 = new Program(50, false);
            Console.WriteLine(p1.x + " " + p2.x); 
            Console.WriteLine(p1.flag + " " + p2.flag);
            //p1.flag = false; - Readonly variable cannot be modified after initialization
            p1.x = 800;
            Console.WriteLine(p1.x);
            Console.ReadLine();
        }
    }
}
