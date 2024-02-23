using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTopWarGameSimulator.Faction.Armory;

namespace TableTopWarGameSimulator.Faction.Units
{
    internal abstract class AbstractUnit
    {
        private String Name;
        private int value, movement, toughness, safe, wounds, leadership; // unit values
        private int x, y; // position coordinates
        private int objectiveControle;
        private ArrayList<Weapon> rangeWeapons = new ArrayList();

    }
}
