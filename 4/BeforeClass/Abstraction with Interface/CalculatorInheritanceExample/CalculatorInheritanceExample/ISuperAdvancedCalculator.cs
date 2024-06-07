using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInheritanceExample
{
    internal interface ISuperAdvancedCalculator:IAdvancedCalculator
    {
        double Asin();
        double Acos();
        double Atan();
        double Acot();
    }
}
