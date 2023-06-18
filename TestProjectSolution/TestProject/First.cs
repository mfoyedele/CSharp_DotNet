using System;

namespace TestProject
{
    class First
    {
        int x = 100;
        static void Main(string[] args)
        {
            First f;
            f = new First();
            Console.WriteLine(f.x);
            Console.ReadLine();

        }
    }
}  