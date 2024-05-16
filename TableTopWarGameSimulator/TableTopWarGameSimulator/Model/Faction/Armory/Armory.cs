using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    public class Armory
    {
        private List<Range> _rangeList;
        private List<Melee> _meleeList;

        public List<Range> rangeList
        {
            get => this._rangeList;
            set => this._rangeList = value;
        }

        public List<Melee> meleeList
        {
            get => this._meleeList;
            set => this._meleeList = value;
        }

        public Armory()
        {
            this._rangeList = new List<Range>();
            this._meleeList = new List<Melee>();
        }

        public Armory(List<Range> rangeList, List<Melee> meleeList)
        {
            this._rangeList = rangeList;
            this._meleeList = meleeList;
        }

        public void addRange(Weapon weapon) 
        { 
            if (weapon is Range)
            {
                this._rangeList.Add((Range) weapon);
            }
        }
        public void addMelee(Weapon weapon) 
        {
            if (weapon is Melee)
            {
                this._meleeList.Add((Melee)weapon);
            }
        }

        public Tuple<int, int> getRangeAttack()
        {
            if (this._rangeList.Count > 0)
            {
                return new Tuple<int, int>(this._rangeList[0].dmg, this._rangeList[0].distance);
            }
            else
            {
                return new Tuple<int, int>(0, 0);
            }
        }

        public int getMeleeDamage()
        {
            if(this._meleeList.Count > 0)
            {
                return this._meleeList[0].dmg;
            }
            else
            {
                return 0;
            }
        }

        public string toJSON()
        {
            return JSONObject.ObjectToJSON(this);

        }

        public static Armory fromJSON(string jsonString)
        {
            return (Armory) JSONObject.JSONToObject(jsonString);

        }
    }
}
