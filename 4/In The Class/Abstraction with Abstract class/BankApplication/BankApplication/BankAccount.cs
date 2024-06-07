using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class BankAccount: BaseAccount
    {
        public List<string> Transactions { get; set; }
        public BankAccount (string AccountID): base(AccountID) 
        {
            Transactions = new List<string>();
        }

        public override void Deposit(float amount)
        {
            money += amount;
            Transactions.Add($"Deposit: {amount}");    
        }

        public override void Withdraw(float amount)
        {
            if (money < amount ) 
            {
                Console.WriteLine("You don't have enough noney.");
            }
            else
            {
                money -= amount;
                Transactions.Add($"Withdraw: {amount}");
            }
        }
    }
}
