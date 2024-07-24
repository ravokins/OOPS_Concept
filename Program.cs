using System;
using System.Collections.Generic;

namespace OOPS_Concept
{
    public interface IGun
    {
        void Shoot();
        void Reload();

        string GetGunInfo();
    }
    public abstract class Gun : IGun
    {
        public string Name { get; set; }
        public int AmmoCapcity { get; set; }
        public int CurrentAmmo { get; set; }

        protected Gun(string name,int ammoCapcity) {
            Name = name;
            AmmoCapcity = ammoCapcity;
            CurrentAmmo = ammoCapcity;
        }

        public abstract void Shoot();
        public void Reload()
        {
            CurrentAmmo=AmmoCapcity;
            Console.WriteLine(Name + " reloaded " + "ammo is: " + CurrentAmmo +"/"+ AmmoCapcity);

        }

        public string GetGunInfo()
        {


            return "Gun: " + Name + "Ammo: " + CurrentAmmo +"/"+ AmmoCapcity;
        }

    }
    public class Pistol : Gun
    {
        // we have written this line because the main class constructor contains the definition of this
        public Pistol():base("Pistol",15) { }
        public override void Shoot()
        {
            if (CurrentAmmo > 0)
            {
                CurrentAmmo--;
                Console.WriteLine("Pistol" + GetGunInfo());
            }
            else { Console.WriteLine("No Ammo"); }
        }

    }
    public class Shortgun : Gun
    {
        // we have written this line because the main class constructor contains the definition of this
        public Shortgun() : base("Shortgun", 12) { }
        public override void Shoot()
        {
            if (CurrentAmmo > 0)
            {
                CurrentAmmo--;
                Console.WriteLine("ShortGun" + GetGunInfo());
            }
            else { Console.WriteLine("No Ammo"); }
        }

    }
    public class AWM : Gun
    {
        // we have written this line because the main class constructor contains the definition of this
        public AWM() : base("AWM", 10) { }
        public override void Shoot()
        {
            if (CurrentAmmo > 0)
            {
                CurrentAmmo--;
                Console.WriteLine("AWM" + GetGunInfo());
            }
            else { Console.WriteLine("No Ammo"); }
        }

    }

    internal class Program
    {
        private static void Main(string[] args)
        {

            List<IGun> guns = new List<IGun> 
            {  
                new Pistol(),
                new Shortgun(),
                new AWM() 
            };
            foreach(var gun in guns)
            {
                gun.Shoot();
                gun.Reload();
                gun.Shoot();
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}    //Note: We Don't Use Destructur in c# because c# has there own garbage collector:

