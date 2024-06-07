using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInheritanceExample
{
    internal class AdvancedCalculator: FourOperationsCalculator, IAdvancedCalculator
    {

        public double Sin()
        {
            ReadOneOperand();
            double radian = (Operand1 * Math.PI / 180);
            return Math.Sin(radian);
        }

        public double Cos()
        {
            ReadOneOperand();
            double radian = (Operand1 * Math.PI / 180);
            return Math.Cos(radian);
        }

        public double Tan()
        {
            ReadOneOperand();
            double radian = (Operand1 * Math.PI / 180);
            return Math.Tan(radian);
        }

        public double Cot()
        {
            ReadOneOperand();
            double radian = (Operand1 * Math.PI / 180);
            return Math.Cos(radian) / Math.Sin(radian);
        }


        protected void ReadOneOperand()
        {
            Console.WriteLine("Please give me your operand value: ");
            Operand1 = float.Parse(Console.ReadLine());
        }
    }
}
