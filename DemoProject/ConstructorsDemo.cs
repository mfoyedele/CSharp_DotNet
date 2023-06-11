using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ConstructorsDemo
    {
        static int y;
        int x;
        static ConstructorsDemo()
        {
            Console.WriteLine("Static constructor is called.");
        }
        public ConstructorsDemo()
        {
            Console.WriteLine("Non-Static constructor is called.");
        }
        static void Main()
        {
            Console.WriteLine("Main method is called.");

            ConstructorsDemo d1 = new ConstructorsDemo();
            Console.ReadLine();
        }
    }
}
