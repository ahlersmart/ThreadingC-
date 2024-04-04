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

        private void GoToGameSummary(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GameSummary());
        }

        private void GoToUnitOverview(object sender, EventArgs e)
        {
            Navigation.PushAsync(new UnitOverview());
        }
    }

}
