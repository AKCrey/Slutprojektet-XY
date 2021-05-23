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
            
            cloneStats.Add("hp", Hp);
            cloneStats.Add("attack", attack);
            cloneStats.Add("defense", defense);
            cloneStats.Add("agility", agility);
            cloneStats.Add("special", special);

            System.Console.WriteLine("Stats: ");
            int number = 1;
            foreach (string key in cloneStats.Keys)
            {
                Console.WriteLine(number + " " + key + ": " + cloneStats[key]);
                number = number + 1;
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
        public int SpendSkillPoints()
        {
            GetStats();

            Console.WriteLine("You have " + skillPoints + " SkillPoints to spend");

            System.Console.WriteLine("Write the number of the skill you want to upgrade");

            string userChoice1 = Console.ReadLine();

            while (userChoice1 != "1" && userChoice1 != "2" && userChoice1 != "3")
            {
                Console.WriteLine("Choose one number listed above");
                userChoice1 = Console.ReadLine();
            }

            if (userChoice1 == "1")
            {
                Console.WriteLine("");
                Console.WriteLine("How many points to you want to spend on HP");
                Console.WriteLine("Current SkillPoints: " + skillPoints);

                string amountChoice1 = Console.ReadLine(); /*Det man skriver in sparas som en string*/

                //Kontrollera att dumma användare inte skriver in ord eller nåt annat trams...

                int amountChoice1int = 0;

                bool success = int.TryParse(amountChoice1, out amountChoice1int); /*Eftersom man vill göra matte så gör jag om stringen still en int*/

                skillPoints = skillPoints - amountChoice1int;

                amountChoice1int = SkillPointCheck(amountChoice1int, amountChoice1);//While-loopen som checkar att man inte gett för högt värde

                Hp = Hp + amountChoice1int;

                Console.WriteLine("SkillPoints left: " + skillPoints);

            }

            Console.ReadLine();

            Console.Clear();

            GetStats();

            return skillPoints;
        }
        public int SkillPointCheck(int amountChoice1int, string amountChoice1)
        {
            while (skillPoints < 0)
            {
                skillPoints = 25;

                Console.WriteLine("You can't spend more than you have");

                amountChoice1 = Console.ReadLine(); /*Nu börjar det om igen*/

                bool success = int.TryParse(amountChoice1, out amountChoice1int);

                skillPoints = skillPoints - amountChoice1int;
            }

            return amountChoice1int;
        }
    }
}
