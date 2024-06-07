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
            var dataBase = ConnectToDatabase.ReadFromFile("D:\\Education\\4\\حل تمرین\\سی شارپ\\5\\Before Class\\SortingApplication\\DataBase.txt");
            Console.WriteLine( dataBase.GetData());
            Sorter.SortByGrade(dataBase);
            ConnectToDatabase.WriteToFile(dataBase,"D:\\Education\\4\\حل تمرین\\سی شارپ\\5\\Before Class\\SortingApplication\\SortedByGrades.txt");
            Console.WriteLine(dataBase.GetData());
            Sorter.SortByNames(dataBase);
            ConnectToDatabase.WriteToFile(dataBase, "D:\\Education\\4\\حل تمرین\\سی شارپ\\5\\Before Class\\SortingApplication\\SortedByNames.txt");
            Console.WriteLine(dataBase.GetData());
            Console.ReadKey();
        }
    }
}
