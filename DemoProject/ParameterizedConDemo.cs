using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    internal class ParameterizedConDemo
    {
        public ParameterizedConDemo(int i)
        {
            Console.WriteLine("Parameterized Constructor called is " + i);
        }

        static void Main()
        {
            ParameterizedConDemo num = new ParameterizedConDemo(10);
        }
    }
}
