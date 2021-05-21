using System;

namespace SlutprojektetXY
{
    public class HeavyTrooper: Clone //HeavyTrooper är ett arv av Clone
    {
        public HeavyTrooper()         // 325 total + 25 starting points to customize
        {                             // Clone     Jet     Heavy
            hp = 100;                 //  75        50      100
            attack = 75;              //  75        100     75
            defense = 100;            //  75        25      100
            agility = 0;              //  50        100     0
            special = 50;             //  50        50      50
        }
    }
}
