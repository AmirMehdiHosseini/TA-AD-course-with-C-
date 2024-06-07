using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    internal class ConnectToDatabase
    {
        public static DataBase ReadFromFile(string FileAddress)
        {
            DataBase dataBase = new DataBase();
            string[] txt = File.ReadAllLines(FileAddress);
            dataBase.names = new string[txt.Length];
            dataBase.grades = new float[txt.Length];
            for (int i = 0; i < txt.Length; i++)
            {
                dataBase.names[i] = txt[i].Split()[0];
                dataBase.grades[i] = float.Parse(txt[i].Split()[1]);
            }
            return dataBase;
        }
        public static void WriteToFile(DataBase dataBase,string fileName)
        {
            using (StreamWriter w = new StreamWriter(fileName))
            {
                w.WriteLine(dataBase.GetData());
            }
        }
    }
}
