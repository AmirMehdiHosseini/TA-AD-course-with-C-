using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInheritanceExample
{
    internal class AgeLimitExeption: Exception
    {


        public AgeLimitExeption(string message, int age): base (message)
        {

        }
    }
}
