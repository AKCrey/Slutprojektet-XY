using System;
using System.Collections.Generic;

namespace SlutprojektetXY
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kolla på Queue o Dictionary          
            Clone PlayerClone = new Clone();

            List<Clone> ClonePatrol = new List<Clone>();

            PlayerClone.GiveName();
            
            string a = PlayerClone.ChooseClass();
            int answ;
            bool success = int.TryParse(a, out answ);
            while(answ != 1 && answ != 2)
            {
                Console.Clear();
                Console.WriteLine("Wrong input!");

                a = PlayerClone.ChooseClass();
                answ = 0;
                success = int.TryParse(a, out answ);
            }
            
            if(answ == 1)
            {
                HeavyTrooper FirstHeavy = new HeavyTrooper();
                ClonePatrol.Add(FirstHeavy);
            }
            else if(answ == 2)
            {
                JetTrooper FirstJet = new JetTrooper();
                ClonePatrol.Add(FirstJet);
            }

            while(PlayerClone.GetAlive() == true)
            {
                /*PlayerClone.xp = 10;
                PlayerClone.LevelUp();*/ //Testar LevelUp

                //Console.WriteLine("Class:" + ClonePatrol[0]/* .hp exempelvis om man bara vill skriva ut HP */);

                PlayerClone.getStats();

                Console.ReadLine();

                //Queue<int> attackOrder = new Queue<int>(); 
                /*Ideen bakom kösystemet är att olika klasser ska ha olika weight,
                ex: på 1 HeavyTroopers attack kan en CloneTrooper attackera 2 gånger, och en JetTrooper 3 gånger
                Eftersom karaktärerna attackerar i tur och ordning måste det finnas en "kö" på vem som får attackera när.
                Kön är alltså gjord för att lägga in de som "väger minst" alltså de som kan attackera flest gånger först i
                ordningslistan, och resten efter. Jag prövar det här och ser hur det går, vet inte om det är fel sätt att
                använda Queue på o~o*/
                /*attackOrder.Enqueue(1);
                attackOrder.Enqueue(2);
                attackOrder.Enqueue(3);

                attackOrder.Dequeue();*/

                //Console.WriteLine("Hp:" + ClonePatrol[0].Hp);//Skriver ut instansens 

                Console.ReadLine();

                Console.Clear();
            }
        }
    }
}
