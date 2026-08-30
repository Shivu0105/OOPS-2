using AnimalSpace;
using CarSpace;


namespace Inheritance
{
    
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Leaning Inheritance!");
            //Console.WriteLine("Welcome Boss!");
            

            //// class Animal
            //Dog d = new Dog();
            //d.Sleep();                          // Inherited methods
            //d.Running();                        // Inherited methods
            //d.Bark();                           // Non-inherited methods

            //Cat c = new Cat();
            //c.Sleep();
            //c.Running();
            //c.Meaw();

            //Tiger t = new Tiger();
            //t.Sleep();
            //t.Running();
            //t.Roar();


            // Class Car
            Tata ta = new Tata();
            ta.Nexon(); 
            ta.Engine();
            ta.AC();

            Honda h = new Honda();
            h.City();
            h.Engine();
            h.AC();
            

            KIA k = new KIA();
            k.Electro(); 
            k.Engine();
            k.AC();
            


        }
    }
}
