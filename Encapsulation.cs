using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    //Property and function are in one single class is called Encapsulation:

    public class Shape
    {
        
        double width;
        double height;
       public void CalculateArea(double width, double hight)
        {
            this.width = width;
            this.height = hight;
            double Area;
            Area=hight*width;

        }
    }
    internal class Encapsulation
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            double area = shape.Area(12, 15.5);
            Console.WriteLine(area);
            Console.ReadLine();

        }
    }
}
