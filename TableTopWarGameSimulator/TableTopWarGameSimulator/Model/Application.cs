using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTopWarGameSimulator.Model.Game;

namespace TableTopWarGameSimulator.Model
{
    internal class Application
    {
        private Game.Game game;
        private List<Game.Gamemode.Gamemode> gamemode;
        private List<ArmyList> armyList;

        public Application() { 
            this.gamemode = new List<Game.Gamemode.Gamemode>();
            this.armyList = new List<ArmyList>();
        }

        public void CreateGame(Game.Gamemode.Gamemode gamemode, ArmyList armyListRed, ArmyList armyListBlue)
        {
            this.game = new Game.Game(gamemode, armyListRed, armyListBlue);
        }
    }
}