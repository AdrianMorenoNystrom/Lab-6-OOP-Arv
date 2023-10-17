using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    public class Animal
    {
        private int _age { get; set; }
        private string _gender { get; set; }
        private string _animal { get; set; }
        private string _name { get; set; }
        private int _legs{ get; set; }

        //Konstruktor för att skapa nya djur.
        public Animal(string animal="Unknown",string gender="Unknown", int age=0, string name="Unknown",int legs=0)
        {
            // fem egenskaper alla djur delar med varandra.
            _animal = animal;
            _gender = gender;
            _age = age;
            _name = name;
            _legs = legs;
        }

        //Tre metoder alla djur kommer dela med varandra.
        public virtual void Sleep()
        {
            Console.WriteLine("The animal is sleeping\n");
        }
        public virtual void Eat()
        {
            Console.WriteLine("The animal is eating\n");
        }
        public virtual void Play()
        {
            Console.WriteLine("The animal is playing\n");
        }
        
    }

}
