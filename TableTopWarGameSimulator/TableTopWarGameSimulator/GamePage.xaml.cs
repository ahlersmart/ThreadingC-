using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http.Json;

namespace TableTopWarGameSimulator
{
    public partial class GamePage : ContentPage
    {
        private readonly HttpClient httpClient = new();
        public bool IsRefreshing { get; set; }
        public ObservableCollection<GridRow> GridGame { get => gridGame; set => gridGame = value; }
        public Command RefreshCommand { get; set; }
        public GridRow SelectedRow { get; set; }
        private List<ArmyList> armies { get; set; } = new();
        private Game game { get; set; }
        private ObservableCollection<GridRow> gridGame = new();
        public string currentNotification { get; set; } = "Initial Notification";

        public GamePage()
        {
            readJson();
            this.game = new Game(armies[0], armies[1]);
            
            LoadMap();
            IsRefreshing = false;
            OnPropertyChanged(nameof(IsRefreshing));

            BindingContext = this;
            updateNotification("Notifications will show here.");
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            LoadMap();
        }

        private void LoadMap() 
        {
            Trace.WriteLine("Test Load Map Started");
            Grid gameGrid = game.grid;
            GridGame = gameGrid.grid;
            Trace.WriteLine("Test Map Loaded");
        }

        private void Button_Clicked_Confirm_Action(object sender, EventArgs e)
        {
            int xOne = locationPickerXOne.SelectedIndex;
            int yOne = locationPickerYOne.SelectedIndex;
            int xTwo = locationPickerXTwo.SelectedIndex;
            int yTwo = locationPickerYTwo.SelectedIndex;
            bool worked = this.game.phaseAction(xOne, yOne, xTwo, yTwo);
            LoadMap();
            //make if else statements for all phases
            if (this.game.currentPhase is Movement) { 
                if (worked)
                {
                    updateNotification("Action Performed. Unit Moved");
                } 
                else
                {
                    updateNotification("Invalid action. Movement can not be performed");
                }
            } 
            else if (this.game.currentPhase is Shooting)
            {
                if (worked)
                {
                    AbstractUnit U1 = this.game.grid.grid[xOne].getUnit(yOne).Item1;
                    Tuple<AbstractUnit, int> U2 = this.game.grid.grid[xTwo].getUnit(yTwo);
                    if (U2 == null || U2.Item1 == null)
                    {
                        updateNotification(attackMessage(xOne, yOne, xTwo, yTwo, U1.getUnitTypeString(), "Unit", true, 0));
                    }
                    else
                    {
                        updateNotification(attackMessage(xOne, yOne, xTwo, yTwo, U1.getUnitTypeString(), U2.Item1.getUnitTypeString(), false, U1.getRangeAttack().Item1));
                    }
                }
                else
                {
                    updateNotification("Attack missed or is invalid.");
                }
            }
            else if (this.game.currentPhase is Fighting)
            {
                if (worked)
                {
                    AbstractUnit U1 = this.game.grid.grid[xOne].getUnit(yOne).Item1;
                    Tuple<AbstractUnit, int> U2 = this.game.grid.grid[xTwo].getUnit(yTwo);
                    if (U2 == null || U2.Item1 == null)
                    {
                        updateNotification(attackMessage(xOne, yOne, xTwo, yTwo, U1.getUnitTypeString(), "Unit", true, 0));
                    }
                    else
                    {
                        updateNotification(attackMessage(xOne, yOne, xTwo, yTwo, U1.getUnitTypeString(), U2.Item1.getUnitTypeString(), false, U1.getMeleeDamage()));
                    }
                }
                else
                {
                    updateNotification("Attack missed or is invalid.");
                }
            }
            InitializeComponent();
        }

        private string attackMessage(int xOne, int yOne, int xTwo, int yTwo, string typeAttacker, string typeVictim, bool killed, int damage)
        {
            string s = typeAttacker + " (" + (xOne + 1) + "," + (yOne + 1) + ") has ";
            if (killed)
            {
                s += "killed ";
            }
            else
            {
                s += "hit ";
            }

            s += typeVictim + "(" + (xTwo + 1) + ", " + (yTwo + 1) + ") ";

            if (!killed)
            {
                s += "for " + damage + " Damage.";
            }
            return s;

        }

        private void Button_Clicked_Next_Phase(object sender, EventArgs e)
        {
            this.game.nextPhase();
            updateNotification("New Phase started");
            InitializeComponent();
        }

        private void readJson()
        {
            List<string> list = JSONObject.ReadJSONFile("ArmyLists.json");
            if(list.Count == 0) 
            {
                createArmies();
                List<string> jsonList = new();
                foreach (ArmyList al in this.armies)
                {
                    jsonList.Add(al.toJSON());
                }
                _ = JSONObject.WriteJSONToFileAsync(jsonList, "ArmyLists.json");
            }
            else
            {
                foreach (string s in list)
                {
                    armies.Add(ArmyList.fromJSON(s));
                }
            }
        }

        private void createArmies()
        {
            Melee sword = new Melee("Sword", 2);
            Melee tentacle = new Melee("Tentacle", 2);
            Melee tankMelee = new Melee("TankMelee", 1);
            Range gun = new Range(4, "Gun", 2);
            Range ray = new Range(4, "Ray", 2);
            Range cannon = new Range(4, "Cannon", 5);

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
                Infantry s1 = new Infantry("Soldier" + i, 1, 3, 2, 0, 10, 0, soldierArmory);
                Beast b1 = new Beast("Beast" + i, 2, 4, 3, 0, 12, 0, beastArmory);
                Vehicle t1 = new Vehicle("Tank" + i, 4, 3, 4, 0, 15, 0, tankArmory);
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
            armies.Add(blueArmy);
            armies.Add(RedArmy);


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

        private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            Picker newPicker = (Picker)sender;
            Picker currentPicker = this.FindByName<Picker>(newPicker.Title);
            currentPicker.SelectedIndex = newPicker.SelectedIndex;
        }

        private void updateNotification(string notification)
        {
            if (this.game.playerRound == 0)
            {
                this.currentNotification = "Blue Army is on the Move. ";
            }
            else if(this.game.playerRound == 1)
            {
                this.currentNotification = "Red Army is on the Move. ";
            }
            this.currentNotification += "Current phase is " + this.game.currentPhase.name + ". " + notification;
        }
    }

}
