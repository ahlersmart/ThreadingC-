using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    //the moral phase
    internal class Morale : Phase
    {
        public string name { get; set; }

        public Morale() {
            name = "Morale";
        } 
        public bool doPhase(Grid grid, int currentRow, int currentColumn, int targetRow, int targetColumn, int playerRound)
        {
            throw new NotImplementedException();
        }
    }
}
