using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace CarSpace
{
    class Car
    {
       public void Engine()
        {
            Console.WriteLine("Engine Working...!");
        }

        public void AC()
        {
            Console.WriteLine("AC Working...!");
            Console.WriteLine("********************");

        }
    }

    class Tata : Car
    {
       public void Nexon()
        {
            Console.WriteLine("Tata Nexon");
        }
        
    }

    class Honda : Car
    {
        public void City()
        {
            Console.WriteLine("Honda City");
        }

    }

    class KIA : Car
    {
        public void Electro()
        {
            Console.WriteLine("KIA Electro");
        }
    }

    class Electric : KIA                // Multi-Level Inheritance
    {
        public void Battery()
        {
            Console.WriteLine("Battery Working");
        }
    }
}
