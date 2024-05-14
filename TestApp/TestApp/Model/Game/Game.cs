using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Model.Game.Gamemode;
using TestApp.Model.Game.Phase;


namespace TestApp.Model.Game
{
    internal class Game
    {
        private Gamemode.Gamemode gamemode;
        private List<Phase.Phase> phases;
        private Phase.Phase currentPhase;
        private ArmyList redArmy;
        private ArmyList blueArmy;
        private Boolean playerRound; // 0 for blue, 1 for red

        public Game(Gamemode.Gamemode gamemode, ArmyList blueArmy, ArmyList redArmy)
        {
            this.gamemode = gamemode;
            this.phases = new List<Phase.Phase>();
            setPhases();
            this.blueArmy = blueArmy;
            this.redArmy = redArmy;
            setRound();
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

        public Phase.Phase getCurrentPhase() { return currentPhase; }

        public String resign(ArmyList army)
        {
            if (army == redArmy)
            {
                return "Blue Army has won.";
            }
            else
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
            int number = rand.Next(1, 2);

            switch (number)
            {
                case 1:
                    this.playerRound = true; // true sets blueArmy as first
                    break;
                case 2:
                    this.playerRound = false; // false sets redArmy as first
                    break;

            }
        }

        public void nextRound()
        {
            if (playerRound == true)
            {
                playerRound = false;
            }
            else
            {
                playerRound = true;
            }
        }

        public void activatePhase()
        {
            switch (currentPhase)
            {
                case Phase.Morale _:
                Console.WriteLine("Activating Morale phase...");
                // Implement Morale phase logic here
                break;

            case Phase.Movement _:
                Console.WriteLine("Activating Movement phase...");
                // Implement Movement phase logic here
                break;

            case Phase.Shooting _:
                Console.WriteLine("Activating Shooting phase...");
                // Implement Shooting phase logic here
                break;

            case Phase.Charging _:
                Console.WriteLine("Activating Charging phase...");
                // Implement Charging phase logic here
                break;

            case Phase.Fighting _:
                Console.WriteLine("Activating Fighting phase...");
                // Implement Fighting phase logic here
                break;

            default:
                throw new InvalidOperationException("Unknown phase.");
            }
        }
    }
}
