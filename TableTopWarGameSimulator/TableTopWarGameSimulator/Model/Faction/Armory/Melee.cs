using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    internal class Melee : Weapon
    {
        public Melee(int distance, string name, int dmg) : base(distance, name, dmg)
        {
        }
    }
}
