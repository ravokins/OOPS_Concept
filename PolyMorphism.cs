using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Concept
{
    internal class PolyMorphism
    {

        // As the Name it's self defines it property: Poly: Many, Morph: forms

        //Compile Time polymorphism:
        class PolyTest
        {
            public void Add(int a, int b)
            {
                int Sum = a + b;
                Console.WriteLine(Sum);
            }

            public void Add(int a, int b,int c)
            {
                int Sum = a + b+c;
                Console.WriteLine(Sum);
            }

            public double Add(double a, double b,double c)
            {
                return a + b + c;
               
               
            }

        }

        static void Main(string[] args)
        {
            PolyTest test = new PolyTest();
            test.Add(1, 2);
            test.Add(2, 3,5);
            double sumretun= test.Add(3.5555, 4.6666,6.99999);
            Console.WriteLine(sumretun);
            Console.ReadLine ();
        }
    }
}
