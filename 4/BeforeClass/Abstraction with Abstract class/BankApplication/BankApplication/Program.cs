using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account("fsfsdf");
            acc.Deposit(450);
            acc.Deposit(464650);
            acc.Withdraw(4640);
            foreach (var item in acc.Transactions) {
            Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
