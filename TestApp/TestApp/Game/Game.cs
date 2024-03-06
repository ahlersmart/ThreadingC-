using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Gamemode;
using TestApp.Game.Phase;


namespace TestApp.Game
{
    internal class Game
    {
        private Gamemode gamemode;
        private List<Phase> phases;

        public Game() {
            this.phases = new List<Phase>();
        }

    }
}
