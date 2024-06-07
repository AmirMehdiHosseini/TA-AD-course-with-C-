using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInheritanceExample
{
    internal class FourOperationCalculator: IFourOperationCalculator
    {
        protected double Operand1;
        protected double Operand2;

        public double Addition()
        {
            ReadOperands();
            return Operand1 + Operand2;
        }

        public double Subtraction() 
        {
            ReadOperands();
            return Operand1 - Operand2;
        }


        public double Multiplication()
        {
            ReadOperands();
            return Operand1 * Operand2;
        }

        public double Division()
        {
            ReadOperands();
            return Operand1 / Operand2;
        }
        protected void ReadOperands()
        {
            Console.WriteLine("Please enter first operand: ");
            Operand1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second operand: ");
            Operand2 = double.Parse(Console.ReadLine());
        }
    }
}
