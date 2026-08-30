using AnimalSpace;
using CarSpace;


namespace Inheritance
{
    
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


            Car car = new Car();
            car.FolderStructure();
        }
    }
}
