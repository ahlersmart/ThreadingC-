namespace TableTopWarGameSimulator;

public partial class EditUnit : ContentPage
{
	public EditUnit()
	{
		InitializeComponent();
	}

    private void Button_Clicked_EditUnit(object sender, EventArgs e)
    {

    }

    private void Button_Clicked_Back(object sender, EventArgs e)
    {
        Navigation.PushAsync(new UnitOverview());
    }
}