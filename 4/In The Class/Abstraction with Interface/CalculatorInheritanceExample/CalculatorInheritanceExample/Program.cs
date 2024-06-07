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

            //Object[] list_class = new object[5];
            //list_class[0] = 12;
            //list_class[1] = 13.4;
            //list_class[2] = "Nima haji";
            //list_class[3] = 'e';
            //list_class[4] = true;
            //foreach (Object obj in list_class)
            //{
            //    Console.WriteLine(obj);
            //}

            //FourOperationCalculator calc_ali;

            //calc_ali = new SuperAdvancedCalculator();

            //calc_ali = new FourOperationCalculator();

            //calc_ali = new AdvancedCalculator();

            //calc_ali = null;




            //IAdvancedCalculator[] calcKiarash = new IAdvancedCalculator[5];

            //calcKiarash[0] = new AdvancedCalculator();

            //calcKiarash[1] = new SuperAdvancedCalculator();

            FourOperationCalculator Calculator = new FourOperationCalculator();
            try
            {
                Calculator.Division();
            }
            catch (Exception except) 
            {
                Console.WriteLine(except.Message);
            }


            Console.ReadKey();
        }
    }
}
