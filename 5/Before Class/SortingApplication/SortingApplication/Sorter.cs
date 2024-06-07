using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    internal class Sorter
    {
        public static void SortByGrade(DataBase dataBase)
        {
            for (int i = 0; i < dataBase.grades.Length - 1; i++)
                for (int j = 0; j < dataBase.grades.Length - i - 1; j++)
                {
                    if (dataBase.grades[j] > dataBase.grades[j + 1])
                    {
                        SwapFloat(ref dataBase.grades[j], ref dataBase.grades[j + 1]);
                        SwapString(ref dataBase.names[j], ref dataBase.names[j + 1]);
                    }

                }

            void SwapFloat(ref float a, ref float b)
            {
                float tmp = a;
                a = b;
                b = tmp;
            }

            void SwapString(ref string a, ref string b)
            {
                string tmp = a;
                a = b;
                b = tmp;
            }
        }


        public static void SortByNames(DataBase dataBase)
        {
            for (int i = 0; i < dataBase.grades.Length - 1; i++)
                for (int j = 0; j < dataBase.grades.Length - i - 1; j++)
                {
                    if (String.Compare(dataBase.names[j], dataBase.names[j + 1]) > 0)
                    {
                        SwapFloat(ref dataBase.grades[j], ref dataBase.grades[j + 1]);
                        SwapString(ref dataBase.names[j], ref dataBase.names[j + 1]);
                    }

                }

            void SwapFloat(ref float a, ref float b)
            {
                float tmp = a;
                a = b;
                b = tmp;
            }

            void SwapString(ref string a, ref string b)
            {
                string tmp = a;
                a = b;
                b = tmp;
            }
        }

    }



}
