using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterCounterProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LetterCounter lt = new LetterCounter("D:\\Education\\4\\حل تمرین\\سی شارپ\\7\\Letters.txt");
            lt.Count(50);
            lt.Show();
            Console.ReadKey();

        }
    }
}
