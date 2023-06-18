using System;

namespace AccessDemo2
{
    // Case 2: Consuming members of a class from child class of different project
    class Four : AccessDemo1.Program
    {
        static void Main(string[] args)
        {
            Four f = new Four();
            f.Test3(); f.Test4(); f.Test5();
            Console.ReadLine();
        }
    }
}