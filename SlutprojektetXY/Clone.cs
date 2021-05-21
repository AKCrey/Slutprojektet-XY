using System.Security.Cryptography;
using System;
using System.Net;
using System.Collections.Generic;

namespace SlutprojektetXY
{
    public class Clone: Fighter
    {
        //Gör en Droid-klass, som går ned i subklasser, både Clone och Droid härstammar från ex. Fighter
        /*
            - Klasser och instanser

            - Metoder i klasser + algoritmer
            - Synlighet (public/private)
            - Arv
            - Generiska Klasser

            */

        //Skriv protected istället för public om det inte används i Progam.cs

        Random Generator = new Random();

        public string name;

        public Clone()//Konstruktor
        {
            hp = 75;
            attack  = 75;
            defense = 75;
            agility = 75;
            special = 50;

            /*special kan man göra intressant
            CloneTrooper special = Thermal detonator: Medium dmg and targets 2 multiple enemies, 2 turns to charge
            JetTrooper special = Jet rocket: High dmg and targets 3 multiple enemies, 4 turns to charge
            HeavyTrooper special = Laser barrage: High dmg and targets 1 enemy, 3 turns to charge
            (Man skulle kunna lägga till passives att olika specials är strong och weak mot olike klasser)*/
        }

        public float LevelUp()
        {
            if(xp == levelBar && xp >= levelBar)
            {
                levelBar = levelBar * 1.5f; 
                LevelBuffs();
            }

            return levelBar;
        }

        public int LevelBuffs()
        {
            level = level + 1;
            xp = 0;
            skillPoints = skillPoints + 25;

            return skillPoints;
        }

        public bool GetAlive()
        {
            return isAlive;
        }

        public string GiveName()
        {
            System.Console.WriteLine("Deploying CT-" + Generator.Next(0,10000));
            Console.WriteLine("Name your trooper:");
            name = Console.ReadLine().Trim().ToLower();
            //Lägg till felmeddelanden
            Console.WriteLine("Welcome " + name + " to this training facility");
            return name;
        }

        /*public void TryParse()
        {
            string answer = Console.ReadLine();

            int answ;

            bool success = int.TryParse(answer, out answ);

            Console.WriteLine(answ + 5);
        }*/

        public string ChooseClass()
        {
            string answer = "";
            Console.WriteLine("Pick a number representing the Class you want to specialize in:");
            Console.WriteLine("(Write the number)");
            Console.WriteLine("1. HeavyTrooper");
            Console.WriteLine("2. JetTrooper");
            answer =  Console.ReadLine();
            
            return answer;
        }
        public void GameOver()
        {
            System.Console.WriteLine("Game Over!");
            Console.ReadLine();
        }
        
        public void GetStats()//Är inte detta perfekt för polimorfi? Kika på det!!
        {
            Dictionary<string, int> cloneStats = new Dictionary<string, int>();
            
            cloneStats.Add("hp", 75);
            cloneStats.Add("attack", 75);
            cloneStats.Add("defense", 75);
            cloneStats.Add("agility", 75);
            cloneStats.Add("special", 50);

            System.Console.WriteLine("Stats: ");
            foreach (string key in cloneStats.Keys)
            {
                Console.WriteLine(key + ": " + cloneStats[key]);
            }
        }
        //public /*virtual/override (Polymorfism, man kan nu använda metoder i Subklasser*/ void Run()
        /*{
            x++;
            if(y < 0)
            {
                hp = 0; 
            }
        }*/
    }
}
