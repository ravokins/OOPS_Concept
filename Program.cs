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
            public string Id { get; set; }
            public double MonthlyJ { get; set; }
            public double MonthlyF { get; set; }
            public double MonthlyM { get; set; }


            public void StudentIndfo(int age, string id, string name,double monthlyj, double monthlyf, double monthlym)
            {
                Name = name.ToLower();
                Age = age;
                Id = id;
                MonthlyJ = monthlyj;
                MonthlyF = monthlyf;
                MonthlyM = monthlym;

                Console.WriteLine("Student Info:" + "\nName:" + name + "\nAge: " + age + "\nId: " + id);

                double sumM= monthlyf+monthlyj+monthlym;
                Console.WriteLine("Total Monthly Till March: " + sumM);

            }
            public Student()
            {
                
               

            }
        }

        

        static void Main(string[] args)
        {
           

            Console.WriteLine("Enter Student Info: ");
            Console.Write("Name: ");
            string name=Console.ReadLine();
            Console.Write("Age: ");
            int age =Convert.ToInt32(Console.ReadLine());
            Console.Write("Id: ");
            string id = (Console.ReadLine());
            Console.Write("January Monthly: ");
            double jMonthly= double.Parse(Console.ReadLine());
            Console.Write("February Monthly: ");
            double fMonthly =double.Parse(Console.ReadLine());
            Console.Write("March Monthly: ");
            double mMonthly = double.Parse((Console.ReadLine()));



            Student student = new Student();

            student.StudentIndfo(age, id, name,jMonthly,fMonthly,mMonthly);

            Console.ReadLine();
        }
    }
}

    //Note: We Don't Use Destructur in c# because c# has there own garbage collector:

