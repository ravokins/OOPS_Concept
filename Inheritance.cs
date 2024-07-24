using System;

namespace OOPS_Concept
{

   // Multiple Inheritance: In This one child hava to Parents:we achive Multiple inheritance using Interface:

   public interface ICar 
    {
        // We can't implement function and parameters in interface we just define function in interfaces:
        string Color { get; set; }
        string Wheel { get; set; }
        void Info(string color,string wheel);
     
    }

   
    public interface IBMW
    {
       string Name { set; get; }
        string Speed { set; get; }
        void CarInfo(string name, string speed);       
    }

  
    public class BmwS :ICar, IBMW
    {
       public string Color { get; set; }
       public string Wheel { get; set; }
       public string Name { set; get; }
       public string Speed { set; get; }

        public void Info(string color, string wheel)
        {
            this.Color = color;
            this.Wheel = wheel;
            Console.WriteLine("Car details: \n" + "\nColor: " + color + "\nWheel: " + wheel);
        }
        public void CarInfo(string name, string speed)
        {
            this.Name = name;
            this.Speed = speed;
            Console.WriteLine("Name and Speed: " + name + " " + speed);
        }

    }

    internal class Inheritance
    {
        /*static void Main(string[] args)
        {
            BmwS bmw = new BmwS();
            bmw.Info("Black", "Four");
            bmw.CarInfo("BMW S Class", "200 m/h");
          

            Console.ReadLine();

        }*/
    }
}
