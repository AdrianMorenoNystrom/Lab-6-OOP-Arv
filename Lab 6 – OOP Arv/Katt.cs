using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    public class Cat : Animal
    {
        //Unikt field för katt som är färg.
        public string Color;
        //Konstruktor för Katt med basvärden.
        public Cat(string animal="Katt", string gender="Hane", int age=10, string name="Shaggy", int legs=4,string color="Svart")
            : base(animal, gender, age, name, legs)
        {
            Color = color;
            Console.WriteLine($"Djur:{animal} Kön:{gender} Ålder:{age} Namn:{name} Antal ben:{legs},Färg: {color}\n ");
        }

        //Overridar metoderna jag skapade i Animal och gör unika för denna klass.
        public override void Sleep()
        {
            Console.WriteLine("Katten sover");
        }
        public override void Eat()
        {
            Console.WriteLine("Katten äter");
        }
        public override void Play()
        {
            Console.WriteLine("Katten leker\n");
        }

        //unik metod för katt
        public void Growl()
        {
            Console.WriteLine("Katten morrar\n");
        }
        
        public void MakeSound()
        {
            Console.WriteLine("Mjau");
        }
    }
}
