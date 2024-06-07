using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFigures
{
    internal class Circle
    {
        private float radius;
        public float Radius
        {
            get { return radius; }
            set 
            { 
                if (value < 0)
                {
                    value = Math.Abs(value);
                }
                radius = value;
            }
        }
        public Circle(float radius)
        {
            this.Radius = radius;
        }
    }
}
