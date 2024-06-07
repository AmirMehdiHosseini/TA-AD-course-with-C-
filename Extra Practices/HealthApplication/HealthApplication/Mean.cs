using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApplication
{
    internal class Mean
    {
        private const string AGE = "age";
        private const string HEIGHT = "height";
        private const string WEIGHT = "weight";


        public static float calculateMean(Class _Class ,string switchArgument)
        {
            float mean = 0;
            switch (switchArgument)
            {
                case AGE:
                    foreach (Student student in _Class._students)
                    {
                        mean += student._age;
                    }
                    break;

                case HEIGHT:
                    foreach (Student student in _Class._students)
                    {
                        mean += student._weight;
                    }
                    break;

                case WEIGHT:
                    foreach (Student student in _Class._students)
                    {
                        mean += student._height;
                    }
                    break;
            }
            return mean / _Class._students.Length;
        }
    }
}
