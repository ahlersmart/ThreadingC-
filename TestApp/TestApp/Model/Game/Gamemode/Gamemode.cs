using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Model.Game.Gamemode
{
    internal class Gamemode
    {
        private string name;
        private List<Rule> rules;
        private List<Objective> objectives;
        public Gamemode(string name, List<Rule> rules, List<Objective> objectives)
        {
            this.name = name;
            this.rules = rules;
            this.objectives = objectives;
        }

        public string getName() { return name; }
        public List<Rule> getRules() { return rules; }
        public List<Objective> getObjectives() { return objectives; }

    }
}
