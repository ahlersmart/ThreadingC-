using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    //Class to represent a weapon for the game
    public abstract class Weapon
    {
        private int _distance;
        private string _name;
        private int _dmg;

        public int distance
        {
            get => this._distance;
            set => this._distance = value;
        }

        public string name
        {
            get => this._name;
            set => this._name = value;
        }
        
        public int dmg
        {
            get => this._dmg;
            set => this._dmg = value;
        }

        //Weapon will hold a distance for attacking and how much damage it does
        public Weapon(int distance, string name, int dmg)
        {
            this._distance = distance;
            this._name = name;
            this._dmg = dmg;
        }

        public string toJSON()
        {
            return JSONObject.ObjectToJSON(this);
        }

        public static Weapon fromJSON(string jsonString)
        {
            return (Weapon) JSONObject.JSONToObject(jsonString);
        }
    }
}
