namespace MauiAppHotel3.Views;

public partial class NossoEspaco : ContentPage
{
	public NossoEspaco()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PopAsync();
		} catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
    }
}