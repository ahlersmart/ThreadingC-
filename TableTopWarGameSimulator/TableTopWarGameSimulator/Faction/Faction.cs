using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator.Faction
{
    internal class Faction
    {
        private ArrayList units = new ArrayList();

        public Faction() { }

        public void setUnit()
        {
            this.units.Add("test");
        }


    }
}
