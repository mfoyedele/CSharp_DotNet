using System;

namespace TestProject
{
    class First
    {
        int x = 100;
        static void Main(string[] args)
        {
            //First f; // Variable of a class is a copy of the class that is not initialized
            //f = new First(); // Instance of a class is a copy of the class that is initialized by using the "new" keyword which has its own memory and never shared with another instance.
            //Console.WriteLine(f.x);

            // Reference of a class is a copy of the class that is initialized by using an existing instance and references of class will not
            // have any memory allocation they will be sharing the same memory of the instance that assigned for initializing the variable.
            // Reference of a class can be called as a pointer to the instance and every modification we perform on the members using instance reflects when we access those members through reference and vice-versa.
            First f1 = new First(); // f1 is instance of class
            First f2 = f1; // f2 is reference of the class
            Console.WriteLine(f1.x + " " + f2.x);
            f1.x = 200;
            Console.WriteLine(f1.x + " " + f2.x);
            f2.x = 300;
            Console.WriteLine(f1.x + " " + f2.x);
            Console.ReadLine();

        }
    }
}  

