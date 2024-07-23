using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPS_Concept
{

    internal class Program 
    {
        class Student
        {
            public string name;
            public int age;
            public int id;

            public void StudentInfo(int id,int age,string name)
            {
                this.id = id;
                this.age = age;
                this.name = name;

                Console.WriteLine("Student Info:"+ "\nName: " + name+ "\nAge: " + age+ "\nId: " + id);
               // Console.WriteLine("Name: "+name);
               // Console.WriteLine("Age: "+age);
                //Console.WriteLine("Id: " + id);
              
            }
        }
        static void Main(string[] args)
        {

            Console.ReadLine();
            Student student = new Student();
            student.StudentInfo(12, 22, "Ravi");
            Console.ReadLine() ;
        }
    }

    //Note: We Don't Use Destructur in c# because c# has there own garbage collector:
}
