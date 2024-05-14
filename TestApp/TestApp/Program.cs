using System;
using System.Collections.Generic;
using TestApp.Model.Faction;
using TestApp.Model.Faction.Armory;
using TestApp.Model.Faction.Units;
using TestApp.Model.Game.Gamemode;
using TestApp.Model.Game;
using TestApp.Model;
using Range = TestApp.Model.Faction.Armory.Range;

class Program
{
    static void Main(string[] args)
    {

        Application application = new Application();

        // Create game mode
        Gamemode gamemode = new Gamemode("Standard", new List<Rule>(), new List<Objective>());

        // Create armies
        Faction redFaction = new Faction("Red Faction");
        Faction blueFaction = new Faction("Blue Faction");

        // Add units to factions
        redFaction.addNewUnit("Beast", "Red Beast 1", 1, 12, 20, 3, 0, 1, 1, 3, 0, null, null);
        redFaction.addNewUnit("Infantry", "Red Infantry 1", 1, 12, 20, 3, 0, 1, 1, 3, 1, null, null);

        blueFaction.addNewUnit("Beast", "Blue Beast 1", 1, 12, 20, 3, 0, 1, 1, 3, 0, null, null);
        blueFaction.addNewUnit("Infantry", "Blue Infantry 1", 1, 12, 20, 3, 0, 1, 1, 3, 1, null, null);

        // Create army lists
        ArmyList redArmyList = new ArmyList("Red Army", "Player 1", "Red Faction", redFaction.getUnits());
        ArmyList blueArmyList = new ArmyList("Blue Army", "Player 2", "Blue Faction", blueFaction.getUnits());

        // Create the game
        application.createGame(gamemode, redArmyList, blueArmyList);
    }
}
