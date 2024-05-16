namespace TableTopWarGameSimulator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoToFaction(object sender, EventArgs e)
        {
            Navigation.PushAsync(new FactionOverview());
        }

        private void GoToGame(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GamePage());
        }

        private void GoToUnitOverview(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UnitOverview());
        }
    }

}
