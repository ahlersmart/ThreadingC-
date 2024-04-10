using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Model.Faction.Armory;

namespace TestApp.Model.Faction.Units
{
    internal class Vehicle : AbstractUnit
    {
        public Vehicle(string name, int value, int movement, int toughness, int safe, int wounds, int leadership, int x, int y, int objectiveControle, List<Weapon> rangeWeapons, List<Weapon> meleeWeapons) : base(name, value, movement, toughness, safe, wounds, leadership, x, y, objectiveControle, rangeWeapons, meleeWeapons)
        {
        }
    }
}
