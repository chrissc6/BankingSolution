using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Checking //not inheritance, using composition
    {
        //data---
        private Account account { get; set; }

        private int NextCheckNbr { get; set; } = 1; //different than id, because each checking acct has own checknbr

        //methods
        public int GetNextCheckNbr()
        {
            return NextCheckNbr;
        }

        public decimal GetBalance()
        {
            return account.GetBalance();
        }

        public string GetDescription()
        {
            return account.GetDescription();
        }

        public void SetDescription(string NewDescription)
        {
            account.SetDescription(NewDescription);
        }

        public void Deposit(decimal Amount)
        {
            account.Deposit(Amount);
        }

        public void Withdraw(decimal Amount)
        {
            account.Withdraw(Amount);
        }

        public string Print()
        {
            return account.Print() + $", Next Check Number = {NextCheckNbr}";
        }

        public int GetId()
        {
            return account.GetId();
        }

        //constructors---
        public Checking(string NewDescription)
        {
            account = new Account(NewDescription);
        }

        public Checking() :this(null)
        { }
    }
}
