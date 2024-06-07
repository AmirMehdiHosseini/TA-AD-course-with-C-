using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInheritanceExample
{
    internal class AdvancedCalculator: FourOperationCalculator
    {
        public double Sin()
        {
            ReadOperand();
            double radian = Operand1 * Math.PI / 180;
            return Math.Sin(radian);
        }

        public double Cos()
        {
            ReadOperand();
            double radian = Operand1 * Math.PI / 180;
            return Math.Cos(radian);
        }

        public double Tan()
        {
            ReadOperand();
            double radian = Operand1 * Math.PI / 180;
            return Math.Tan(radian);
        }

        public double Cot()
        {
            ReadOperand();
            double radian = Operand1 * Math.PI / 180;
            return Math.Cos(radian) / Math.Sin(radian);
        }


        protected void ReadOperand() 
        {
            Console.WriteLine("Please enter your operand: ");
            Operand1 = double.Parse(Console.ReadLine());
        }
    }
}
