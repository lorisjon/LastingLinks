using Microsoft.Maui.Layouts;
using System.Collections.ObjectModel;
using System.ComponentModel;
namespace GUIDemo;

public partial class FlexLayoutInteractive : ContentPage, INotifyPropertyChanged
{

    int count = 0;


    private double _sliderValue;
    public double SliderValue
    {
        get => _sliderValue;
        set
        {
            _sliderValue = value;
            OnPropertyChanged(nameof(SliderValue));
            OnPropertyChanged(nameof(SliderValueAsInt)); // Aktualisiert Label
        }
    }

    public int SliderValueAsInt => (int)Math.Round(_sliderValue);

    public FlexLayoutInteractive()
	{
		InitializeComponent();
        BindingContext = this; // Setzt die aktuelle Seite als BindingContext
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }




    private async void Anzeigen_Clicked(object sender, EventArgs e)
    {
        // WICHTIG: Damit die Navigation so funktioniert müssen die Namen in der Datei AppShell.xaml.cs registriert werden!
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