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
            BankAccount accountFaraz = new BankAccount("faraz12345678");
            BankAccount accountNima = new BankAccount("6219-8619-4072-6390");

            accountFaraz.Deposit(1000);
            accountNima.Deposit(10580);
            accountNima.Withdraw(800);
            accountFaraz.Deposit(2000);
            accountFaraz.Withdraw(3);

            

            foreach (var transaction in accountFaraz.Transactions)
            {
                Console.WriteLine(transaction);
            }
            Console.ReadKey();
        }
    }
}
