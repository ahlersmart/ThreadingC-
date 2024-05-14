using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    internal class ArmyList
    {
        private String armyName;
        private String playerName;
        private List<AbstractUnit> army;
        private string faction;

        public ArmyList(string armyName, string playerName, string faction)
        {
            this.armyName = armyName;
            this.playerName = playerName;
            this.faction = faction;
            army = new List<AbstractUnit>(); // Initialize the army list


        }

        public ArmyList(string armyName, string playerName, string faction, List<AbstractUnit> army)
             : this(armyName, playerName, faction)
        {
            this.army = army;
        }

        public String getArmyName() { return armyName; }
        public void setArmyName(string armyName) { this.armyName = armyName; }
        public String getPlayerName() { return playerName; }
        public void setPlayerName(string playerName) { this.playerName = playerName; }
        public string getFaction() { return faction; }
        public void setFaction(string faction) { this.faction = faction; }
        public List<AbstractUnit> getArmy() { return army; }
        public void setArmy(List<AbstractUnit> army) { this.army = army; }
    }
}
