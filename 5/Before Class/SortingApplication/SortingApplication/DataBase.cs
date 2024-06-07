using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    internal class DataBase
    {
        public float[] grades;
        public string[] names;

        public string GetData()
        {
            string data = "";
            for (int i = 0; i < names.Length; i++)
                data += names[i] + " "+ grades[i] + "\n";
            return data;
        }

    }


}
