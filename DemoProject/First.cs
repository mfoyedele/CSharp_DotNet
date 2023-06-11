using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class First
    {
        public int x = 100;
    }
    class TestClasses
    {
        static void Main()
        {
            First f1 = new First();
            First f2 = new First();
            First f3 = new First();
            Console.WriteLine(f1.x + " " + f2.x + " " + f3.x);
            Console.ReadLine();
        }
    }
}
