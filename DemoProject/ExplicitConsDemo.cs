using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ExplicitConsDemo
    {
        public ExplicitConsDemo()
        {
            Console.WriteLine("Constructor is called");
        }
        static void Main()
        {
            ExplicitConsDemo obj1 = new ExplicitConsDemo();
            ExplicitConsDemo obj2 = new ExplicitConsDemo();
            ExplicitConsDemo obj3 = new ExplicitConsDemo();

            Console.ReadLine();
        }

    }
}
