namespace TableTopWarGameSimulator.Model.Faction.Armory
{
    internal class Armory
    {
        private List<Weapon> rangeList;
        private List<Weapon> meleeList;

        public Armory()
        {
            rangeList = new List<Weapon>();
            meleeList = new List<Weapon>();
        }

        public void addRange(Weapon weapon) { rangeList.Add(weapon); }
        public void addMelee(Weapon weapon) { meleeList.Add(weapon); }
        public List<Weapon> getRange() { return rangeList; }
        public List<Weapon> getMelee() { return meleeList; }
    }
}
