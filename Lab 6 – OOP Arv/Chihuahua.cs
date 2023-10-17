using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    public class Chihuahua : Dog
    {
        //Unikt field för Chihuahua som är antal ögon.
        public int Eyes;
        //Konstruktor för Chihuahua med basvärden.
        public Chihuahua(string animal= "Hund", string gender = "Hona", int age = 2, string name = "Karin", int legs = 4, string eyecolor = "Grön",int eyes=2)
                : base(animal, gender, age, name, legs)
        {
            Eyes = eyes;
            Console.WriteLine($"Djur:{animal} Kön:{gender} Ålder:{age} Namn:{name} Antal ben:{legs}, Ögonfärg:{eyecolor}Antal ögon:{eyes}\n");
        }

        //Unik metod för Chihuahua
        public void Swim()
        {
            Console.WriteLine("Chihuahuan badar");
        }
    }
}
