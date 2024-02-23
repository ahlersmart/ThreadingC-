using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Google.Crypto.Tink.Shaded.Protobuf;

namespace TableTopWarGameSimulator.Faction.Armory
{
    internal class Armory
    {
        private ArrayList guns;
        private ArrayList melee;

        public Armory() {
            this.guns = new ArrayList();
            this.melee = new ArrayList();
        }

        public void setGun()
        {
            this.guns.Add("test");
        }

        public void setMelee()
        {
            this.melee.Add("test");
        }
    }
}
