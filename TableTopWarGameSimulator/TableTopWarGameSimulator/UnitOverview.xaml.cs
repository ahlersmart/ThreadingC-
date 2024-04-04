namespace TableTopWarGameSimulator;

public partial class UnitOverview : ContentPage
{
	public UnitOverview()
	{
		InitializeComponent();
	}

    private void Button_Clicked_Back(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void Button_Clicked_EditUnit(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_NewUnit(object sender, EventArgs e)
    {

    }
}