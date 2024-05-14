using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    internal class Grid
    {
        private List<GridRow> _grid;

        public List<GridRow> grid
        {
            get => this._grid;
            set => _grid = value;
        }

        public Grid(ArmyList army1, ArmyList army2)
        {
            this._grid = new();
            for (int i = 0; i < 20; i++)
            {
                GridRow gridRow = new GridRow();
                this._grid.Add(gridRow);
            }

            inizialize(army1, army2);
        }

        private void inizialize(ArmyList army1, ArmyList army2)
        {
            int row = 0;
            int column = 1;
            foreach (AbstractUnit unit in army1.army)
            {
                this._grid[row].setUnit(column, unit, 0);

                if (column == 20)
                {
                    column = 1;
                    row++;
                }
                else
                {
                    column++;
                }
            }

            row = this._grid.Count;
            column = 1;
            foreach (AbstractUnit unit in army2.army)
            {
                this._grid[row].setUnit(column, unit, 1);

                if (column == 20)
                {
                    column = 1;
                    row--;
                }
                else
                {
                    column++;
                }
            }
        }

        public void setImage(int row, int column, string item)
        {
            if (row >= 0 && row <= 20)
            {
                this.grid[row].setImage(column, item);
            }
        }

        public void setUnit(int row, int column, AbstractUnit unit, int Army)
        {
            if (row >= 0 && row <= 20)
            {
                this.grid[row].setUnit(column, unit, Army);
            }
        }

    }
}
