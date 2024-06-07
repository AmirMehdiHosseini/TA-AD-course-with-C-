using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApplication
{

    internal class Program
    {
        private const string AGE = "age";
        private const string HEIGHT = "height";
        private const string WEIGHT = "weight";
        private const string A = "A";
        private const string B = "B";
        private const string SAME = "Same";
        static void Main(string[] args)
        {
            Class firstClass = new Class(int.Parse(Console.ReadLine()));
            firstClass.ReadStudents();
            Class secondClass = new Class(int.Parse(Console.ReadLine()));
            secondClass.ReadStudents();

            float firstClassAgeMean = Mean.calculateMean(firstClass, AGE);
            Console.WriteLine(firstClassAgeMean);
            Console.WriteLine(Mean.calculateMean(firstClass, WEIGHT));
            Console.WriteLine(Mean.calculateMean(firstClass, HEIGHT));

            float secondClassAgeMean = Mean.calculateMean(secondClass, AGE);
            Console.WriteLine(secondClassAgeMean);
            Console.WriteLine(Mean.calculateMean(secondClass, WEIGHT));
            Console.WriteLine(Mean.calculateMean(secondClass, HEIGHT));            


            Console.WriteLine(firstClassAgeMean == secondClassAgeMean ? SAME : firstClassAgeMean > secondClassAgeMean ? A:B);
            Console.ReadKey();
        }
    }
}
