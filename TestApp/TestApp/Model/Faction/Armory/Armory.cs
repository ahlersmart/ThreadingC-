using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Model.Faction.Armory
{
    internal class Armory
    {
        private List<Weapon> rangeList;
        private List<Weapon> meleeList;

        public Armory()
        {
            rangeList = new List<Weapon>();
            meleeList = new List<Weapon>();
        }

        public void addRange(Weapon weapon) { rangeList.Add(weapon); }
        public void addMelee(Weapon weapon) { meleeList.Add(weapon); }
        public List<Weapon> getRange() { return rangeList; }
        public List<Weapon> getMelee() { return meleeList; }
    }
}
