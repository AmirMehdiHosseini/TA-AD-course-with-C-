using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoFiguresApp
{
    internal class Rectangle
    {
        private float _length;
        private float _width;

        public Rectangle(float _length, float _width)
        {
            this._length = _length;
            this._width = _width;
        }

        public float Area() => 2 * (_length + _width);
        public float Environment() => _length * _width;

    }
}
