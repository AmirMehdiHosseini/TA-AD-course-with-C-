using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorInheritanceExample
{
    internal class FourOperationsCalculator: IFourOperationCalculator
    {
        protected float Operand1;
        protected float Operand2;


        public float Addition()
        {
            ReadOperamnds();
            return Operand1 + Operand2;
        }

        public float Subtraction()
        {
            ReadOperamnds();
            return Operand1 - Operand2;
        }


        public float Multiplication()
        {
            ReadOperamnds();
            return Operand1 * Operand2;
        }

        public float Division()
        {
            ReadOperamnds();
            
            while (Operand2 == 0)
            {
                
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please give me your second operand value besides zero: ");
                Console.ResetColor();
                Operand2 = float.Parse(Console.ReadLine());
            }
            
            return Operand1 / Operand2;
        }



        protected void ReadOperamnds()
        {
            Console.WriteLine("Please give me your first operand value: ");
            Operand1 = float.Parse( Console.ReadLine());
           
            Console.WriteLine("Please give me your second operand value: ");
            Operand2 = float.Parse(Console.ReadLine());
        }

    }
}
