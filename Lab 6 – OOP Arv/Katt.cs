using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    public class Cat : Animal
    {
        public Cat(string animal="Katt", string gender="Hane", int age=10, string name="Shaggy", int legs=4,string color="Svart")
            : base(animal, gender, age, name, legs)
        {
            Color = color;
            Console.WriteLine($"Djur:{animal} Kön:{gender} Ålder:{age} Namn:{name} Antal ben:{legs},Färg: {color}\n ");
        }
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
        public string Color { get; set; }

        //Metod för katt
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
