namespace Inheritance
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

    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Leaning Inheritance!");
            Console.WriteLine("Welcome Boss!");
            
            Dog d = new Dog();
            d.Sleep();                          // Inherited methods
            d.Running();                        // Inherited methods
            d.Bark();                           // Non-inherited methods

            Cat c = new Cat();
            c.Sleep();
            c.Running();
            c.Meaw();

            Tiger t = new Tiger();
            t.Sleep();
            t.Running();
            t.Roar();
            
        }
    }
}
