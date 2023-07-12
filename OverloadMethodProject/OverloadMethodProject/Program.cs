using System;

namespace OverloadMethodProject
{
    class Program
    {      
        public void Test()
        {
            Console.WriteLine("1st Method.");
        }
        public void Test(int i)
        {
            Console.WriteLine("2nd Method.");
        }
        public void Test(string s)
        {
            Console.WriteLine("3rd Method.");
        }
        public void Test(int i, string s)
        {
            Console.WriteLine("4th Method.");
        }
        public void Test(string s, int i)
        {
            Console.WriteLine("5th Method.");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
            p.Test(10);
            p.Test("Khalifa");
            p.Test(10, "Khalifa");
            p.Test("Khalifa", 10);
            Console.ReadLine();
        }       

    }
}