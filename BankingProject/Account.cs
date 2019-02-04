
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Account : IComparable<Account>, IAccount //using a interface, to sort the class & print
    {
        //data---

        private static int nextId = 1;

        private int Id { get; set; }
        private string Description { get; set; }
        private decimal Balance { get; set; }

        //methods---
        public int CompareTo(Account acct) //account class is now sortable with this method
        {
            //if (this.Description == acct.Description)
            if(this.Description.Equals(acct.Description)) //better way
                return 0;
            else if (this.Description.CompareTo(acct.Description) > 0)
                return 1;
            else
                return -1;
        }

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

        public decimal GetBalance()
        {
            return Balance;
        }

        public void Deposit(decimal Amount)
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

        public void Withdraw(decimal Amount)
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

        public void TransferTo(decimal Amount, Account Acct)
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

            //var error = 0 / Balance; //bug creation
        }  //SetDescription(NewDescription);

        public Account() : this(null) //This constructor calls the other constructor, passes null value
        {
           
        }
    }
}
