using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTopWarGameSimulator.Model.Faction.Units;

namespace TableTopWarGameSimulator.Model.Faction
{
    internal class Faction
    {
        private List<AbstractUnit> units;

        public Faction()
        {
            units = new List<AbstractUnit>();
        }

        public void addUnit(AbstractUnit unit) { units.Add(unit); }
        public List<AbstractUnit> GetUnits() { return units; }

    }
}
