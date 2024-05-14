using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    internal class Faction
    {
        private string _name;
        private List<AbstractUnit> units;
        private SemaphoreSlim semaphore = new SemaphoreSlim(4);

        public string name
        {
            get => this._name;
            set => this._name = value;
        }

        public Faction(string name)
        {
            this.name = name;
            this.units = new List<AbstractUnit>();
        }

        public Faction(string name, List<AbstractUnit> units) : this(name)
        {
            this.units = units;
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
                    if (existingUnit.name == unit.name)
                    {
                        throw new ArgumentException($"Unit '{unit.name}' already exists in the faction.");
                    }
                }

                this.units.Add(unit);
            }
        }

        public void addNewUnit(string unitType, string name, int value, int movement, int toughness, int safe, int wounds, int leadership, List<Range> rangeWeapons, List<Melee> meleeWeapons)
        {
            AbstractUnit newUnit;

            switch (unitType)
            {
                case "Beast":
                    newUnit = new Beast(name, value, movement, toughness, safe, wounds, leadership, rangeWeapons, meleeWeapons);
                    addUnit(newUnit);

                    break;
                case "Infantry":
                    newUnit = new Infantry(name, value, movement, toughness, safe, wounds, leadership, rangeWeapons, meleeWeapons);
                    addUnit(newUnit);

                    break;
                case "Vehicle":
                    newUnit = new Vehicle(name, value, movement, toughness, safe, wounds, leadership, rangeWeapons, meleeWeapons);
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
                        Thread addUnitToArmyThread = new Thread(() =>
                        {
                            semaphore.Wait();
                            newArmy.Add(existingUnit);
                            semaphore.Release();
                        });

                        addUnitToArmyThread.Start();
                    }
                }
                else
                {
                    throw new ArgumentException($"Unit '{unitName}' does not exist in the faction.");
                }

            }

            Thread.Sleep(1000);
            while (semaphore.CurrentCount != 4) { }

            return newArmy;
        }

        public AbstractUnit getUnitFromList(string unitName)
        {
            foreach (var unit in units)
            {
                if (unit.name == unitName)
                {
                    return unit;
                }
            }
            return null;
        }

        public string toJSON()
        {
            List<string> list = new() { name, JSONObject.ListToJSON(units) };
            string jsonString = JSONObject.ObjectToJSON(list);
            return jsonString;
        }

        public static Faction fromJSON(string jsonString)
        {
            List<string> list = (List<string>)JSONObject.JSONToObject(jsonString);
            string name = list[0];
            List<AbstractUnit> units = JSONObject.JSONToList<AbstractUnit>(list[1]);
            return new Faction(name, units);
        }
    }
}
