using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInheritanceExample
{
    internal class SuperAdvancedCalculator: AdvancedCalculator ,ISuperAdvancedCalculator
    {

        public double Asin()
        {
            ReadOperand();
            return Math.Asin(Operand1) * 180 / Math.PI;
        }
        public double Acos()
        {
            ReadOperand();
            return Math.Acos(Operand1) * 180 / Math.PI;
        }

        public double Atan()
        {
            ReadOperand();
            return Math.Atan(Operand1) * 180 / Math.PI;
        }
        public double Acot()
        {
            double radian = Math.PI / 2 - Atan();
            return radian * 180 / Math.PI;
        }
    }
}
