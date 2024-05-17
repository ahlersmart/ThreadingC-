using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    //in the shooting face a range attack can be preformed
    internal class Shooting : Phase
    {
        public string name { get; set; }

        public Shooting() {
            name = "Shooting";
        }
        public bool doPhase(Grid grid, int currentRow, int currentColumn, int targetRow, int targetColumn, int playerRound)
        {
            return grid.rangeAttack(currentRow, currentColumn, targetRow, targetColumn, playerRound);
        }
    }
}
