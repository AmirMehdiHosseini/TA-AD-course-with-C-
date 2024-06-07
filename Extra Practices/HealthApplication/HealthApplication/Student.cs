using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApplication
{
    internal class Student
    {
        public float _age { get; set; }
        public float _height { get; set; }
        public float _weight { get; set; }

        public Student (float age, float height, float weight)
        {
            _age = age;
            _height = height;
            _weight = weight;
        }
    }
}
