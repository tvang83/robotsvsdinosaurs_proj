using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Battlefield
    {
        //Member variables 
        int health;
        int attack;
        int dinoHealth;
        int roboHealth;



        public void RoboAttack()  // dinosaur attack
        {
            health = 100;
            attack = 20;

            for (int health = 100; dinoHealth > 0; dinoHealth++)
            {
                if (health >= 0)
                {
                    dinoHealth = health - attack;
                    return;
                }
                else if (dinoHealth == 0)
                {
                    return;
                }
            }
        }
        public void DinoAttack() //robot attack
        {
            health = 100;
            attack = 20;

            for (int health = 100; roboHealth > 0; roboHealth++)
            {
                if (health >= 0)
                {
                    roboHealth = health - attack;
                    return;
                }
                else if (roboHealth == 0)
                {
                    return;
                }
            }
        }

        public void dinoBattleFinish() //battle conclude
        {
            if (dinoHealth == 0)
            {
                Console.WriteLine("Finish!");
                Console.ReadLine();
            }
        }
        public void roboBattleFinish() //battle conclude
        {
            if (roboHealth == 0)
            {
                Console.WriteLine("Finish!");
                Console.ReadLine();
            }
        }

    }
}
}
