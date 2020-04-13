using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Weapon
    {
        //Member Variables (what this class has)
        List<Weapon> weapons;

        //Constructors (Spawners)

        //Member Methods (what this class does)
        public void RoboWeapon()
        {
            List<string> weapons = new List<string>();

            weapons.Add("sword");
            weapons.Add("spear");
            weapons.Add("bow");
            weapons.Add("nunchucks");
        }

        public void DinoAttacks()
        {
            string[] dinoAttackType = new string[4];

            dinoAttackType[0] = "slap";
            dinoAttackType[1] = "kick";
            dinoAttackType[2] = "tailswing";
            dinoAttackType[3] = "bite";

        }






    }
}
