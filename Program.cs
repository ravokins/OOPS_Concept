using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPS_Concept
{

    //Classes:

    class Student
    {
        string Name = "";
        string Age = "";

        public void PrintInfo(string name, string age)
        {
            this.Name = name;
            this.Age = age;
            Console.WriteLine(Name + " " + Age);
        }

        /*
         //Non-Parameterized constructor
         public Student()
         {
             Console.WriteLine("Constructur is called");

         }
        */

        /*
        // Constructur Or Object Define with Parameters: Parameterized constructor
        public Student(string name, string age) {
            this.Name = name;
            this.Age = age;
            Console.WriteLine(Name + " " + Age);
        }
        */

        // Copy Constructor: Copy One Conmstructur Value to other Constructur:
        public Student(Student s2)
        {
            this.Name = s2.Name;
            this.Age = s2.Age;

        }
        public Student (){
}
    }
    internal class Program 
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Student s2 = new Student(student1);
            s2.PrintInfo("Ravi", "22");
            Console.ReadLine();
        }
    }

    //Note: We Don't Use Destructur in c# because c# has there own garbage collector:
}
