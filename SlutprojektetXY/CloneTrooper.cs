using System;

namespace SlutprojektetXY
{
    public class CloneTrooper: Clone
    {
        public CloneTrooper()         // 325 total + 25 starting points to customize
        {                             // Clone     Jet     Heavy
            hp = 75;                  //  75        50      100
            attack = 75;              //  75        100     75
            defense = 75;             //  75        25      100
            agility = 50;             //  50        100     0
            special = 50;             //  50        50      50
        }
    }
}
