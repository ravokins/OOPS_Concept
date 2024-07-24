using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{

    //Inheritance:

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

    // Single Level Inheritance:
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

    // Multilevel Inheritance:
    public class Tata : BMW
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
           

            Car car = new BMW();
            car.Info("Black", "Four");
            BMW bmw1 = new BMW();
            bmw1.CarInfo("BMW S Class", "200 m/h");
            BMW tata1 =new Tata();
            tata1.CarInfo("Tata Moters ", "60 km/h");
            Tata tata2 =new Tata();
            tata2.TataInfo("SUV 700", "200km/h");

            Console.ReadLine();

        }
    }
}
