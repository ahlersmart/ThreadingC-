using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    //in the fighting face a mellee attack can be preformed
    internal class Fighting : Phase
    {
        public string name { get; set; }

        public Fighting() {
            name = "Fighting";
        }   
        public bool doPhase(Grid grid, int currentRow, int currentColumn, int targetRow, int targetColumn, int playerRound)
        {
            return grid.meleeAttack(currentRow, currentColumn, targetRow, targetColumn, playerRound);
        }
    }
}
