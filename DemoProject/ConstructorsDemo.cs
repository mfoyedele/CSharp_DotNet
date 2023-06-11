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
            ConstructorsDemo d2 = new ConstructorsDemo();
            ConstructorsDemo d3 = new ConstructorsDemo();

            Console.WriteLine(y);
            Console.WriteLine(d1.x + " " + d2.x + " " + d3.x);
            Console.ReadLine();
        }
    }
}
