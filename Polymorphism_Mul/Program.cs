namespace Polymorphism_Mul
{
    class Demo
    {
        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Mul(int a, byte b)
        {
            return a * b;
        }
        public int Mul(double a, double b, double c)
        {
            return (int)a * (int)b * (int)c;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Demo d = new Demo();
            byte b = 5;

            Console.WriteLine(d.Mul(2 , 9));
            Console.WriteLine(d.Mul(2 , b));
            Console.WriteLine(d.Mul(2,7,6));

            // 4/2 => 2 | 8/2 => 4 | 10/0 => infinite (a,b) -> b=0 -> msg -> can't divide by zero return 0
        }
    }
}
