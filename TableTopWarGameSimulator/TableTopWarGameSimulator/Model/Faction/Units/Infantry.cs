using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTopWarGameSimulator.Model.Faction.Armory;

namespace TableTopWarGameSimulator.Model.Faction.Units
{
    internal class Infantry : AbstractUnit
    {
        public Infantry(string name, int value, int movement, int toughness, int safe, int wounds, int leadership, int x, int y, int objectiveControle, List<Weapon> rangeWeapons, List<Weapon> meleeWeapons) : base(name, value, movement, toughness, safe, wounds, leadership, x, y, objectiveControle, rangeWeapons, meleeWeapons)
        {
        }
    }
}
