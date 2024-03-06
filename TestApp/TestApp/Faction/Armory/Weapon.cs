using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Faction.Armory
{
    internal abstract class Weapon
    {
        private int distance;
        private String name;

        public Weapon(int distance, String name)
        {
            this.distance = distance;
            this.name = name;
        }

        public int Attack()
        {
            return distance;
        }

        public String getName() { return name; }
    }
}
