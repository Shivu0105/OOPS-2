using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public abstract class Payment
    {
        public abstract void Pay(decimal amount);
    }

    public class CreditCardPayment : Payment
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid Rs{amount} using Credit Card.");
        }
    }

    public class UPIPayment : Payment
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid Rs{amount} using UPI.");
        }
    }

    public class NetBanking : Payment
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid Rs{amount} using Netbanking.");
        }
    }

    public class ByCash : Payment
    {
        public override void Pay(decimal amount)
        {
            Console.WriteLine($"Paid Rs{amount} using by Cash.");
        }
    }
}
