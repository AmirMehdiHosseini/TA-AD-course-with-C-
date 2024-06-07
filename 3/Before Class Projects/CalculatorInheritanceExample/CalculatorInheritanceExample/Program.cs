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
            SuperAdvanedCalculator calculator = new SuperAdvanedCalculator();
            Console.WriteLine(calculator.Acot());
            Console.ReadKey();
        }
    }
}
