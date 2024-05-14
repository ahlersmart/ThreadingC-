using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Model.Faction.Armory
{
    internal abstract class Weapon
    {
        private int distance;
        private string name;

        public Weapon(int distance, string name)
        {
            this.distance = distance;
            this.name = name;
        }

        public int Attack()
        {
            return distance;
        }

        public string getName() { return name; }
    }
}
