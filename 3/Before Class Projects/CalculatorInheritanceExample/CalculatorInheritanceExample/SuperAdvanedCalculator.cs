using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInheritanceExample
{
    internal class SuperAdvanedCalculator: AdvancedCalculator, ISuperAdvancedCalculator
    {
        public double Atan()
        {
            ReadOneOperand();
            return (Math.Atan(Operand1) * 180 ) / Math.PI;
        }
        public double Asin()
        {
            ReadOneOperand();
            return (Math.Asin(Operand1) * 180 ) / Math.PI;
        }
        public double Acos()
        {
            ReadOneOperand();
            return (Math.Acos(Operand1) * 180 ) / Math.PI;
        }

        public double Acot()
        {
            ReadOneOperand();
            double arcTan = (Math.PI / 2) - Math.Atan(Operand1);
            return (arcTan * 180) / Math.PI;
        }
    }
}
