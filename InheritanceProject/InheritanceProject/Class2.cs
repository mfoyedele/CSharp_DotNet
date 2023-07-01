using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    internal class Class2 : Class1
    {
        static void Main(string[] args)
        {
            Class2 c = new Class2();
            c.Test1();
            c.Test2();
            Console.ReadLine();
        }
    }
}
