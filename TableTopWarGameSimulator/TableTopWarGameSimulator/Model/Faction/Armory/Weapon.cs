using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator.Model.Faction.Armory
{
    internal abstract class Weapon
    {
        private int distance;
        private string name;
        private int dmg;

        public Weapon(int distance, string name, int dmg)
        {
            this.distance = distance;
            this.name = name;
            this.dmg = dmg;
        }

        public int getDistance() { return distance; }
        public string getName() { return name; }
        public int getDmg() { return dmg; }
    }
}
