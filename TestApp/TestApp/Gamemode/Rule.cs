using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Gamemode
{
    internal class Rule
    {
        private string description;

        public Rule(string description) 
        { 
            this.description = description; 
        }

        public string getDescription() { return description; }
    }
}
