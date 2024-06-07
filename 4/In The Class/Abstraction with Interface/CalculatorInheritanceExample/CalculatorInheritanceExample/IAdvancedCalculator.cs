using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInheritanceExample
{
    internal interface IAdvancedCalculator: IFourOperationCalculator
    {
        double Sin();
        double Cos();
        double Tan();
        double Cot();
    }
}
