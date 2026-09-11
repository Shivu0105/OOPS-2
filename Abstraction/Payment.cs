using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public abstract class Payment                       // 50% abstraction
    {
        public abstract void Pay(decimal amount);        // abstract mtd
        public virtual void Refund(decimal amount)        // concrete method
        {
            amount = Convert.ToDecimal(amount);
            amount = amount/100;
            Console.WriteLine($"Refund {amount} using Generic Payment");
        }

    }

    public class CreditCardPayment : Payment 
    {
        public override void Pay(decimal amount)
        {
            if (amount <= 100)
            {
                Console.WriteLine($"Amt Rs{amount} not accepted by Credit card it should be greater than 100.. Thank you.!");
            }
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
