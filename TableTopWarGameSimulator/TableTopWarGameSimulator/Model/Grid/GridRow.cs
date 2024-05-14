using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Android.InputMethodServices.Keyboard;

namespace TableTopWarGameSimulator
{ 
    internal class GridRow
    {
        private string _GridColumn1;
        public string GridColumn1
        {
            get => this._GridColumn1;
            set => this._GridColumn1 = value;
        }

        private string _GridColumn2;
        public string GridColumn2
        {
            get => this._GridColumn2;
            set => this._GridColumn2 = value;
        }

        private string _GridColumn3;
        public string GridColumn3
        {
            get => this._GridColumn3;
            set => this._GridColumn3 = value;
        }

        private string _GridColumn4;
        public string GridColumn4
        {
            get => this._GridColumn4;
            set => this._GridColumn4 = value;
        }

        private string _GridColumn5;
        public string GridColumn5
        {
            get => this._GridColumn5;
            set => this._GridColumn5 = value;
        }

        private string _GridColumn6;
        public string GridColumn6
        {
            get => this._GridColumn6;
            set => this._GridColumn6 = value;
        }

        private string _GridColumn7;
        public string GridColumn7
        {
            get => this._GridColumn7;
            set => this._GridColumn7 = value;
        }

        private string _GridColumn8;
        public string GridColumn8
        {
            get => this._GridColumn8;
            set => this._GridColumn8 = value;
        }

        private string _GridColumn9;
        public string GridColumn9
        {
            get => this._GridColumn9;
            set => this._GridColumn9 = value;
        }

        private string _GridColumn10;
        public string GridColumn10
        {
            get => this._GridColumn10;
            set => this._GridColumn10 = value;
        }

        private string _GridColumn11;
        public string GridColumn11
        {
            get => this._GridColumn11;
            set => this._GridColumn11 = value;
        }

        private string _GridColumn12;
        public string GridColumn12
        {
            get => this._GridColumn12;
            set => this._GridColumn12 = value;
        }

        private string _GridColumn13;
        public string GridColumn13
        {
            get => this._GridColumn13;
            set => this._GridColumn13 = value;
        }

        private string _GridColumn14;
        public string GridColumn14
        {
            get => this._GridColumn14;
            set => this._GridColumn14 = value;
        }

        private string _GridColumn15;
        public string GridColumn15
        {
            get => this._GridColumn15;
            set => this._GridColumn15 = value;
        }

        private string _GridColumn16;
        public string GridColumn16
        {
            get => this._GridColumn16;
            set => this._GridColumn16 = value;
        }

        private string _GridColumn17;
        public string GridColumn17
        {
            get => this._GridColumn17;
            set => this._GridColumn17 = value;
        }

        private string _GridColumn18;
        public string GridColumn18
        {
            get => this._GridColumn18;
            set => this._GridColumn18 = value;
        }

        private string _GridColumn19;
        public string GridColumn19
        {
            get => this._GridColumn19;
            set => this._GridColumn19 = value;
        }

        private string _GridColumn20;
        public string GridColumn20
        {
            get => this._GridColumn20;
            set => this._GridColumn20 = value;
        }

        private AbstractUnit[] units;

        static readonly string floor = @".\images\Floor.png";
        static readonly string wall = @".\images\Wall.png";
        static readonly string tankBlue = @".\images\BlueTank.png";
        static readonly string infantryBlue = @".\images\BlueSoldier.png";
        static readonly string beastBlue = @".\images\BlueBeast.png";
        static readonly string tankRed = @".\images\RedTank.png";
        static readonly string infantryRed = @".\images\RedSoldier.png";
        static readonly string beastRed = @".\images\RedBeast.png";


        public GridRow()
        {
            inizialize();
        }

        private void inizialize()
        {
            this._GridColumn1 = floor;
            this._GridColumn2 = floor;
            this._GridColumn3 = floor;
            this._GridColumn4 = floor;
            this._GridColumn5 = floor;
            this._GridColumn6 = floor;
            this._GridColumn7 = floor;
            this._GridColumn8 = floor;
            this._GridColumn9 = floor;
            this._GridColumn10 = floor;
            this._GridColumn11 = floor;
            this._GridColumn12 = floor;
            this._GridColumn13 = floor;
            this._GridColumn14 = floor;
            this._GridColumn15 = floor;
            this._GridColumn16 = floor;
            this._GridColumn17 = floor;
            this._GridColumn18 = floor;
            this._GridColumn19 = floor;
            this._GridColumn20 = floor;

            units = new AbstractUnit[20];
        }

