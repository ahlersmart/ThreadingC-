namespace TableTopWarGameSimulator;

public partial class ScoreScreen : ContentPage
{
	public ScoreScreen()
	{
		InitializeComponent();
	}

    private void Button_Clicked_Back(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GamePage());
    }

    private void Button_Clicked_EditScore(object sender, EventArgs e)
    {

    }
}