using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Faction.Armory
{
    internal class Armory
    {
        private List<Weapon> rangeList;
        private List<Weapon> meleeList;

        public Armory() {
            this.rangeList = new List<Weapon>();
            this.meleeList = new List<Weapon>();
        }

        public void addRange(Weapon weapon) { this.rangeList.Add(weapon); }
        public void addMelee(Weapon weapon) { this.meleeList.Add(weapon); }
        public List<Weapon> getRange() { return this.rangeList; }
        public List<Weapon> getMelee() { return this.meleeList; }
    }
}
