using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFigures
{
    internal class Rectangle
    {
        protected float length;
        protected float width;

        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
        }

        public Rectangle(float width) :this(width,width)
        {

        }


        public float Area() => length*width;
        public float Environment() => 2*(length+width);

    }
}
