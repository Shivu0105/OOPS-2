using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface IAnimal
    {
        void MakeSound();  // Every animal must have a method called MakeSound().
        int Legs { get; set; }//Every animal must also have a property called Legs.
    }                          // (get;) -> Means you can read the value.
                               // (set;) -> Means you can change the value.

    public class Dog : IAnimal  // Dog implements the interface.
    {
        public int Legs { get; set; } = 4;

        public void MakeSound()  // Dog now provides its own version of MakeSound().
        {
            Console.WriteLine("Dog Bark!"); // Whenever Dog makes a sound:
        }
    }

    public class Cat : IAnimal
    {
        public int Legs { get; set; } = 4;
        public void MakeSound()
        {
            Console.WriteLine("Cat Meow!");
        }
    }

    public class Monkey : IAnimal
    {
        public int Legs { get; set; } = 2;
        public int Hands { get; set; } = 2;

        public void MakeSound()
        {
            Console.WriteLine("Monkey Screaming!");
        }
    }
}
