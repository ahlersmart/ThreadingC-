using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{ 
    public class GridRow
    {
        private string _GridColumn0;
        public string GridColumn0
        {
            get => this._GridColumn0;
            set => this._GridColumn0 = value;
        }

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

        private Tuple<AbstractUnit, int>[] units;

        static readonly string floor = "floor.png";
        static readonly string wall = "wall.png";
        static readonly string tankBlue = "bluetank.png";
        static readonly string infantryBlue = "bluesoldier.png";
        static readonly string beastBlue = "bluebeast.png";
        static readonly string tankRed = "redtank.png";
        static readonly string infantryRed = "redsoldier.png";
        static readonly string beastRed = "redbeast.png";


        public GridRow()
        {
            inizialize();
        }

        private void inizialize()
        {
            this._GridColumn0 = floor;
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

            units = new Tuple<AbstractUnit, int>[20];
        }

        public Tuple<AbstractUnit, int> getUnit(int column)
        {
            if (column >= 0 && column < 20)
            {
                return this.units[column];
            }
            else
            {
                return null;
            }
        }

        public void setImage(int column, string item)
        {
            if (column >= 0 && column < 20)
            {
                string image = GridRow.getImage(item);
                if (image != "")
                {
                    switch (column)
                    {
                        case 0:
                            this.GridColumn0 = image;
                            break;
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
                    }
                }
            }
        }

        public void setUnit(int column, AbstractUnit unit, int army)
        {
            if (column >= 0 && column < 20)
            {
                string image = GridRow.getImage(unit, army);
                if (image != "")
                {
                    this.units[column] = Tuple.Create(unit, army);
                    switch (column)
                    {
                        case 0:
                            this.GridColumn0 = image;
                            break;
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
                    }
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
                    return "";
            }
        }

        static string getImage(AbstractUnit unit, int Army)
        {
            if(Army == 0 || Army == 1)
            {
                if ( unit is Beast )
                {
                    if (Army == 0)
                    {
                        return GridRow.beastBlue;
                    } else if (Army == 1)
                    {
                        return GridRow.beastRed;
                    }
                } 
                else if ( unit is Vehicle )
                {
                    if (Army == 0)
                    {
                        return GridRow.tankBlue;
                    }
                    else if (Army == 1)
                    {
                        return GridRow.tankRed;
                    }
                } 
                else if ( unit is Infantry )
                {
                    if (Army == 0)
                    {
                        return GridRow.infantryBlue;
                    }
                    else if (Army == 1)
                    {
                        return GridRow.infantryRed;
                    }
                }
            }
            return "";
        }

        public Tuple<AbstractUnit, int> removeUnit( int column )
        {
            if ( column >= 0 && column < 20 )
            {
                this.setImage(column, "floor");
                Tuple<AbstractUnit, int> temp = units[column];
                units[column] = null;
                return temp;
            } 
            else
            {
                return null;
            }
        }

        public void attack(int column, int dmg)
        {
            if(column >= 0 && column < 20 )
            {
                if (this.units[column] != null && this.units[column].Item1 != null)
                {
                    int hp = this.units[column].Item1.setAttacked(dmg);
                    if (hp == 0)
                    {
                        this.removeUnit(column);
                    }
                }
            }
        }

        public void resetUsed()
        {
            for(int i = 0; i < this.units.Length; i++)
            {
                if (this.units[i] != null && this.units[i].Item1 != null)
                {
                    this.units[i].Item1.resetUsed();
                }
            }
        }

    }
}
