using System;

namespace SlutprojektetXY
{
    public class JetTrooper: Clone
    {
        public JetTrooper()         // 325 total + 25 starting points to customize
        {                           // Clone     Jet     Heavy
            hp = 50;                //  75        50      100 //För en Clonetrooper tar det 2/3/4
            attack = 100;           //  75        100     75
            defense = 50;           //  75        25      100
            agility = 100;          //  50        100     0
            special = 50;           //  50        50      50 
        }  // Attack 1point = 0,5 hp i skada. Defense 1point = 0,25 hp mindre i skada. Agility 1point = 0,2% chans att undvika skada helt
    } 
}
