using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TableTopWarGameSimulator
{
    //a class that represent the an army that can be played with
    internal class ArmyList
    {
        private string _armyName;
        private string _playerName;
        private List<AbstractUnit> _army;
        private string _faction;

        public string armyName
        {
            get => this._armyName;
            set => this._armyName = value;
        }

        public string playerName
        {
            get => this._playerName;
            set => this._playerName = value;
        }

        public List<AbstractUnit> army
        {
            get => this._army;
            set => this._army = value;
        }

        public string faction
        {
            get => this._faction;
            set => this._faction = value;
        }

        //and army belongs to a faction and has to have a list of units that will be used in the game
        public ArmyList(string armyName, string playerName, string faction)
        {
            this._armyName = armyName;
            this._playerName = playerName;
            this._faction = faction;
            _army = new List<AbstractUnit>(); // Initialize the army list


        }

        [JsonConstructor]
        public ArmyList(string armyName, string playerName, string faction, List<AbstractUnit> army) : this(armyName, playerName, faction)
        {
            this._army = army;
        }
        
        public AbstractUnit getUnit(int id)
        {
            return this._army[id];
        }

        public void addUnit(AbstractUnit unit)
        {
            this._army.Add(unit);
        }

        public string toJSON()
        {
            List<string> list = new() { this._armyName, this._playerName, JSONObject.ListToJSON(this._army), this._faction };
            string jsonString = JSONObject.ObjectToJSON(list);
            return jsonString;
        }

        public static ArmyList fromJSON(string jsonString)
        {
            List<string> list = (List<string>)JSONObject.JSONToObject(jsonString);
            string armyName = list[0];
            string playerName = list[1];
            List<AbstractUnit> army = JSONObject.JSONToList<AbstractUnit>(list[2]);
            string faction = list[3];


            return new ArmyList(armyName , playerName , faction, army);
        }
    }
}
