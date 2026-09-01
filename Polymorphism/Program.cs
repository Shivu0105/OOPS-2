namespace Polymorphism
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are learnig Polymorphism");


            //Cal c = new Cal();

            //byte b = 3;

            //Console.WriteLine(c.Add("Hello ","Shivam"));

            //Console.WriteLine(c.Add(1, 2));

            //Console.WriteLine(c.Add(1, 3));

            //Console.WriteLine(c.Add(1,2,3));

            //Console.WriteLine(c.Add(300, b));


            // virtual & override keyword 
            Animal d = new Dog();           // Dog IS-A Animal
            d.MakeSound();


            // Bank class
            ReserveBank r = new ReserveBank();
            r.MainBank();
            r.Fund();

            HDFC h = new HDFC();
            h.MainBank();
            h.Fund();
            h.Money();

            Axis a = new Axis();
            a.MainBank();
            a.Fund();
            a.Loan();

            //Class Printer
            Printer p = new Printer();
            p.Print("Hello");
            p.Print(10);
            p.Print(10.5);
        }
    }
}
