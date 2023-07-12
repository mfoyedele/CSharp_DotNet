using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    internal class Class2 : Class1
    {
        Class2(int m) : base(m)
        {
            Console.WriteLine("Class2 consctructor is called" + " " + m);
        }
        public void Test3()
        {
            Console.WriteLine("Method 3");
        }
        static void Main(string[] args)
        {
            Class1 p; // p is a variable of class1
            Class2 c = new Class2(40); // c is instance of class 2
            p = c; // p is a reference of parent class created by using child class instance
            p.Test1();
            p.Test2();
            //Class2 c = new Class2();
            //c.Test1();
            //c.Test2();
            //c.Test3();
            Object obj = new Object();
            Console.WriteLine(obj.GetType());
            Class1 d = new Class1(20);
            Console.WriteLine(d.GetType());
            Class2 e = new Class2(40);
            Console.WriteLine(e.GetType());
            Console.ReadLine();
        }
    }
}
