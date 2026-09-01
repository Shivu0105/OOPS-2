using AccessModifiersBasics;

namespace Polymorphism_Div
{
    class Demo
    {
        public int Div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Can't divide by zero");
                return 0;
            }
            return a / b;
        }

        public int Div(int a, int b, int c)
        {
            if (b == 0)
            {
                Console.WriteLine("Can't divide by zero");
                return 0;
            }
            return a / b / c;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();

            Console.WriteLine("Enter a Value");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter b Value");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter c Value");
            int c = Convert.ToInt32(Console.ReadLine());

            int result = d.Div(a, b);
            Console.WriteLine("Result " + result);

            int final = d.Div(a, b, c);
            Console.WriteLine("Result " + final);


            // public accessible outside assembly
            //AccessModifiers access = new AccessModifiers();
            //Console.WriteLine(access.Name);

        }
    }
}
