using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    internal abstract class AbstractUnit
    {
        private string _name;
        private int _value, _movement, _toughness, _safe, _wounds, _leadership; // unit values
        private readonly int _maxWounds;
        private Armory _armory;
        private bool ifUsed;

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

        public int wounds
        {
            get => this._wounds;
            set => this._wounds = value;
        }

        public int leadership
        {
            get => this._leadership;
            set => this._leadership = value;
        }

        public int maxWounds
        {
            get => this._maxWounds;
        }

        public Armory armory { get; set; }

        protected AbstractUnit(string name, int value, int movement, int toughness, int safe, int wounds, int leadership, List<Range> rangeWeapons, List<Melee> meleeWeapons)
        {
            this._name = name;
            this._value = value;
            this._movement = movement;
            this._toughness = toughness;
            this._safe = safe;
            this._wounds = wounds;
            this._maxWounds = wounds;
            this._leadership = leadership;
            this._armory = new Armory(rangeWeapons, meleeWeapons);
            ifUsed = false;
        }

        protected AbstractUnit(string name, int value, int movement, int toughness, int safe, int wounds, int leadership, Armory armory)
        {
            this._name = name;
            this._value = value;
            this._movement = movement;
            this._toughness = toughness;
            this._safe = safe;
            this._wounds = wounds;
            this._maxWounds = wounds;
            this._leadership = leadership;
            this._armory = armory;
            ifUsed = false;
        }

        public List<Range> getRangeWeapons() { return this._armory.rangeList; }
        public void setRangeWeapons(List<Range> rangeWeapons) { this._armory.rangeList = rangeWeapons; }
        public List<Melee> getMeleeWeapons() { return this._armory.meleeList; }
        public void setMeleeWeapons(List<Melee> meleeWeapons) { this._armory.meleeList = meleeWeapons; }

        public bool getIfUser()
        {
            return ifUsed;
        }

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
            _wounds -= attack;
            if (_wounds < 0)
            {
                _wounds = 0;
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
