using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Inheritance
{
    // Basic object creation ordering
    class Inheritance_Ctor                  // Base class
    { 
        public Inheritance_Ctor()
        {
            Console.WriteLine("Base Class Ctor");
        }
    }

    class Child : Inheritance_Ctor // Child class
    {
        public Child()
        {
            Console.WriteLine("Child Class Ctor");
            Console.WriteLine("****************");
        }
    }

    class Manohar
    {
        public Manohar()
        {
            Console.WriteLine("Manohar is Base Class");
        }
    }

    class Ravi : Manohar
    {
        public Ravi()
        {
            Console.WriteLine("Ravi is Child Class");
        }
    }
}
