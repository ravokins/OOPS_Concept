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
            public string Name{ get; set; }
            public int Age { get; set; }
            public int Id { get; set; }


            public void StudentIndfo(int age, int id, string name)
            {
                Name = name.ToLower();
                Age = age;
                Id = id;

                Console.WriteLine("Student Info:" + "\nName:" + name + "\nAge: " + age + "\nId: " + id);

            }
            public Student()
            {
                
               

            }
        }

        

        static void Main(string[] args)
        {
           

            Console.Write("Enter Student Info: ");
            Console.Write("Name: ");
            string name=Console.ReadLine();
            Console.Write("Age: ");
            int age =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());



            Student student = new Student();

            student.StudentIndfo(age, id, name);

            Console.ReadLine();
        }
    }
}

    //Note: We Don't Use Destructur in c# because c# has there own garbage collector:

