using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMethodProject
{
    internal class LoadParent
    {
        public void Show()
        {
            Console.WriteLine("Parent's Show Method is Callled.");
        }
        public virtual void Test() //Overridable
        {
            Console.WriteLine("Parent's Test Method is Called.");
        }
    }

    internal class LoadChild : LoadParent
    {
        //Overloading parent's Show method in child class
        public void Show(int i)
        {
            Console.WriteLine("Child's Show Method is Called.");
        }
        //Overriding parent's Test method in child class
        public override void Test() //Overriding
        {
            Console.WriteLine("Child's Test Method is Called.");
        }
        static void Main(string[] args) 
        {
            LoadChild c = new LoadChild();
            c.Show();
            c.Show(10);
            c.Test();

            Console.ReadLine();
        }

    }
}
