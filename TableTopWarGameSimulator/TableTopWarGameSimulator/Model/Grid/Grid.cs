using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableTopWarGameSimulator
{
    internal class Grid
    {
        private ObservableCollection<GridRow> _grid;

        public ObservableCollection<GridRow> grid
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
            int column = 0;
            foreach (AbstractUnit unit in army1.army)
            {
                this._grid[row].setUnit(column, unit, 0);

                if (column == 19)
                {
                    column = 0;
                    row++;
                }
                else
                {
                    column++;
                }
            }

            row = this._grid.Count-1;
            column = 0;
            foreach (AbstractUnit unit in army2.army)
            {
                this._grid[row].setUnit(column, unit, 1);

                if (column == 19)
                {
                    column = 0;
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
            if (row >= 0 && row < 20)
            {
                this.grid[row].setImage(column, item);
            }
        }

        public void setUnit(int row, int column, AbstractUnit unit, int Army)
        {
            if (row >= 0 && row < 20)
            {
                this.grid[row].setUnit(column, unit, Army);
            }
        }

        public bool move(int currentRow, int currentColumn, int newRow, int newColumn, int playerRound) 
        {
            if (currentRow >= 0 && currentRow < this._grid.Count && currentColumn >= 0 && currentColumn < 20 && newRow >= 0 && newRow < this._grid.Count && newColumn >= 0 && newColumn < 20)
            {
                GridRow currentGridRow = this._grid[currentRow];
                Tuple<AbstractUnit, int> unitTuple = currentGridRow.getUnit(currentColumn);
                if (unitTuple != null)
                {
                    AbstractUnit unit = unitTuple.Item1;
                    if (unit != null && !unit.ifUsed && unitTuple.Item2 == playerRound)
                    {
                        int rowDifference = currentRow - newRow;
                        int columnDifference = currentColumn - newColumn;
                        if (rowDifference < 0)
                        {
                            rowDifference = rowDifference * -1;
                        }
                        if (columnDifference < 0)
                        {
                            columnDifference = columnDifference * -1;
                        }
                        if (rowDifference <= unit.movement && columnDifference <= unit.movement)
                        {
                            GridRow newGridRow = this._grid[newRow];
                            Tuple<AbstractUnit, int> unitCheck = newGridRow.getUnit(newColumn);
                            if (unitCheck == null) 
                            {
                                unitTuple = currentGridRow.removeUnit(currentRow);
                                newGridRow.setUnit(newColumn, unitTuple.Item1, unitTuple.Item2);
                                unit.setUsed();
                                return true;
                            }
                            else
                            {
                                return false;
                            }
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool rangeAttack(int attackerRow, int attackerColumn, int targetRow, int targetColumn, int playerRound)
        {
            if (attackerRow >= 0 && attackerRow < this._grid.Count && attackerColumn >= 0 && attackerColumn < 20 && targetRow >= 0 && targetRow < this._grid.Count && targetColumn >= 0 &&  targetColumn < 20)
            {
                Tuple<AbstractUnit, int> attacker = this._grid[attackerRow].getUnit(attackerColumn);
                if(attacker != null && attacker.Item1 != null && !attacker.Item1.ifUsed && attacker.Item2 == playerRound)
                {
                    Tuple<AbstractUnit, int> target = this._grid[targetRow].getUnit(targetColumn);
                    if(target != null && target.Item1 != null && attacker.Item2 != target.Item2)
                    {
                        int rowDifference = targetRow - attackerRow;
                        int columnDifference = targetColumn - attackerColumn;
                        if (rowDifference < 0)
                        {
                            rowDifference = rowDifference * -1;
                        }
                        if (columnDifference < 0)
                        {
                            columnDifference = columnDifference * -1;
                        }
                        Tuple<int, int> weaponSpecs = attacker.Item1.getRangeAttack();
                        if (rowDifference <= weaponSpecs.Item2 && columnDifference <= weaponSpecs.Item2)
                        {
                            this._grid[targetRow].attack(targetColumn, weaponSpecs.Item1);
                            attacker.Item1.setUsed();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public bool meleeAttack(int attackerRow, int attackerColumn, int targetRow, int targetColumn, int playerRound)
        {
            if (attackerRow >= 0 && attackerRow < this._grid.Count && attackerColumn >= 0 && attackerColumn < 20 && targetRow >= 0 && targetRow < this._grid.Count && targetColumn >= 0 && targetColumn < 20)
            {
                int rowDifference = targetRow - attackerRow;
                int columnDifference = targetColumn - attackerColumn;
                if (rowDifference < 0)
                {
                    rowDifference = rowDifference * -1;
                }
                if (columnDifference < 0)
                {
                    columnDifference = columnDifference * -1;
                }
                if (rowDifference < 1 && columnDifference < 1)
                {
                    Tuple<AbstractUnit, int> attacker = this._grid[attackerRow].getUnit(attackerColumn);
                    if (attacker != null && attacker.Item1 != null && !attacker.Item1.ifUsed && attacker.Item2 == playerRound)
                    {
                        Tuple<AbstractUnit, int> target = this._grid[targetRow].getUnit(targetColumn);
                        if (target != null && target.Item1 != null && attacker.Item2 != target.Item2)
                        {
                            this._grid[targetRow].attack(targetColumn, target.Item1.getMeleeDamage());
                            attacker.Item1.setUsed();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }
        }

        public void resetUsed()
        {
            foreach(GridRow row in this._grid)
            {
                row.resetUsed();
            }
        }
    }
}
