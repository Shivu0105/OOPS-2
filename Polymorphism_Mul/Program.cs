namespace Polymorphism_Mul
{
    class Demo
    {
        public int Mul(int a, int b)
        {
            return a * b;
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            Demo d = new Demo();
            Console.WriteLine(d.Mul(2 , 5));
        }
    }
}
