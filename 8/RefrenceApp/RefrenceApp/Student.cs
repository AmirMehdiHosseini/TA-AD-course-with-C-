using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrenceApp
{
    internal class Student
    {
        public float GPA { get; set; }
        public String Name { get; set; }
      //  public String ID { get; set; }
        

        public Student(float GPA, string Name) //, string Name, string Id)
        {
            this.GPA = GPA;
            this.Name = Name;
       //     this.ID = Id;
        }

        public Student ShallowCopy()
        {
            return (Student) this.MemberwiseClone();
        }




        public Student DeepCopy()
        {
            Student student = (Student)this.MemberwiseClone();
            student.Name = String.Copy(Name);
            return student;
        }
    }
}
