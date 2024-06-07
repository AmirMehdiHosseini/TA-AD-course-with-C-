using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    internal class Sorter
    {
        public static void SortByNames(DataBase dataBase)
        {
            for(int i = 0; i < dataBase.Names.Length -1 ; i++) 
                for (int j = 0; j < dataBase.Names.Length - i - 1 ; j++)
                {
                    if (String.Compare( dataBase.Names[j] , dataBase.Names[j + 1]) > 0)
                    {
                        SwapString(ref dataBase.Names[j],ref dataBase.Names[j+1]);
                    }
                }
            void SwapString(ref string a,ref string b)
            {
                string tmp = a;
                a = b;
                b = tmp;
            }

        }
    }
}
