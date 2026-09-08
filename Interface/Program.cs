namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAnimal myDog = new Dog();
            myDog.MakeSound();
            Console.WriteLine($"Dogs having {myDog.Legs} Legs");
            Console.WriteLine();

            IAnimal myCat = new Cat();
            myCat.MakeSound();
            Console.WriteLine($"Cat having {myCat.Legs} Legs");
            Console.WriteLine();

            Monkey myMonkey = new Monkey();
            myMonkey.MakeSound();
            Console.WriteLine($"Monkey having {myMonkey.Hands} Hands");
            Console.WriteLine($"Monkey having {myMonkey.Legs} Legs");

        }
    }
}
