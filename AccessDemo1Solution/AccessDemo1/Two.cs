﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo1
{
    // Case 2: Consuming members of a class from child class of same project
    class Two: Program
    {
        static void Main(string[] args)
        {
            Two t = new Two();
            t.Test2(); t.Test3(); t.Test4(); t.Test5();
            Console.ReadLine();
        }
    }
}
