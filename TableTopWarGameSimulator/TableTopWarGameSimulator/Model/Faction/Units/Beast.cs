using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    internal class Beast : AbstractUnit
    {
        public Beast(string name, int value, int movement, int toughness, int safe, int hp, int leadership, List<Range> rangeWeapons, List<Melee> meleeWeapons) : base(name, value, movement, toughness, safe, hp, leadership, rangeWeapons, meleeWeapons)
        {
        }

        [JsonConstructor]
        public Beast(string name, int value, int movement, int toughness, int safe, int hp, int leadership, Armory armory) : base(name, value, movement, toughness, safe, hp, leadership, armory)
        {
        }
    }
}
