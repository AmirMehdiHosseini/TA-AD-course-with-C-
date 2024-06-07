using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal abstract class BaseAccount
    {
        public float money {   get; protected set; }
        public string AccountID {  get; private set; }
        public BaseAccount(string AccountID) 
        {
            this.AccountID = AccountID;
        }

        public abstract void Deposit(float amount);
        public abstract void Withdraw(float amount);
    }
}
