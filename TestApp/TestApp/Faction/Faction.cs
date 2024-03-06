using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Faction.Units;

namespace TestApp.Faction
{
    internal class Faction
    {
        private List<AbstractUnit> units;

        public Faction() { 
            this.units = new List<AbstractUnit>();
        }

        public void addUnit(AbstractUnit unit) { this.units.Add(unit); }
        public List<AbstractUnit> GetUnits() { return this.units; }

    }
}
