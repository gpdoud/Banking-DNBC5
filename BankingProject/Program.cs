using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject {
    class Program {
        static void TestMethod() {

        }
        static void Main(string[] args) {

            var sav1 = new Savings();
            sav1.SetDescription("Savings");
            sav1.Deposit(1500);
            sav1.Withdraw(500);
            sav1.PayInterest();
            sav1.Print();

            var sav2 = new Savings("From Savings Account");
            sav2.Deposit(1000);
            sav2.Print();

            var sav3 = new Savings();
            sav3.SetDescription("To Savings Account");
            sav3.Deposit(100);
            sav3.Print();

            sav2.TransferTo(200, sav3);
            sav2.Print();
            sav3.Print();

            sav3.TransferTo(500, sav2);
            sav2.Print();
            sav3.Print();

            var acct1 = new Account("Test Checking");
            acct1.Print();
            acct1.Deposit(1000.00);
            acct1.Print();
            acct1.Withdraw(60.00);
            acct1.Print();

            var acct2 = new Account("Test Savings");
            acct2.Print();
            acct2.Deposit(-100);
            acct2.Print();
            acct2.Withdraw(-200);
            acct2.Print();
            acct2.Withdraw(100);
            acct2.Print();

            var acct3 = new Account();
            acct3.Print();

        }
    }
}
