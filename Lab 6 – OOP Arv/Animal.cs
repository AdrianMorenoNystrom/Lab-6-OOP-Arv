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
        
        public  Animal(string animal="Unknown",string gender="Unknown", int age=0, string name="Unknown",int legs=0)
        {
            _animal = animal;
            _gender = gender;
            _age = age;
            _name = name;
            _legs = legs;
            //Console.WriteLine($"Djur:{animal} Kön:{gender} Ålder:{age} Namn:{name} Antal ben:{legs}");
        }
        public virtual void Print()
        {

        }

        public void Sleep()
        {
            Console.WriteLine("The animal is sleeping");
        }
        public void Eat()
        {
            Console.WriteLine("The animal is eating");
        }
        public void Play()
        {
            Console.WriteLine("The animal is playing");
        }
        
    }

}
