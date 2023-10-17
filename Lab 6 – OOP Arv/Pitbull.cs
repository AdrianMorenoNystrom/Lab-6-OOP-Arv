using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    public class Pitbull : Dog
    {
        public string Breed;
        public Pitbull(string animal= "Hund", string gender = "Hane", int age = 6, string name = "Herman", int legs = 4, string eyecolor = "Blå",string breed="Pitbull")
                : base(animal, gender, age, name, legs)
        {
            Breed = breed;
            Console.WriteLine($"Djur:{animal} Kön:{gender} Ålder:{age} Namn:{name} Antal ben:{legs}, Ögonfärg:{eyecolor} Ras:{breed}\n");
        }

        //unik metod för pitbull.
        public void Run()
        {
            Console.WriteLine("Hunden springer");
        }
    }
}
