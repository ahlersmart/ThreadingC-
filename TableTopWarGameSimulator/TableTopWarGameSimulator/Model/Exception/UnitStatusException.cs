﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator.Model.Exception
{
    internal class UnitStatusException : IOException
    {
        public UnitStatusException() 
            : base("status is already set to given value.")
        { }
    }
}