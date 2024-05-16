using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    public class Melee : Weapon
    {
        public Melee(string name, int dmg) : base(1, name, dmg)
        {
        }
    }
}
