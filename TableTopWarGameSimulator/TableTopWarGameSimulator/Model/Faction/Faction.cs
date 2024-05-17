using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    // Class that represent the factions a unit can belong to.
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

        // Faction holds a name and a list with units belonging to it
        public Faction(string name)
        {
            this.name = name;
            this.units = new List<AbstractUnit>();
        }

        public Faction(string name, List<AbstractUnit> units) : this(name)
        {
            this.units = units;
        }

        // Method to add a pre-created unit to the faction, ensuring no duplicates
        public void addUnit(AbstractUnit unit)
        {
            // If no unit exist in faction add unit
            if (units.Count == 0)
            {
                this.units.Add(unit);
            }
            else
            {
                // Loop to check if unit name is already in use
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

        // Method to create and add a new unit to the faction based on unit type
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

        // Method to create an army
        public List<AbstractUnit> createArmy(Dictionary<string, int> unitCounts)
        {
            List<AbstractUnit> newArmy = new List<AbstractUnit>();

            // Loop over each entry in the unitCounts dictionary
            foreach (var unit in unitCounts)
            {
                string unitName = unit.Key;
                int amount = unit.Value;

                AbstractUnit existingUnit = getUnitFromList(unitName);

                if (existingUnit != null)
                {
                    // Loop though amount of the selected unit to be added
                    for (int i = 0; i < amount; i++)
                    {
                        // Create new thread to add the unit to the army list
                        Thread addUnitToArmyThread = new Thread(() =>
                        {
                            semaphore.Wait();
                            newArmy.Add(existingUnit);
                            semaphore.Release();
                        });

                        // Start the thread
                        addUnitToArmyThread.Start(); 
                    }
                }
                else
                {
                    // Throw an exception if the unit does not exist in the faction
                    throw new ArgumentException($"Unit '{unitName}' does not exist in the faction.");
                }

            }

            // Allow time for all threads to finish adding units to the list
            Thread.Sleep(1000);
            while (semaphore.CurrentCount != 4) { }

            return newArmy;
        }

        // Method to retrieve a unit from the list by its name
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
