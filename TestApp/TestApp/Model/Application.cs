using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Model.Game;

namespace TestApp.Model
{
    internal class Application
    {
        private Game.Game game;
        private List<Game.Gamemode.Gamemode> gamemode;
        private List<ArmyList> armyList;

        public Application()
        {
            this.gamemode = new List<Game.Gamemode.Gamemode>();
            this.armyList = new List<ArmyList>();
        }

        public void createGame(Game.Gamemode.Gamemode gamemode, ArmyList armyListRed, ArmyList armyListBlue)
        {
            this.game = new Game.Game(gamemode, armyListRed, armyListBlue);
        }
    }
}
