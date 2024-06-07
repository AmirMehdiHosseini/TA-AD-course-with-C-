using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    internal class DataBase
    {
        public string[] Names;

        public string GetNames()
        {
            string result = String.Empty ;
            for (int i = 0; i < Names.Length; i++)
            {
                result += Names[i] + "\n";
            }
            return result;
        }
    }
}
