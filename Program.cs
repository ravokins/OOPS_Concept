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

            public Student(int age,int id, string name)
            {
                this.age = age;
                this.id = id;
                this.name = name;
                Console.WriteLine("Student Info:"+ "\nName: " + name+ "\nAge: " + age+ "\nId: " + id);

            }
        }

        

        static void Main(string[] args)
        {

            Console.ReadLine();
            Student student = new Student(22,11,"Ravi");

            Console.ReadLine();
        }
    }
}

    //Note: We Don't Use Destructur in c# because c# has there own garbage collector:

