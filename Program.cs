using System;

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

            //Default constructor:

           public Student() { }
           public Student(int age, string id, string name, double monthlyj, double monthlyf, double monthlym) {
                Name = name.ToLower();
                Age = age;
                Id = id;
                MonthlyJ = monthlyj;
                MonthlyF = monthlyf;
                MonthlyM = monthlym;
            }

           
            public Student(Student s2)
            {
                Name = s2.Name.ToLower();
                Age = s2.Age;
                Id =s2. Id;
                MonthlyJ = s2.MonthlyJ;
                MonthlyF = s2.MonthlyF;
                MonthlyM = s2.MonthlyM;


            }

            public void StudentIndfo()
            {
                

                Console.WriteLine("Student Info:" + "\nName:" + Name + "\nAge: " + Age + "\nId: " + Id);
                double sumM = MonthlyJ + MonthlyF + MonthlyM;
                Console.WriteLine("Total Monthly Till March: " + sumM);

            }
        }

        

       /* static void Main(string[] args)
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

          

            Student student1 = new Student(age,id,name,jMonthly,fMonthly,mMonthly);
            Student s2 = new Student(student1);
            Console.WriteLine("Original value");

            student1.StudentIndfo();

           Console.WriteLine("Updated Values");
            s2.Name = "Ramesh";
            s2.Age = 32;
            s2.Id = "12334567-89";
            s2.StudentIndfo();

            Console.ReadLine();
        }*/
    }
}

    //Note: We Don't Use Destructur in c# because c# has there own garbage collector:

