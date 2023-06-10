using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DemoProject
{
    internal class ParameterizedConDemo
    {
       int x;
        public ParameterizedConDemo(int i)
        {
            x = i;

            Console.WriteLine("Parameterized Constructor called is " + i);
        }

        public void Display()
        {
            Console.WriteLine("Value of x is " + x);
        }

        static void Main()
        {
            ParameterizedConDemo num1 = new ParameterizedConDemo(10);
            ParameterizedConDemo num2 = new ParameterizedConDemo(20);

            num1.Display();
            num2.Display();
            Console.ReadLine();
        }
    }
}
