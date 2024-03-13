using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using TableTopWarGameSimulator.Model.Exception;
using TableTopWarGameSimulator.Model.Faction.Armory;

namespace TableTopWarGameSimulator.Model.Faction.Units
{
    internal abstract class AbstractUnit
    {
        private string name;
        private int value, movement, toughness, safe, wounds, leadership; // unit values
        private static int maxWounds;
        private int x, y; // position coordinates
        private int objectiveControle;
        private List<Weapon> rangeWeapons;
        private List<Weapon> meleeWeapons;
        private Boolean ifUsed;

        protected AbstractUnit(string name, int value, int movement, int toughness, int safe, int wounds, int leadership, int x, int y, int objectiveControle, List<Weapon> rangeWeapons, List<Weapon> meleeWeapons)
        {
            this.name = name;
            this.value = value;
            this.movement = movement;
            this.toughness = toughness;
            this.safe = safe;
            this.wounds = wounds;
            maxWounds = wounds; // this. cant be used for static variables
            this.leadership = leadership;
            this.x = x;
            this.y = y;
            this.objectiveControle = objectiveControle;
            this.rangeWeapons = new List<Weapon>();
            this.meleeWeapons = new List<Weapon>();
            this.ifUsed = false;
        }

        public string getName() { return name; }
        public int getValue() { return value; }
        public int getMovement() { return movement; }
        public int getToughness() { return toughness; }
        public int getSafe() { return safe; }
        public int getWounds() { return wounds; }
        public int getLeadership() { return leadership; }
        public int getX() { return x; }
        public int getY() { return y; }
        public int getMaxWounds() { return maxWounds; }
        public int getObjectiveControle() { return objectiveControle; }
        public List<Weapon> getRangeWeapons() { return rangeWeapons; }
        public List<Weapon> getMeleeWeapons() { return meleeWeapons; }
        public Boolean getIfUsed() { return ifUsed; }

        // function checks if value does not match if used. if not match will update, if does thows exception
        public void setIfUsed(Boolean value) 
        { 
            if(value == true)
            {
                if(this.ifUsed == false)
                {
                    this.ifUsed = true;
                } else
                {
                    throw new UnitStatusException();
                }
            } else if(value == false)
            {
                if (this.ifUsed == true)
                {
                    this.ifUsed = false;
                } else
                {
                    throw new UnitStatusException();
                }
            }
        }

    }
}
