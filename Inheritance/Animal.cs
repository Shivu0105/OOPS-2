using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalSpace
{
    class Animal                        // Parent/Base/Super Class
    {
        public void Sleep()
        {
            Console.WriteLine("Sleeping");
        }
        public void Running()
        {
            Console.WriteLine("Running");
        }
    }

    class Dog : Animal                  // Child/Sub Class
    {
        public void Bark()
        {
            Console.WriteLine("bhow bhow...");
        }
    }
    class Cat : Animal
    {
        public void Meaw()
        {
            Console.WriteLine("Meaw...");
        }
    }

    class Tiger : Animal
    {
        public void Roar()
        {
            Console.WriteLine("Roar...");
        }
    }
}
