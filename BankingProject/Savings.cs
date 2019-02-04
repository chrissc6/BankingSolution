using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Savings : Account, IAccount //inheritance of account class, and implements the iprintable interface
    {
        //data---
        private decimal IntRate { get; set; } = 0.01M;

        //methods---
        public decimal GetIntRate()
        {
            return IntRate;
        }

        public void SetIntRate(decimal NewIntRate)
        {
            IntRate = NewIntRate;
        }

        public void PayInterest()
        {
            var IntToBePaid = GetBalance() * GetIntRate();
            Deposit(IntToBePaid);
        }

        public override string Print()
        {
            return base.Print() + $" Intrest Rate = {IntRate}";
        }

        //create constructors---
        public Savings(String NewDescription) : base(NewDescription)
        {
            SetIntRate(IntRate);
        }

        public Savings() : this(null)
        { }
    }
}