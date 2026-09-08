namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Payment P1 = new CreditCardPayment();
            P1.Pay(10000);
            Console.WriteLine();

            Payment P2 = new UPIPayment();
            P2.Pay(500);
            Console.WriteLine();

            Payment P3 = new NetBanking();
            P3.Pay(50000);
            Console.WriteLine();

            Payment P4 = new ByCash();
            P4.Pay(300);
        }
    }
}
