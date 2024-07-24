using System;

namespace OOPS_Concept
{

    // This is the example of herarical Inheritance:
    // BMW : Car and Tata:Car so these two child have same parents so this fall under herarical Inheritance:

   public class Car 
    {
        public string Color;
        public string Wheel;
        public void Info(string color, string wheel) 
            {
            this.Color = color;
            this.Wheel = wheel;
            Console.WriteLine("Car details:" + "\nColor: " + color + "\nWheel: " + wheel);
        }
    }

   
    public class BMW:Car
    {
        public string Name;
        public string Speed;

        public void CarInfo(string name, string speed)
        {
            this.Name = name;
            this.Speed = speed;
            Console.WriteLine("Name and Speed: " + name + " " + speed);
        }
    }

   
    public class Tata : Car
    {
        public string Model;
        public string Topspeed;

        public void TataInfo(string model,string topspeed)
        {
            this.Model = model;
            this.Topspeed = topspeed;

            Console.WriteLine("Model and Top speed: "+model+" "+topspeed);
        }

    }
    internal class Inheritance
    {
        static void Main(string[] args)
        {
           
            Car c2=new Tata();
            c2.Info("Yellow", "Four");
            Tata tata2 = new Tata();
            tata2.TataInfo("SUV 700", "200km/h"+"\n");

            Car car = new BMW();
            car.Info("Black", "Four");
            BMW bmw1 = new BMW();
            bmw1.CarInfo("BMW S Class", "200 m/h");
          

            Console.ReadLine();

        }
    }
}
