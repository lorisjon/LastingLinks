namespace GUIDemo;

public partial class AbsoluteLayoutDemo : ContentPage
{
	int count = 0;

	public AbsoluteLayoutDemo()
	{
		InitializeComponent();
	}


    private async void Anzeigen_Clicked(object sender, EventArgs e)
    {
        // WICHTIG: Damit die Navigation so funktioniert m�ssen die Namen in der Datei AppShell.xaml.cs registriert werden!
        await Shell.Current.GoToAsync("Anzeigen");
    }

    private async void BefehleAusfuhren_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("BefehleAusfuehren");
    }

    private async void WerteSetzen_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("WerteSetzen");
    }

    private async void TexteBearbeiten_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("TexteBearbeiten");
    }

    private async void StackLayout_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("StackLayoutDemo");
    }

    private async void AbsolutesLayout_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("AbsoluteLayoutDemo");
    }

    private async void GridDemo_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("GridDemo");
    }

    private async void FlexLayoutInteractiv_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("FlexLayoutInteractive");
    }

    private async void CollectionViewDemo_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("CollectionViewDemo");
    }

    private async void ListViewDemo_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("ListViewDemo");
    }

    private async void CarouselViewDemo_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("CarouselViewDemo");
    }
}