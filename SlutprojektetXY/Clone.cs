using System;

namespace SlutprojektetXY
{
    public class Clone
    {
        //Skriv protected istället för public om det inte används i Porgam.cs

        public string name;

        public int hp;

        public int dmg;

        public int intelligence;

        public int agility;

        public int xp;
        public int level;

        public int x;
        public int y;

        public Clone()//Konstruktor
        {
            hp = 100;


        }

        public int Hp{//En property, kortare version av koden under
            get
            {
                return hp;
            }
            set
            {
                hp = value;
                if (hp < 0)
                {
                    hp = 0;
                }
            }
        }
        /*public void SetHp(int value)//inkapsling, hp kan nu inte ändras i main men för att ändra det måste man anropa SetHP numera. 
        {
            hp = value;
            if (hp < 0)
            {
                hp = 0;
            }
        }
        public int GetHp()
        {
            return hp;
        }*/


        public /*virtual/override (Polymorfism, man kan nu använda metoder i Subklasser*/ void Run()
        {
            x++;
            if(y < 0)
            {
                hp = 0; 
            }
        }

    }
}
