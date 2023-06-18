using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessDemo2

    // Summary:
    // Private method: can only be called within a class
    // Internal method: cannot be called outside a project but can be called within both child and non-child class.
    // Protected method: cannot be called in a non-child class but can be called with a child class of another project.
    // Protected Internal method: cannot be called if internal and protected methods are not accessible especially in a non-child class of another project.
    // Public method: can be called anywhere.
{
    // Case 5: Consuming members of a class from non-child class of different project
    internal class Five
    {
        static void Main(string[] args)
        {
            AccessDemo1.Program p = new AccessDemo1.Program();
            p.Test5();
            Console.ReadLine();
        }
    }
}
