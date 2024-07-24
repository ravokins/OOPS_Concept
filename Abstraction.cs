using System;

namespace OOPS_Concept
{
    // abstraction using Interface:
   interface Icar
    {
      string Color { get; set; }
        string wheelCount { get; set; }
        void ShowInfo();
    }
    
    // when this class get constructed the parent class get constructed before by default:
   public class Sedan : Icar
    {
        public string Color { get; set; }
        public string wheelCount { get; set; }
       public Sedan(string color, string wheelCount)
        {
            Color = color;
            this.wheelCount = wheelCount;
        }
        public  void ShowInfo()
        {
            Console.WriteLine("Info:" + "\nColor: " + Color + "\n Wheel Count: " + wheelCount);
        }

    }
   
    internal class Abstraction
    {
        static void Main(string[] args)
        {

            Icar Car = new Sedan("Black", "4");
            Car.ShowInfo();


            Car.Color = "Blue";
            Car.wheelCount = "6";
            Car.ShowInfo();


            Console.ReadLine();
          
            
        }

    }
}
