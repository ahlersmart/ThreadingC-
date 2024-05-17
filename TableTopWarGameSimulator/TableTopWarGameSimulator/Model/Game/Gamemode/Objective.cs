using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    //class for objectives that need to be captured in the gamemode
    internal class Objective
    {
        public int y, x;

        public Objective(int y, int x)
        {
            this.y = y;
            this.x = x;
        }
    }
}
