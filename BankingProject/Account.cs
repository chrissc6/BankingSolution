
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Account
    {
        //data---

        private static int nextId = 1;

        private int Id { get; set; }
        private string Description { get; set; }
        private double Balance { get; set; }

        //methods---
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
            if(Amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
            else
            {
                Balance += Amount;
            }
        }

        public void Withdraw(double Amount)
        {
            if (Amount <= 0)
            {
                Console.WriteLine("Withdrawl amount must be positive.");
                return;
            }

            if(Amount > Balance)
            {
                Console.WriteLine("Insufficient funds for withdraw.");
                return;
            }

            else
            {
                Balance -= Amount;
            }




            //if(Amount > Balance || Amount <= 0)
            //{
            //    if (Amount > Balance)
            //    {
            //        Console.WriteLine("Insufficient funds.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Withdrawl amount must be positive.");
            //    }
            //}
            //else
            //{
            //    Balance -= Amount;
            //}
        }

        public virtual string Print()
        {
            return $"Id={Id}, Description={Description}, Balance={Balance}";
        }

        public void TransferTo(double Amount, Account Acct)
        {
            var BalanceBeforeWithdraw = GetBalance();
            Withdraw(Amount);
            var BalanceAfterWithdraw = GetBalance();
            if(BalanceBeforeWithdraw == BalanceAfterWithdraw)
            {
                Console.WriteLine("Insufficient funds for transfer");
                return;
            }
            Acct.Deposit(Amount);
        }

        //create constructors---

        public Account(string NewDescription)
        {
            Id = nextId++;
            if(NewDescription == null)
            {
                Description = "NewAccount";
            }
            else
            {
                Description = NewDescription;
            }
            Balance = 0;
        }  //SetDescription(NewDescription);

        public Account() : this(null) //This constructor calls the other constructor, passes null value
        {
           
        }
    }
}
