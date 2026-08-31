using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    // virtual & override keyword 
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Animal Making sound..!");
        }
    }

    class Dog : Animal
    {
    public override void MakeSound()
        {
            Console.WriteLine("Barking");
        }
    }

    // Bank class
    class ReserveBank
    {
        public void MainBank()
        {
            Console.WriteLine("MainBank Approved this Bank");
        }

        public void Fund()
        {
            Console.WriteLine("Bank have Funds");
        }
    }

    class HDFC : ReserveBank
    {
        public void Money()
        {
            Console.WriteLine("Bank have Money");
        }
    }

    class Axis : ReserveBank
    {
        public void Loan()
        {
            Console.WriteLine("Bank will give Loan");
        }
    }
}
