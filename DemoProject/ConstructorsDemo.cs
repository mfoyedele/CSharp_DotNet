using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ConstructorsDemo
    {
        static ConstructorsDemo()
        {
            Console.WriteLine("Static constructor is called.");
        }
        public ConstructorsDemo()
        {
            Console.WriteLine("Non-Static constructor is called.");
        }
    }
}
