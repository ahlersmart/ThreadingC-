using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    internal class Shooting : Phase
    {
        public bool doPhase(Grid grid, int currentRow, int currentColumn, int targetRow, int targetColumn, int playerRound)
        {
            return grid.rangeAttack(currentRow, currentColumn, targetRow, targetColumn, playerRound);
        }
    }
}
