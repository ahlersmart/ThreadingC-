using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator.Model.Game.Gamemode
{
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
