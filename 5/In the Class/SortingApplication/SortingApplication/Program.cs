using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = ConnectToFile.ReadFromFile("D:\\Education\\4\\حل تمرین\\سی شارپ\\5\\In the Class\\DataBase.txt");
            Console.WriteLine(dataBase.GetNames() + "\n");
            Sorter.SortByNames(dataBase);
            Console.WriteLine(dataBase.GetNames());

            ConnectToFile.WriteToFile(dataBase, "D:\\Education\\4\\حل تمرین\\سی شارپ\\5\\In the Class\\SortedDataBase.txt");
            Console.ReadKey();
        }
    }
}
