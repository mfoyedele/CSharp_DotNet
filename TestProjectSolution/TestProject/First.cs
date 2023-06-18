using System;

namespace TestProject
{
    class First
    {
        int x = 100;
        static void Main(string[] args)
        {
            //First f; // Variable of a class is a copy of the class that is not initialized
            //f = new First(); // Instance of a class is a copy of the class that is initialized by using the "new" keyword
            //Console.WriteLine(f.x);

            First f1 = new First(); // f1 is instance of class
            First f2 = new First(); // f2 is instance of class
            Console.WriteLine(f1.x + " " + f2.x);
            Console.ReadLine();

        }
    }
}  

