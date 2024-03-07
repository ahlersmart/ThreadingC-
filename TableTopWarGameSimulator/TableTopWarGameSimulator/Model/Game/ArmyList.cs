using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTopWarGameSimulator.Model.Faction.Units;
using TableTopWarGameSimulator.Model.Faction;

namespace TableTopWarGameSimulator.Model.Game
{
    internal class ArmyList
    {
        private String armyName;
        private String playerName;
        private List<AbstractUnit> army;
        private Faction.Faction faction;

        public ArmyList(String armyName, String playerName, List<AbstractUnit> army, Faction.Faction faction) {
            this.armyName = armyName;
            this.playerName = playerName;  
            this.army = army;
            this.faction = faction;
        }

        public String getArmyName() {  return armyName; }
        public String getPlayerName() {  return playerName; }
        public List<AbstractUnit> getArmy() {  return army; }
        public Faction.Faction getFaction() {  return faction; }

    }
}
