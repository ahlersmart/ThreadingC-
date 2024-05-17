using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    //This class has all functions a games performes
    internal class Game
    {
        private Gamemode _gamemode;
        private Phase[] phases;
        private int _currentPhase;
        private Grid _grid;
        private int _playerRound;

        public Gamemode gamemode
        {
            get => this._gamemode;
            set => this._gamemode = value;
        }

        public Phase currentPhase
        {
            get => this.phases[this._currentPhase];
        }

        public Grid grid
        {
            get => this._grid;
            set => this._grid = value;
        }
        
        public int playerRound
        {
            get => this._playerRound;
            set => this._playerRound = value;
        }

        //a game needs the phases it uses and the armies that are playing. It will make a grid with this.
        //this grid is what is played on.
        public Game(ArmyList blueArmy, ArmyList redArmy)
        {
            this._gamemode = new Gamemode("40kLite");
            this.phases = new Phase[3];
            setPhases();
            _grid = new Grid(blueArmy, redArmy);
            playerRound = 0;
        }

        //set the phases that will be used this game.
        public void setPhases()
        {
            var movement = new Movement();
            var shooting = new Shooting();
            var fighting = new Fighting();

            this.phases[0] = movement;
            this.phases[1] = shooting;
            this.phases[2] = fighting;

            this._currentPhase = 0;
        }

        //go to the next phase and reset all units to not used jet. if the last phase has been used change the turn to the other team.
        public void nextPhase()
        {
            if (this._currentPhase == 2) 
            { 
                this._currentPhase = 0;
                this.nextRound();
            } else
            {
                this._currentPhase++;
            }
            this._grid.resetUsed();
        }
        
        public string resign(int army)
        {
            if (army == 0)
            {
                return "Blue Army has won.";
            } else
            {
                return "Red Army has won.";
            }
        }
        
        //roll a d6rice
        public int rollDice()
        {
            return DiceRoller.rollD6();
        }

        //set the round to the next player
        public void nextRound()
        {
            if (this._playerRound == 0)
            {
                this._playerRound = 1;
            } 
            else if (this._playerRound == 1)
            {
                this._playerRound = 0;
            }
        }

        //depending on the current phase an action will be performed. currently this can be moving, meleeatack or rangeattack
        public bool phaseAction(int currentRow, int currentColumn, int newRow, int newColumn)
        {
            return this.currentPhase.doPhase(this._grid, currentRow, currentColumn, newRow, newColumn, this._playerRound);
        }

    }
}
