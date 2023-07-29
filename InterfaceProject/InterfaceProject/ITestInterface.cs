﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal interface ITestInterface1
    {
        void Add(int a, int b);
    }
    interface ITestInterface2 : ITestInterface1
    {
        void Sub(int a, int b);
    }
    class ImplementationClass : ITestInterface2
    {
        public void Add(int a, int b) 
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b) 
        {
            Console.WriteLine(a - b);
        }
    }
}
