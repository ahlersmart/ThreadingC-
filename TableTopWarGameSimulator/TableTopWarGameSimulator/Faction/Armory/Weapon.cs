using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator.Faction.Armory
{
    internal abstract class Weapon
    {
        private int distance;

        public Weapon(int distance)
        {
            this.distance = distance;
        }

        public void Attack()
        {
            throw new NotImplementedException();
        }
    }
}
