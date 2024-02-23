using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator.Gamemode
{
    internal class Gamemode
    {
        private string name;
        private ArrayList rules = new ArrayList();
        private ArrayList objectives = new ArrayList();
        public Gamemode(string name, ArrayList rules, ArrayList objectives)
        {
            this.name = name;
            this.rules = rules;
            this.objectives = objectives;
        }
    }
}
