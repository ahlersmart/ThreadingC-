using Foundation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTopWarGameSimulator.Model.Faction.Armory;
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

        public void addUnit(AbstractUnit unit) 
        {
            if (units.Count == 0)
            {
                this.units.Add(unit);
            }
            else
            {
                foreach (var existingUnit in units)
                {
                    if (existingUnit.getName() == unit.getName())
                    {
                        throw new ArgumentException($"Unit '{unit.getName()}' already exists in the faction.");
                    }
                }

                this.units.Add(unit);
            }
        }

        public void addNewUnit(string unitType, string name, int value, int movement, int toughness, int safe, int wounds, int leadership, int x, int y, int objectiveControle, List<Weapon> rangeWeapons, List<Weapon> meleeWeapons)
        {
            AbstractUnit newUnit;

            switch (unitType)
            {
                case "Beast":
                    newUnit = new Beast(name, value, movement, toughness, safe, wounds, leadership, x, y, objectiveControle, rangeWeapons, meleeWeapons);
                    addUnit(newUnit);

                    break;
                case "Infantry":
                    newUnit = new Infantry(name, value, movement, toughness, safe, wounds, leadership, x, y, objectiveControle, rangeWeapons, meleeWeapons);
                    addUnit(newUnit);

                    break;
                case "Vehicle":
                    newUnit = new Vehicle(name, value, movement, toughness, safe, wounds, leadership, x, y, objectiveControle, rangeWeapons, meleeWeapons);
                    addUnit(newUnit);

                    break;
                default:
                    throw new ArgumentException($"Unknown unit type: '{unitType}'");
            }
        }

        public List<AbstractUnit> getUnits() { return units; }

        public List<AbstractUnit> createArmy(Dictionary<string, int> unitCounts)
        {
            List<AbstractUnit> newArmy = new List<AbstractUnit>();

            foreach (var unit in unitCounts)
            {
                string unitName = unit.Key;
                int amount = unit.Value;

                AbstractUnit existingUnit = getUnitFromList(unitName);

                if (existingUnit != null)
                {
                    for (int i = 0; i < amount; i++)
                    {
                        newArmy.Add(existingUnit);
                    }
                }
                else
                {
                    throw new ArgumentException($"Unit '{unitName}' does not exist in the faction.");
                }

            }

            return newArmy;
        }

        private AbstractUnit getUnitFromList(string unitName)
        {
            foreach (var unit in units)
            {
                if (unit.getName() == unitName)
                {
                    return unit;
                }
            }
            return null;
        }
    }
}
