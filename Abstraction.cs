using System;

namespace OOPS_Concept
{
    // abstraction using abstract class:
   public abstract class Animal1
    {
       public abstract void Walk();
       public  void Breathe()
        {
            Console.WriteLine("The  animal Breaathe");
        }

       public Animal1()
        {
            Console.WriteLine("you created constructor for animal class");
        }

       
    }
    
    // when this class get constructed the parent class get constructed before by default:
   public class Horse1 : Animal1
    {
       public Horse1()
        {
            Console.WriteLine("You Created Horse class");
        }
        public override void Walk()
        {
            Console.WriteLine("Walk on four legs");
        }

    }
    // when this class get constructed the parent class get constructed before by default:
    class Chicken1 : Animal1
    {
        public override void Walk()
        {
            Console.WriteLine("Walks on two legs");
        }
        public Chicken1() {
            Console.WriteLine("Created chicken class constructor");
        }
    }
    internal class Abstraction
    {
        static void Main(string[] args)
        {
            Horse1 horse1 = new Horse1();
            horse1.Walk();
            horse1.Breathe();
            Chicken1 chicken1 = new Chicken1();
            chicken1.Walk();
            chicken1.Breathe();

            Console.ReadLine();
          
            
        }

    }
}
