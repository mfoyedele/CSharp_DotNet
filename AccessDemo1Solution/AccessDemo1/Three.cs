﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    // Case 3: Consuming members of a class from non-child class of same project
    internal class Three
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test2(); p.Test4(); p.Test5();
            Console.ReadLine();
        }
    }
}
