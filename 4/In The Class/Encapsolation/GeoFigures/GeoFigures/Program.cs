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
            Rectangle rectNima = new Rectangle(5, 7);
            Console.WriteLine(rectNima.Area());
            Rectangle rectHesam = new Rectangle(12);
            Console.WriteLine(rectHesam.Area());
            Console.ReadKey();
        }
    }
}
