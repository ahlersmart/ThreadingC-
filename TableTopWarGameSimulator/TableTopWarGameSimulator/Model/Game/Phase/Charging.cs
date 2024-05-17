using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    internal class Charging : Phase
    {
        public string name { get; set; }

        public Charging() {
            name = "Charging";
        }
        public bool doPhase(Grid grid, int currentRow, int currentColumn, int targetRow, int targetColumn, int playerRound)
        {
            throw new NotImplementedException();
        }
    }
}