        public void setImage(int column, string item)
        {
            if (column >= 0 && column <= 20)
            {
                string image = GridRow.getImage(item);
                switch(column)
                {
                    case 1:
                        this.GridColumn1 = image;
                        break;
                    case 2:
                        this.GridColumn2 = image;
                        break;
                    case 3:
                        this.GridColumn3 = image;
                        break;
                    case 4:
                        this.GridColumn4 = image;
                        break;
                    case 5:
                        this.GridColumn5 = image;
                        break;
                    case 6:
                        this.GridColumn6 = image;
                        break;
                    case 7:
                        this.GridColumn7 = image;
                        break;
                    case 8:
                        this.GridColumn8 = image;
                        break;
                    case 9:
                        this.GridColumn9 = image;
                        break;
                    case 10:
                        this.GridColumn10 = image;
                        break;
                    case 11:
                        this.GridColumn11 = image;
                        break;
                    case 12:
                        this.GridColumn12 = image;
                        break;
                    case 13:
                        this.GridColumn13 = image;
                        break;
                    case 14:
                        this.GridColumn14 = image;
                        break;
                    case 15:
                        this.GridColumn15 = image;
                        break;
                    case 16:
                        this.GridColumn16 = image;
                        break;
                    case 17:
                        this.GridColumn17 = image;
                        break;
                    case 18:
                        this.GridColumn18 = image;
                        break;
                    case 19:
                        this.GridColumn19 = image;
                        break;
                    case 20:
                        this.GridColumn20 = image;
                        break;
                }
            }
        }

        public void setUnit(int column, AbstractUnit unit, int Army)
        {
            if (column >= 0 && column <= 20)
            {

                string image = GridRow.floor;
                if (unit is Beast)
                {
                    if (Army == 0)
                    {
                        image = GridRow.beastBlue;
                        units[column] = unit;
                    } 
                    else if (Army == 1)
                    {
                        image = GridRow.beastRed;
                        units[column] = unit;
                    }
                }
                else if (unit is Infantry)
                {
                    if (Army == 0)
                    {
                        image = GridRow.infantryBlue;
                        units[column] = unit;
                    }
                    else if (Army == 1)
                    {
                        image = GridRow.infantryRed;
                        units[column] = unit;
                    }
                }
                else if (unit is Vehicle)
                {
                    if (Army == 0)
                    {
                        image = GridRow.tankBlue;
                        units[column] = unit;
                    }
                    else if (Army == 1)
                    {
                        image = GridRow.tankRed;
                        units[column] = unit;
                    }
                }
                switch (column)
                {
                    case 1:
                        this.GridColumn1 = image;
                        break;
                    case 2:
                        this.GridColumn2 = image;
                        break;
                    case 3:
                        this.GridColumn3 = image;
                        break;
                    case 4:
                        this.GridColumn4 = image;
                        break;
                    case 5:
                        this.GridColumn5 = image;
                        break;
                    case 6:
                        this.GridColumn6 = image;
                        break;
                    case 7:
                        this.GridColumn7 = image;
                        break;
                    case 8:
                        this.GridColumn8 = image;
                        break;
                    case 9:
                        this.GridColumn9 = image;
                        break;
                    case 10:
                        this.GridColumn10 = image;
                        break;
                    case 11:
                        this.GridColumn11 = image;
                        break;
                    case 12:
                        this.GridColumn12 = image;
                        break;
                    case 13:
                        this.GridColumn13 = image;
                        break;
                    case 14:
                        this.GridColumn14 = image;
                        break;
                    case 15:
                        this.GridColumn15 = image;
                        break;
                    case 16:
                        this.GridColumn16 = image;
                        break;
                    case 17:
                        this.GridColumn17 = image;
                        break;
                    case 18:
                        this.GridColumn18 = image;
                        break;
                    case 19:
                        this.GridColumn19 = image;
                        break;
                    case 20:
                        this.GridColumn20 = image;
                        break;
                }
            }
        }

        static string getImage(string item)
        {
            switch(item.ToLower())
            {
                case "floor":
                    return GridRow.floor;
                case "wall":
                    return GridRow.wall;
                case "bluetank":
                    return GridRow.tankBlue;
                case "redtank":
                    return GridRow.tankRed;
                case "bluesoldier":
                    return GridRow.infantryBlue;
                case "redsoldier":
                    return GridRow.infantryRed;
                case "bluebeast":
                    return GridRow.beastBlue;
                case "redbeast":
                    return GridRow.beastRed;
                default:
                    return GridRow.floor;
            }
        }
        
    }
}
