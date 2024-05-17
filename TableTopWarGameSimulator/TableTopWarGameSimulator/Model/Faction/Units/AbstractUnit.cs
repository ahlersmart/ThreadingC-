using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    //Class to represent the unit for the game
    public class AbstractUnit
    {
        private string _name;
        private int _value, _movement, _toughness, _safe, _hp, _leadership; // unit values
        private readonly int _maxHP;
        private Armory _armory;
        private bool _ifUsed;

        public string name
        {
            get => this._name;
            set => this._name = value;
        }

        public int value
        {
            get => this._value;
            set => this._value = value;
        }

        public int movement
        {
            get => this._movement;
            set => this._movement = value;
        }

        public int toughness
        {
            get => this._toughness;
            set => this._toughness = value;
        }

        public int safe
        {
            get => this._safe;
            set => this._safe = value;
        }

        public int hp
        {
            get => this._hp;
            set => this._hp = value;
        }

        public int leadership
        {
            get => this._leadership;
            set => this._leadership = value;
        }

        public int maxHP
        {
            get => this._maxHP;
        }

        public bool ifUsed
        {
            get => this._ifUsed;
        }

        public Armory armory { get; set; }

        //a unit will have a name. a score value. an amount of movement. minimal dice roll to hit. how much life is left and weapons
        public AbstractUnit(string name, int value, int movement, int toughness, int safe, int hp, int leadership, Armory armory)
        {
            this._name = name;
            this._value = value;
            this._movement = movement;
            this._toughness = toughness;
            this._safe = safe;
            this._hp = hp;
            this._maxHP = hp;
            this._leadership = leadership;
            this._armory = armory;
            this._ifUsed = false;
        }

        protected AbstractUnit(string name, int value, int movement, int toughness, int safe, int hp, int leadership, List<Range> rangeWeapons, List<Melee> meleeWeapons) : this(name, value,  movement, toughness, safe, hp, leadership, new Armory(rangeWeapons, meleeWeapons))
        {
        }

        public List<Range> getRangeWeapons() { return this._armory.rangeList; }
        public void setRangeWeapons(List<Range> rangeWeapons) { this._armory.rangeList = rangeWeapons; }
        public List<Melee> getMeleeWeapons() { return this._armory.meleeList; }
        public void setMeleeWeapons(List<Melee> meleeWeapons) { this._armory.meleeList = meleeWeapons; }

        //see if unit is already used
        public bool getIfUser()
        {
            return _ifUsed;
        }

        //set a unit to used
        public void setUsed()
        {
            this._ifUsed = true;
        }

        //set a unit to unused
        public void resetUsed()
        {
            this._ifUsed = false;
        }

        //the change in life when attacked
        public int setAttacked(int attack)
        {
            _hp -= attack;
            if (_hp < 0)
            {
                _hp = 0;
            }
            return _hp;
        }

        //returns an item with the damage as the first integer and the range as the second.
        public Tuple<int, int> getRangeAttack()
        {
            return this._armory.getRangeAttack();
        }

        //return the damage for a melee attack
        public int getMeleeDamage()
        {
            return this._armory.getMeleeDamage();
        }

        //returns a string with which type of unit it is.
        public string getUnitTypeString()
        {
            if (this is Infantry)
            {
                return "Soldier";
            }
            else if (this is Beast)
            {
                return "Beast";
            } 
            else if (this is Vehicle)
            {
                return "Tank";
            }
            else
            {
                return "Unit";
            }
        }

        public string toJSON()
        {
            return JSONObject.ObjectToJSON(this);
        }

        public static AbstractUnit fromJSON(string jsonString)
        {
            return (AbstractUnit) JSONObject.JSONToObject(jsonString);
        }
    }
}
