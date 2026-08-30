using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    // virtual & override keyword 
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Making sound..!");
        }
    }

    class Dog : Animal
    {
    public override void MakeSound()
        {
            Console.WriteLine("Barking");
        }
    }
}
