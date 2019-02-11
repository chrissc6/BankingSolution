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
            IAccount[] accounts =
            {
                new Account("An Account"),
                new Savings("A Savings"),
                new Checking("A Checking")
            };

            try
            {
                accounts[0].Deposit(-10);
            }
            catch (DepositWithdrawTransferException ex)
            {
                Console.WriteLine("Amount must be positive");
            }

            //try
            //{
            //    accounts[0].Withdraw(100000000);
            //}
            //catch(InsufficientFundsException ex)
            //{
            //    Console.WriteLine("Insufficient funds ....");
            //}


            foreach (var account in accounts)
            {
                
                Console.WriteLine(account.Print());
            }

            Console.ReadKey();

            //Account acctx = new Account("abc");
            //Account acctxyz = new Account("xyz");
            //Account[] accounts = { acctxyz, acctx };
            //Array.Sort(accounts);
            //foreach (var account in accounts)
            //{
            //    Console.WriteLine(account.GetDescription());
            //}

            //acctx = null;
            //if(acctx != null)
            //acctx?.GetBalance(); //same as if statement, code is cleaner

            //creation of checking accounts---

            //Checking chk0 = new Checking();
            //Console.WriteLine(chk0.Print());

            //Checking chk01 = new Checking("New Checking 0");
            //Console.WriteLine(chk01.Print());
            //chk01.Deposit(300);
            //Console.WriteLine(chk01.Print());
            //chk01.Withdraw(100);
            //Console.WriteLine(chk01.Print());


            //var chk1 = new Checking("My First Checking Acct");
            //Console.WriteLine(chk1.Print());

            //var chk2 = new Checking();
            //chk2.Deposit(500);
            //Console.WriteLine(chk2.Print());

            ////creation of savings accounts---
            //var sav1 = new Savings();
            //sav1.SetDescription("Savings");
            //sav1.Deposit(1500);
            //sav1.Withdraw(500);
            //sav1.PayInterest();
            //Console.WriteLine(sav1.Print());

            //var sav2 = new Savings("From Saving Account");
            //sav2.Deposit(1000);
            //Console.WriteLine(sav2.Print());

            //var sav3 = new Savings("To Savings Account");
            //sav3.Deposit(100);
            //Console.WriteLine(sav3.Print());

            ////creation of a collection---
            //List<Account> accounts = new List<Account>();
            //accounts.Add(chk1);
            //accounts.Add(chk2);
            //accounts.Add(sav1);
            //accounts.Add(sav2);
            //accounts.Add(sav3);

            //foreach (var account in accounts)
            //{
            //    Console.WriteLine(account.Print());
            //}

            //transfer methods for savings accounts---
            //sav2.TransferTo(200, sav3);
            //Console.WriteLine(sav2.Print());
            //Console.WriteLine(sav3.Print());

            //sav3.TransferTo(500, sav2);
            //Console.WriteLine(sav2.Print());
            //Console.WriteLine(sav3.Print());

            //creation of new accouts---
            //var acct1 = new Account("Test Checking");
            //Console.WriteLine(acct1.Print());
            //acct1.Deposit(1000);
            //Console.WriteLine(acct1.Print());
            //acct1.Withdraw(60);
            //Console.WriteLine(acct1.Print());

            //var acct2 = new Account("Test Savings");
            //Console.WriteLine(acct2.Print());
            //acct2.Deposit(-200);
            //Console.WriteLine(acct2.Print());
            //acct2.Withdraw(-200);
            //Console.WriteLine(acct2.Print());
            //acct2.Withdraw(200);
            //Console.WriteLine(acct2.Print());

            //var acct3 = new Account();
            //Console.WriteLine(acct3.Print());
        }
    }
}
