namespace TableTopWarGameSimulator;

public partial class FactionOverview : ContentPage
{
	public FactionOverview()
	{
		InitializeComponent();
	}

    private void Button_Clicked_NewFaction(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_Back(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}