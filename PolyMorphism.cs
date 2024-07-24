using System;

namespace OOPS_Concept
{
    // As the Name it's self defines it property: Poly: Many, Morph: forms

//Run Time polymorphism:
// This will basically overide the function of parent class and proceed with child class function:

/*Key Points
virtual: Used in the parent class to indicate that a method can be overridden.
override: Used in the child class to indicate that a method is overriding a parent class method.
Polymorphism: Allows a parent class reference to point to a child class object, and the correct overridden method is called at runtime based on the actual object type.*/
public class Animal
{
    public virtual void Walks()
    {
        Console.WriteLine("Animal Walks");

    }

}
public class Chicken : Animal
{
    //Overiding the walks in child class
    public override void Walks()
    {
        Console.WriteLine("Chicken walks on 2 legs");

    }
}
public class Cow : Animal
{
    //Overiding the walks in child class
    public override void  Walks()
    {
        Console.WriteLine("Cow walks on 4 legs");

    }
}
internal class PolyMorphism
{





    static void Main(string[] args)
    {
        Animal chicken = new Chicken();

        chicken.Walks();

        Animal cow = new Cow();
        cow.Walks();


        Console.ReadLine ();
    }
}
}
