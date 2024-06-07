using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrenceApp
{
    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int IdNumber)
        {
            this.IdNumber = IdNumber;
        }
    }

    public class Person
    {
        public int Age;
        public string Name;
        public IdInfo ID;

        public Person(int age, string name, IdInfo iD)
        {
            Age = age;
            Name = name;
            ID = iD;
        }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person other = (Person) this.MemberwiseClone();
            IdInfo Id = new IdInfo(ID.IdNumber);
            other.ID = Id;
            other.Name = String.Copy(Name);
            return other;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            IdInfo IdGhadamian = new IdInfo(40288836);
            Person amirGh = new Person(20, "Amir Mohammad Ghadamian", IdGhadamian);
            Person aliGhasemi = amirGh.DeepCopy();
            
            
            
            IdInfo IdQasemi = new IdInfo(40212543);
            aliGhasemi.ID = IdQasemi;
            Console.WriteLine(aliGhasemi.ID == amirGh.ID);
            Console.WriteLine(aliGhasemi.ID.IdNumber);





            //Student javad = new Student(15, "javad abedi");
            //Student mohammadReza = javad.DeepCopy();


            //mohammadReza.Name = "Ali";
            //Console.WriteLine(mohammadReza.Name == javad.Name);
            Console.ReadKey();
        }
    }
}
