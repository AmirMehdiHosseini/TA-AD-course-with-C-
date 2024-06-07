using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFiguresApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square circle = new Square(5);
            Console.WriteLine(circle.Environment());
            Console.ReadKey();
        }
    }
}
