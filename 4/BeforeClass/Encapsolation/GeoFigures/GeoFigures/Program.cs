using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Radius = -43;
            Console.WriteLine(circle.Radius);
            Console.ReadKey();
        }
    }
}
