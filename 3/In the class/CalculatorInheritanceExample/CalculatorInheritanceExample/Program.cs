using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FourOperationCalculator calculatorArezoo = new FourOperationCalculator();
            AdvancedCalculator calculatorKhatere = new AdvancedCalculator();
            SuperAdvancedCalculator calculatorAli = new SuperAdvancedCalculator();
            Console.WriteLine(calculatorAli.Acot());
            Console.ReadKey();
        }
    }
}
