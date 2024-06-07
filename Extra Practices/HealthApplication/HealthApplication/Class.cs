using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthApplication
{
    internal class Class
    {
        public Student[] _students { get; set; }

        public Class(int count)
        {
            _students = new Student[count];
        }

        public void ReadStudents()
        {
            float[] ages = new float[_students.Length];
            float[] heights = new float[_students.Length];
            float[] weights = new float[_students.Length];

            ReadFloatArray(ages);
            ReadFloatArray(heights);
            ReadFloatArray(weights);

            for (int i = 0; i < _students.Length; i++)
            {
                _students[i] = new Student(ages[i], heights[i], weights[i]);
            }
        }

        private void ReadFloatArray(float[] array) 
        {
            string[] data = Console.ReadLine().Split() ;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = float.Parse(data[i]);
            }
        }
    }
}
