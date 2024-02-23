using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TableTopWarGameSimulator.Faction.Armory;

namespace TableTopWarGameSimulator.Faction.Units
{
    internal abstract class AbstractUnit
    {
        private String name;
        private int value, movement, toughness, safe, wounds, leadership; // unit values
        private int x, y; // position coordinates
        private int objectiveControle;
        private ArrayList rangeWeapons = new ArrayList();
        private ArrayList meleeWeapons = new ArrayList();

        protected AbstractUnit(string name, int value, int movement, int toughness, int safe, int wounds, int leadership, int x, int y, int objectiveControle, ArrayList rangeWeapons, ArrayList meleeWeapons)
        {
            this.name = name;
            this.value = value;
            this.movement = movement;
            this.toughness = toughness;
            this.safe = safe;
            this.wounds = wounds;
            this.leadership = leadership;
            this.x = x;
            this.y = y;
            this.objectiveControle = objectiveControle;
            this.rangeWeapons = rangeWeapons;
            this.meleeWeapons = meleeWeapons;
        }

        public String getName() { return name; }
        public int getValue() { return value; }
        public int getMovement() { return movement;} 
        public int getToughness() { return toughness; }
        public int getSafe() { return safe; }
        public int getWounds() {  return wounds; }
        public int getLeadership() {  return leadership; }
        public int getX() { return x; } 
        public int getY() { return y; }
        public int getObjectiveControle() {  return objectiveControle; }
        public ArrayList getRangeWeapons() {  return rangeWeapons; }
        public ArrayList getMeleeWeapons() { return meleeWeapons; }

    }
}
