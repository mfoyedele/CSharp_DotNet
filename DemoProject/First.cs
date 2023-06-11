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

    class Second
    {
        public int x;
    }
    class TestClasses
    {
        static void Main()
        {
            First f1 = new First();
            First f2 = new First();
            First f3 = new First();
            Console.WriteLine(f1.x + " " + f2.x + " " + f3.x);
            
            Second s1 = new Second();
            Second s2 = new Second();
            Second s3 = new Second();
            Console.WriteLine(s1.x + " " + s2.x + " " + s3.x);
            Console.ReadLine();
        }
    }
}
