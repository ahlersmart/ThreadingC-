using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator.Faction.Units
{
    internal class Beast : AbstractUnit
    {
        public Beast(string name, int value, int movement, int toughness, int safe, int wounds, int leadership, int x, int y, int objectiveControle, ArrayList rangeWeapons, ArrayList meleeWeapons) : base(name, value, movement, toughness, safe, wounds, leadership, x, y, objectiveControle, rangeWeapons, meleeWeapons)
        {
        }
    }
}
