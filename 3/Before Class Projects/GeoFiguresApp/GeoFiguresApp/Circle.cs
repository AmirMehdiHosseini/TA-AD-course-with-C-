using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFiguresApp
{
    internal class Circle
    {
        private float _radius;
        public float Radius
        {
            private get { return _radius; }
            set
            {
                while (value <= 0)
                {
                    Console.WriteLine("you are giving a negative value, you should give a positive one: ");
                    value = float.Parse(Console.ReadLine());
                }
                _radius = value;
            }
        }

        private const float pi = 3.14F;
        public Circle(float Radius)
        {
            this.Radius = Radius;
        }

        public float environment() => Radius * pi * 2;
        public float area() => Radius * Radius * pi;
    }
}
