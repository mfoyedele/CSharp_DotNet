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
        public void Test()
        {
            Console.WriteLine("Parent's Test Method is Called.");
        }
    }

    internal class LoadChild : LoadParent
    {
        public void Show(int i)
        {
            Console.WriteLine("Child's Show Method is Called.");
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
