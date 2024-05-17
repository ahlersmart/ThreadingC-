using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    //Phases are the differend stages in the game
    interface Phase
    {
        public string name { get; set; }
        bool doPhase(Grid grid, int currentRow, int currentColumn, int targetRow, int targetColumn, int playerRound);
    }
}
