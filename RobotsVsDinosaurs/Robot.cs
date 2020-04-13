using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Robot
    {
        //Member Variables (what this class has)

        public string name;
        public double health;
        public double powerLevel;
        public string weapon;
        public double attackPower;

        //Constructors (Spawners)

        public Robot(string robotType)  //Robot specs
        {

            this.name = robotType;
            health = 100;
            powerLevel = 100;
            weapon = "Spear";
            attackPower = 20;

        }
        //Member Methods (what this class does)
        public void RobotAttack(int attackPower)  // robot attack ability
        {
             attackPower -= 20;
        }

    }
}
