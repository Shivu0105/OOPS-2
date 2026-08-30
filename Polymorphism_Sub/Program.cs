namespace Polymorphism_Sub
{
    class Demo
    {
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Sub(int x, int y, int z)
        {
            return x - y - z;
        }

        public int Sub(double x, double y)
        {
            return (int)x - (int)y;
        }

        public int Sub(int x, byte y)
        {
            return x - y;
        }
    }
    
    internal class program
    { 

        static void Main(string[] args)
        {

            Demo d = new Demo();
            byte b = 5;

            Console.WriteLine(d.Sub(9, 5));
            Console.WriteLine(d.Sub(3, 1));
            Console.WriteLine(d.Sub(9, 5, 3));
            Console.WriteLine(d.Sub(7, b));

        }
    }
}