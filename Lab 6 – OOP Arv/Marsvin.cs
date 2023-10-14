using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6___OOP_Arv
{
    public class Marsvin : Animal
    {
        public Marsvin(string animal, string gender, int age, string name, int legs,int weight)
            :base(animal,gender,age,name,legs)
        {
            Weight = weight;

        }
        public bool Hungry { get; set; }
        public int Weight { get; set; }

        public static bool IsHungry()
        {
            Random ran = new Random();
            int TrueorFalse = ran.Next(0, 2);
            bool Hungry=true;
            if (Hungry==true)
            {
                Console.WriteLine("Marsvinet är hungrig");
            }
            else
            {
                
                Console.WriteLine("Marsvinet är inte hungrig");
            }
            return Hungry;
            
        }
    }
}
