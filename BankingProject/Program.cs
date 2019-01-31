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

            //creation of checking accounts---
            var chk1 = new Checking("My First Checking Acct");
            Console.WriteLine(chk1.Print());

            var chk2 = new Checking();
            chk2.Deposit(500);
            Console.WriteLine(chk2.Print());

            //creation of savings accounts---
            var sav1 = new Savings();
            sav1.SetDescription("Savings");
            sav1.Deposit(1500);
            sav1.Withdraw(500);
            sav1.PayInterest();
            Console.WriteLine(sav1.Print());

            var sav2 = new Savings("From Saving Account");
            sav2.Deposit(1000);
            Console.WriteLine(sav2.Print());

            var sav3 = new Savings("To Savings Account");
            sav3.Deposit(100);
            Console.WriteLine(sav3.Print());

            //creation of a collection---
            List<Account> accounts = new List<Account>();
            accounts.Add(chk1);
            accounts.Add(chk2);
            accounts.Add(sav1);
            accounts.Add(sav2);
            accounts.Add(sav3);

            foreach (var account in accounts)
            {
                Console.WriteLine(account.Print());
            }

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
