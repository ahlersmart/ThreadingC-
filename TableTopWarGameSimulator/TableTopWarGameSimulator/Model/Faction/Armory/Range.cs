﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator.Model.Faction.Armory
{
    internal class Range : Weapon
    {
        public Range(int distance, string name) : base(distance, name)
        {
        }
    }
}