using AudioUnit;
using Photos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTopWarGameSimulator.Model.Game;
using TableTopWarGameSimulator.Model.Game.Phase;
using TableTopWarGameSimulator.Model.Gamemode;

namespace TableTopWarGameSimulator.Model.Game
{
    internal class Game
    {
        private Gamemode.Gamemode gamemode;
        private List<Phase.Phase> phases;
        private Phase.Phase currentPhase; 

        public Game(Gamemode.Gamemode gamemode)
        {
            this.gamemode = gamemode;
            this.phases = new List<Phase.Phase>();
            setPhases();
        }

        public void setPhases()
        {
            var morale = new Morale();
            var movement = new Movement();
            var shooting = new Shooting();
            var charging = new Charging();
            var fighting = new Fighting();

            this.phases.Add(morale);   // first phase
            this.phases.Add(movement); // second phase
            this.phases.Add(shooting); // third phase
            this.phases.Add(charging); // fourth phase  
            this.phases.Add(fighting); // fifth phase 

            this.currentPhase = this.phases[0];
        }

        public void setNextPhase()
        {
            for (int i = 1; i < this.phases.Count; i++)
            {
                if (phases[i] == currentPhase)
                {
                    currentPhase = phases[i + 1];
                    break;
                }
            }
        }

        public Phase.Phase getCurrentPhas() {  return currentPhase; }
        
    }
}
