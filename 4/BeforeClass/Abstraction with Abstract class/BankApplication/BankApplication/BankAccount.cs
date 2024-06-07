using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal abstract class BankAccount
    {
        public string AccountNumber { get; private set; }
        public float Balance { get; protected set; }
        public BankAccount(string accountNumber)
        {
            this.AccountNumber = accountNumber;
        }
        public BankAccount()
        {
            
        }
        public virtual void Deposit(float amount) { Console.WriteLine("dfds");  }
        public virtual void Withdraw(float amount) { }
    }
}
