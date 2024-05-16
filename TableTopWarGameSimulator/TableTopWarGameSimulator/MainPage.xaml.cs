﻿using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http.Json;

namespace TableTopWarGameSimulator
{
    public partial class MainPage : ContentPage
    {
        private readonly HttpClient httpClient = new();
        public bool IsRefreshing { get; set; }
        public ObservableCollection<Monkey> Monkeys { get; set; } = new();
        private ObservableCollection<GridRow> GridGame { get; set; } = new();
        public Command RefreshCommand { get; set; }
        public Monkey SelectedMonkey { get; set; }
        private GridRow SelectedRow { get; set; }
        int count = 0;
        List<ArmyList> armies = new();
        Game game;

        public MainPage()
        {
            createArmies();
            this.game = new Game(armies[0], armies[1]);
            RefreshCommand = new Command(async () =>
            {
                await Task.Delay(2000);
                await LoadMap(armies[0], armies[1]);

                IsRefreshing = false;
                OnPropertyChanged(nameof(IsRefreshing));
            });

            foreach (GridRow row in GridGame)
            {
                Trace.WriteLine("Row 1:" + row.GridColumn0);
            }

            BindingContext = this;
            InitializeComponent();
        }

        protected async override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            await LoadMonkeys();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Monkeys.Clear();
        }

        private async Task LoadMonkeys()
        {
            var monkeys = await httpClient.GetFromJsonAsync<Monkey[]>("https://montemagno.com/monkeys.json");

            Monkeys.Clear();

            foreach (Monkey monkey in monkeys)
            {
                Monkeys.Add(monkey);
            }
        }

        private async Task LoadMap(ArmyList Army1, ArmyList Army2) 
        {
            await Task.Delay(1000);
            Grid gameGrid = new Grid(Army1, Army2);
            GridGame = gameGrid.grid;
            Debug.WriteLine("Test LoadMap Completed");
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
