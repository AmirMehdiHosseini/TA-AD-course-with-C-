using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    internal class ConnectToFile
    {

        public static DataBase ReadFromFile(string filePath)
        {
            DataBase dataBase = new DataBase();
            dataBase.Names = File.ReadAllLines(filePath);
            return dataBase;
        }

        public static void WriteToFile(DataBase dataBase, string filePath)
        {
            using(StreamWriter w = new StreamWriter(filePath))
            {
                w.WriteLine(dataBase.GetNames());
            }
        }

    }
}
