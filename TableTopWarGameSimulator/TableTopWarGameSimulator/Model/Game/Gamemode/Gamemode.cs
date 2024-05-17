using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    //calss that represent the gamemodes that can be played.
    internal class Gamemode
    {
        private string _name;
        private List<Rule> _rules;
        private List<Objective> _objectives;
        
        public string name
        {
            get => this._name;
            set => this._name = value;
        }

        public List<Rule> rules
        {
            get => this._rules;
            set => this._rules = value;
        }

        public List<Objective> objectives
        {
            get => _objectives;
            set => _objectives = value;
        }

        public Gamemode(string name)
        {
            this._name = name;
            this._rules = new List<Rule>();
            this._objectives = new List<Objective>();
        }

        public Gamemode(string name, List<Rule> rules, List<Objective> objectives) : this(name)
        {
            this._rules = rules;
            this._objectives = objectives;
        }

        public Rule getRule(int id)
        {
            return this.rules[id];
        }

        public void addRule(Rule rule)
        {
            this._rules.Add(rule);
        }

    }
}
