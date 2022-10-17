namespace GUIDemo;

public partial class BefehleAusfuehren : ContentPage
{
	public BefehleAusfuehren()
	{
		InitializeComponent();
	}
    private async void NormalButton_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Button", "Button_Clicked Event", "OK");
    }

    private async void BildButton_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("ImageButton", "Button_Clicked Event", "OK");
    }

    private async void SuchLeiste_TextChanged(object sender, TextChangedEventArgs e)
    {
        await DisplayAlert("SearchBar", $"TextChanged, aktueller Wert '{SuchLeiste.Text}'", "OK");
    }

    private async void OnFavoriteSwipeItemInvoked(object sender, EventArgs e)
    {
        await DisplayAlert("Favorite", "SwipeItemInvoked Event", "OK");
    }
    private async void OnDeleteSwipeItemInvoked(object sender, EventArgs e)
    {
        await DisplayAlert("Delete", "SwipeItemInvoked Event", "OK");
    }
}