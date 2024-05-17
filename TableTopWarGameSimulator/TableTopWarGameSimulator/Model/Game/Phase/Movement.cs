using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    //in the movement phase units can move around on the board
    internal class Movement : Phase
    {
        public string name { get; set; }

        public Movement() {
            name = "Movement";
        }

        public bool doPhase(Grid grid, int currentRow, int currentColumn, int targetRow, int targetColumn, int playerRound)
        {
            return grid.move(currentRow, currentColumn, targetRow, targetColumn, playerRound); 
        }
    }
}
