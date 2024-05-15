using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    internal class Movement : Phase
    {
        public bool doPhase(Grid grid, int currentRow, int currentColumn, int targetRow, int targetColumn, int playerRound)
        {
            return grid.move(currentRow, currentColumn, targetRow, targetColumn, playerRound); 
        }
    }
}
