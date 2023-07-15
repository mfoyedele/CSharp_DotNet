using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OverloadMethodProject
{
    internal class ParentClass
    {
        public virtual void Test1()
        {
            Console.WriteLine("Method Test1 from parent class.");
        }
        public void Test2()
        {
            Console.WriteLine("Method Test2 from parent class.");
        }
    }

    internal class ChildClass : ParentClass
    {
        public override void Test1() //Method Overriding
        {
            Console.WriteLine("Method Test1 from child class.");
        }
        public new void Test2() //Method Hiding/Shadowing
        {
            Console.WriteLine("Method Test2 from child class.");
        }
        public void ParentTest1()
        {
            base.Test1();
        }
        public void ParentTest2()
        {
            base.Test2();
        }
        static void Main()
        {
            //ParentClass p = new ParentClass();
            //p.Test1();
            //p.Test2();
           
            //ChildClass c = new ChildClass();
            //c.Test1();
            //c.Test2();
            //c.ParentTest1();
            //c.ParentTest2();

            ChildClass c = new ChildClass(); //c is instance of child class
            ParentClass p = c; //p is a reference of parennt class created by using child's instance

            p.Test1();
            p.Test2();
            Console.ReadLine();
        }
    }
}
