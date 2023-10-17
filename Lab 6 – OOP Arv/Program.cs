namespace Lab_6___OOP_Arv
{

    public class Program
    {
        static void Main(string[] args)
        {

            Cat katt = new Cat();

            Dog hund = new Dog();

            Marsvin marsvin = new Marsvin();

            Pitbull pitbull = new Pitbull("Hund", "Hane", 4, "Manfred", 4, "Brun", "Pitbull");

            Chihuahua chihuahua = new Chihuahua("Hund", "Hona", 2, "Karin", 4, "Grön", 2);

            //Varje klass har en egen metod.
            marsvin.IsHungry();
            hund.Jump();
            katt.Growl();

            //Tre metoder som alla klasser delar med varandra.
            hund.Sleep();
            hund.Eat();
            hund.Play();

            marsvin.Sleep();
            marsvin.Eat();
            marsvin.Play();

            katt.Sleep();
            katt.Eat();
            katt.Play();

            //Djurens läte
            Console.WriteLine("Djurens läte:");
            hund.MakeSound();
            katt.MakeSound();
            marsvin.MakeSound();

            //Arv i två nivåer, metoder.
            pitbull.Run();
            chihuahua.Swim();

            
            

        }
    }
}