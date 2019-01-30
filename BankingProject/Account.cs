
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Account
    {
        //data
        private int Id { get; set; }
        private string Description { get; set; }
        private double Balance { get; set; }

        //methods
        public int GetId()
        {
            return Id;
        }

        public string GetDescription()
        {
            return Description;
        }

        public void SetDescription(string NewDescription)
        {
            Description = NewDescription;
        }

        public double GetBalance()
        {
            return Balance;
        }

        public void Deposit(double Amount)
        {
            Balance += Amount;
        }

        public void Withdraw(double Amount)
        {
            Balance -= Amount;
        }

        public void Print()
        {
            Console.WriteLine($"Id={Id}, Description={Description}, Balance={Balance}");
        }

        //create constructors

        public Account(string NewDescription)
        {
            Id = -1;
            Description = NewDescription;
            Balance = 0;
        }

        public Account()
        {
            Id = -1;
            Description = "NewAccount";
            Balance = 0;
        }
    }
}
