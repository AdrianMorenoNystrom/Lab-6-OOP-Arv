using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    public class Dog : Animal
    {
        //Unikt field för Hund som är ögonfärg.
        public string EyeColor;
        //Konstruktor för hund med basvärden.
        public Dog(string animal="Hund", string gender="Hane", int age=6, string name="Herman", int legs=4,string eyecolor="Blå")
                : base(animal, gender, age, name, legs)
        {
            EyeColor = eyecolor;
            Console.WriteLine($"Djur:{animal} Kön:{gender} Ålder:{age} Namn:{name} Antal ben:{legs}, Ögonfärg: {eyecolor}\n");
        }

        //Overridar metoderna jag skapade i Animal och gör unika för denna klass.
        public override void Sleep()
        {
            Console.WriteLine("Hunden sover");
        }
        public override void Eat()
        {
            Console.WriteLine("Hunden äter");
        }
        public override void Play()
        {
            Console.WriteLine("Hunden leker\n");
        }


        //unik metod för hund
        public void Jump()
        {
            Console.WriteLine("Hunden hoppar\n");
        }

        public void MakeSound()
        {
            Console.WriteLine("Voff");
        }

    }
}
