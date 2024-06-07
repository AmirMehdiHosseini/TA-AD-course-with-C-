using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class Account : BankAccount
    {
        public List<string> Transactions { get; private set; }

        public Account(string accountNumber) : base(accountNumber) 
        {
            Transactions = new List<string>();
        }
        public override void Deposit(float amount)
        {
            Balance += amount;
            Transactions.Add($"Deposit: {amount}");
        }

        public override void Withdraw(float amount)
        {
            if (Balance - amount > 0)
            {
                Balance -= amount;
                Transactions.Add($"Withdraw: -{amount}");
            }
            else
            {
                Console.WriteLine("There is not enough money in your account.");
            }
        }
    }
}
