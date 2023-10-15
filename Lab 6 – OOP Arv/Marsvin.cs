using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    public class Marsvin : Animal
    {

        public double Weight { get; set; }

        public Marsvin(string animal="Marsvin", string gender="Hona", int age=2, string name="Luna", int legs=4,double weight=0.5)
            :base(animal,gender,age,name,legs)
        {
            Weight = weight;
            Console.WriteLine($"Djur:{animal} Kön:{gender} Ålder: {age} Namn: {name} Antal ben: {legs}, Vikt: {weight}kg\n");

        }
        public override void Sleep()
        {
            Console.WriteLine("Marsvinet sover");
        }

        public override void Eat()
        {
            Console.WriteLine("Marsvinet äter");
        }

        public override void Play()
        {
            Console.WriteLine("Marsvinet leker\n");
        }

        public void MakeSound()
        {
            Console.WriteLine("????");
        }
        public void IsHungry()
        {
            Random ran = new Random();
            int TrueorFalse = ran.Next(0, 2);
            if (TrueorFalse == 1)
            {
                Console.WriteLine("Marsvinet är hungrig\n");
            }
            else
            {

                Console.WriteLine("Marsvinet är inte hungrig\n");
            }

        }
    }
}
