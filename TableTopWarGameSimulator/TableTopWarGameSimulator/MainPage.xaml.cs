using System.Diagnostics;

namespace TableTopWarGameSimulator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        List<ArmyList> armies = new();

        public MainPage()
        {
            InitializeComponent();
            createArmies();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private void createArmies()
        {
            Melee sword = new Melee(1, "Sword", 2);
            Melee tentacle = new Melee(1, "Tentacle", 1);
            Melee tankMelee = new Melee(1, "TankMelee", 1);
            Range gun = new Range(5, "Gun", 1);
            Range ray = new Range(5, "Ray", 2);
            Range cannon = new Range(5, "Cannon", 5);

            Armory soldierArmory = new();
            Armory beastArmory = new();
            Armory tankArmory = new();
            soldierArmory.addMelee(sword);
            soldierArmory.addRange(gun);
            beastArmory.addMelee(tentacle);
            beastArmory.addRange(ray);
            tankArmory.addMelee(tankMelee);
            tankArmory.addRange(cannon);

            List<Infantry> soldiers = new();
            List<Beast> beasts = new();
            List<Vehicle> tanks = new();
            List<AbstractUnit> army = new();
            for(int i = 0; i < 10; i++)
            {
                Infantry s1 = new Infantry("Soldier" + i, 1, 3, 10, 0, 10, 0, soldierArmory);
                Beast b1 = new Beast("Beast" + i, 2, 3, 15, 0, 15, 0, beastArmory);
                Vehicle t1 = new Vehicle("Tank" + i, 4, 3, 20, 0, 20, 0, tankArmory);
                soldiers.Add(s1);
                beasts.Add(b1);
                tanks.Add(t1);
            }
            foreach(Vehicle t1 in tanks)
            {
                army.Add(t1);
            }
            foreach (Beast b1 in beasts)
            {
                army.Add(b1);
            }
            foreach (Infantry s1 in soldiers)
            {
                army.Add(s1);
            }

            ArmyList blueArmy = new ArmyList("BlueArmy", "Player1", "Faction1", army);
            ArmyList RedArmy = new ArmyList("RedArmy", "Player2", "Faction1", army);
            this.armies.Add(blueArmy);
            this.armies.Add(RedArmy);
            
            /**
            List<string> list = new();
            foreach(ArmyList al in this.armies)
            {
                list.Add(al.toJSON());
            }
            JSONObject.WriteJSONToFile(list, "ArmyLists.json");

            List<string> list2 = JSONObject.ReadJSONFile("ArmyLists.json");
            List<ArmyList> armies2 = new();
            foreach (string s in list2)
            {
                armies2.Add(ArmyList.fromJSON(s));
            }
            **/
        }
    }

}
