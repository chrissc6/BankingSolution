using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var acct1 = new Account("Test Checking");
            acct1.Print();
            acct1.Deposit(1000);
            acct1.Print();
            acct1.Withdraw(60);
            acct1.Print();
        }
    }
}
