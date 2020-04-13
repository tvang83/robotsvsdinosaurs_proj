using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Dinosaur
    {
        //Member Variables (what this class has)

        public string type;
        public double health;
        public double energy;
        public double attackPower;

        //Constructors (Spawners)
        public Dinosaur(string dinoType) //example
        {

            this.type = dinoType;  //example 
            health = 100;
            energy = 100;
            attackPower = 20;

        }

        //Member Methods (what this class does)

        public void DinoAttack(int attackPower)
        {
            //dinosaur attack ability
            attackPower -= 20;

        }

    }
}
