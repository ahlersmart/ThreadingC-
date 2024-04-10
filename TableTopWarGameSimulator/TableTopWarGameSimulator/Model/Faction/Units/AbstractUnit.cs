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
        private bool ifUsed;

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
            ifUsed = false;
        }

        public string getName() { return name; }
        public void setName(string name) { this.name = name; }
        public int getValue() { return value; }
        public void setValue(int value) { this.value = value; }
        public int getMovement() { return movement; }
        public void setMovement(int movement) { this.movement = movement; }
        public int getToughness() { return toughness; }
        public void setToughness(int toughness) { this.toughness = toughness; }
        public int getSafe() { return safe; }
        public void setSafe(int safe) { this.safe = safe; }
        public int getMaxWounds() { return maxWounds; }
        public int getWounds() { return wounds; }
        public void setWounds() { wounds = maxWounds; }
        public int getLeadership() { return leadership; }
        public void setLeadership(int leadership) { this.leadership = leadership; }
        public int getX() { return x; }
        public void setX(int x) { this.x = x; }
        public int getY() { return y; }
        public void setY(int y) { this.y = y; }
        public int getObjectiveControle() { return objectiveControle; }
        public void setObjectiveControle(int objectiveControle) { this.objectiveControle = objectiveControle; }
        public List<Weapon> getRangeWeapons() { return rangeWeapons; }
        public void setRangeWeapons(List<Weapon> rangeWeapons) { this.rangeWeapons = rangeWeapons; }
        public List<Weapon> getMeleeWeapons() { return meleeWeapons; }
        public void setMeleeWeapons(List<Weapon> meleeWeapons) { this.meleeWeapons = meleeWeapons; }

        public void setIfUsed(bool value)
        {
            if (value == true)
            {
                if (ifUsed == false)
                {
                    ifUsed = true;
                }
                else
                {
                    throw new UnitStatusException();
                }
            }
            else if (value == false)
            {
                if (ifUsed == true)
                {
                    ifUsed = false;
                }
                else
                {
                    throw new UnitStatusException();
                }
            }
        }

        public void setAttacked(int attack)
        {
            wounds -= attack;
            if (wounds < 0)
            {
                wounds = 0;
            }
        }
    }
}
