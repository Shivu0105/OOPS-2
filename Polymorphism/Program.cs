namespace Polymorphism
{
    class Cal
    {
        //private int num1;
        //private int num2;

        //public int Num1
        //{
        //    get {  return num1; }
        //    set { num1 = value; }
        //}

        //public int Num2
        //{
        //    get { return num2; }
        //    set { num2 = value; }
        //}

        public string Add(string a, string b)
        {
            return a + b;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(int a, int b, int c, int d, int e)
        {
            return (a + b + c + d + e);
        }

        public int Add(double a, double b)
        {
            return (int) a + (int)b; // Type Casting
        }

        public int Add(int a, byte b)
        {
            return a + b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are learnig Polymorphism");

            // 2 types of polymorphism 

            // 1st compile-time/ Method Overloading.
            // 2nd Run-time/ Method Overriding.

            Cal c = new Cal();

            byte b = 3;

            Console.WriteLine(c.Add("Hello ","Shivam"));

            Console.WriteLine(c.Add(1, 2));

            Console.WriteLine(c.Add(1, 3));

            Console.WriteLine(c.Add(1,2,3));

            Console.WriteLine(c.Add(300, b));
            
        }
    }
}
