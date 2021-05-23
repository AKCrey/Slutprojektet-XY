using System;
using System.Collections.Generic;

namespace SlutprojektetXY
{
    public class Fighter
    {
        protected int hp;//Ökar antalet health points
        protected int attack;//Mer dmg i basic attacks
        protected int defense;//Minska skadan av attacker 
        protected int agility;//Ökar chansen att dodga attacker helt 
        protected int special;//Special attack skadar mer och kan användas oftare mellan rundor
        
        protected int xp; //ändra till protected efter ändringar i Main
        protected int level;
        protected float levelBar = 1.5f;
        protected int skillPoints = 25;
        
        Random Generator = new Random();

        public bool isAlive = true;

        List<string> Skills = new List<string>() {"HP", "DMG", "Defense", "Agility"};

        //Gör en list som innehåller olika skills man kan välja mellan. En Write metod kommer att skriva ut namnen på skillsen

        public virtual int Xp{//En property
            get
            {
                return xp;
            }
            set
            {
                xp = value;
                if (xp < 0)
                {
                    xp = 0;
                }
            }
        }
        public virtual int Hp{//En property, kortare version av koden under
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
    }
}
