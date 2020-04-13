using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVsDinosaurs
{
    class Fleet
    {
        //Member Variables (what this class has)

        //Constructors (Spawners)
        public void Robots()
        {
            Robot optimus = new Robot("optimus"); //instantiate (calling Robot class)
            Robot bumblebee = new Robot("bumblebee");
            Robot ironhide = new Robot("ironhide");
        }
        //Member Methods (what this class does)

    }
}
