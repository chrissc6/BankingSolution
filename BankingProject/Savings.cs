using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Savings : Account //inheritance of account class
    {
        //data---
        private double IntRate { get; set; } = 0.01;

        //methods---
        public double GetIntRate()
        {
            return IntRate;
        }

        public void SetIntRate(double NewIntRate)
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