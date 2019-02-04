using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject {
    class Account : IComparable<Account>, IAccount {

        private static int nextId = 1;

        private int Id { get; set; }
        private string Description { get; set; }
        private decimal Balance { get; set; }

        public int CompareTo(Account acct) {
            if(this.Description.Equals(acct.Description)) {
                return 0;
            }
            if(this.Description.CompareTo(acct.Description) > 0) {
                return 1;
            } else {
                return -1;
            }
        }

        public void TransferTo(decimal Amount, Account Acct) {
            var BalanceBeforeWithdraw = GetBalance();
            Withdraw(Amount);
            var BalanceAfterWithdraw = GetBalance();
            if(BalanceBeforeWithdraw == BalanceAfterWithdraw) {
                Console.WriteLine("Insufficient Funds");
                return;
            }
            Acct.Deposit(Amount);
        }

        public int GetId() {
            return Id;
        }
        public string GetDescription() {
            return Description;
        }
        public void SetDescription(string NewDescription) {
            Description = NewDescription;
        }
        public decimal GetBalance() {
            return Balance;
        }
        public void Deposit(decimal Amount) {
            if(Amount <= 0) {
                Console.WriteLine("Amount must be positive.");
            } else {
                Balance += Amount;
            }
        }
        public void Withdraw(decimal Amount) {
            if(Amount <= 0) {
                Console.WriteLine("Amount must be positive.");
                return;
            }
            if(Amount > Balance) {
                Console.WriteLine("Insufficient Funds!");
                return;
            }
            Balance -= Amount;
        }
        public virtual string Print() {
            return $"Id={Id}, Description={Description}, Balance={Balance}";
        }
        public Account(string NewDescription) {
            Id = nextId++;
            if(NewDescription == null) {
                Description = "*New Account*";
            } else {
                Description = NewDescription;
            }
            Balance = 0;
        }
        // This constructor calls the other contructor
        // and passes in a null value for NewDescription
        public Account() : this(null) {
        }
    }
}
