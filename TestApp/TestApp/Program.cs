using System;
using System.Collections.Generic;
using TestApp.Faction;
using TestApp.Faction.Armory;
using TestApp.Faction.Units;
using Range = TestApp.Faction.Armory.Range;

class Program
{
    static void Main(string[] args)
    {
        Faction faction = new Faction();

        // Create weapons for units
        var melee = new Melee(11, "Buzzer");
        var range = new Range(11, "Pew Pew");

        // Add weapons to the armory
        var armory = new Armory();
        armory.addMelee(melee);
        armory.addRange(range);


        // Create units using faction class
        faction.addNewUnit("Beast", "Warg", 1, 12, 20, 3, 0, 1, 1, 3, 0, armory.getMelee(), armory.getRange());
        faction.addNewUnit("Infantry", "Orc", 1, 12, 20, 3, 0, 1, 1, 3, 1, armory.getMelee(), armory.getRange());
        faction.addNewUnit("Vehicle", "Wheels", 1, 12, 20, 3, 0, 1, 1, 3, 0, armory.getMelee(), armory.getRange());

        // Display all units in the faction
        Console.WriteLine("Units in faction:");
        foreach (var unit in faction.getUnits())
        {
            Console.WriteLine(unit.getName());
        }

        // Define the desired army composition
        Dictionary<string, int> unitCounts = new Dictionary<string, int>
        {
            { "Warg", 3 },
            { "Orc", 2 },
            { "Wheels", 1 }
        };

        try
        {
            // Create the army using faction class
            List<AbstractUnit> army = faction.createArmy(unitCounts);
            Console.WriteLine("\nArmy created successfully:");
            foreach (var unit in army)
            {
                Console.WriteLine(unit.getName());
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("\nError creating army: " + ex.Message);
        }
    }
}
