using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
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

        public Game(ArmyList blueArmy, ArmyList redArmy)
        {
            this._gamemode = new Gamemode("40kLite");
            this.phases = new Phase[3];
            setPhases();
            _grid = new Grid(blueArmy, redArmy);
            setRound();
        }

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

        public void nextPhase()
        {
            if (this._currentPhase == 2) 
            { 
                this._currentPhase = 0;
            } else
            {
                this._currentPhase++;
            }
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

        public int rollDice(int diceSize)
        {
            Random rand = new Random();
            int number = rand.Next(1, diceSize);
            return number;
        }

        public void setRound()
        {
            Random rand = new Random();
            int number = rand.Next(0, 1);
            this._playerRound = number;
        }

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

        public Boolean move(int currentRow, int currentColumn, int newRow, int newColumn)
        {
            return this._grid.move(currentRow, currentColumn, newRow, newColumn);
        }


    }
}
