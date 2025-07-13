using Microsoft.Maui.Storage; // Für Preferences

namespace GUIDemo;

public partial class BefehleAusfuehren : ContentPage
{
    public BefehleAusfuehren()
    {
        InitializeComponent();
        LoadSettings(); // Einstellungen beim Start der Seite laden
    }

    private void LoadSettings()
    {
        // Lade gespeicherte Werte oder setze Standardwerte
        string notifications = Preferences.Get("Notifications", "On");
        string language = Preferences.Get("Language", "English"); 

        // Setze die Picker-Auswahl basierend auf den gespeicherten Werten
        NotificationsPicker.SelectedItem = notifications;
        LanguagePicker.SelectedItem = language;
    }

    private async void SaveChangesButton_Clicked(object sender, EventArgs e)
    {
        // Speichere die aktuellen Werte aus den Pickern
        if (NotificationsPicker.SelectedItem is string selectedNotification)
        {
            Preferences.Set("Notifications", selectedNotification);
        }

        if (LanguagePicker.SelectedItem is string selectedLanguage)
        {
            Preferences.Set("Language", selectedLanguage);
        }

        // Label animiert einblenden
        changessavedlabel.TranslationX = -400; // Startposition außerhalb des Bildschirms
        changessavedlabel.IsVisible = true;

        await changessavedlabel.TranslateTo(0, 0, 500, Easing.CubicOut); // Animation von links nach rechts

        // Warte 3 Sekunden
        await Task.Delay(3000);

        // Label animiert ausblenden
        await changessavedlabel.TranslateTo(400, 0, 500, Easing.CubicIn); // Animation nach rechts
        changessavedlabel.IsVisible = false;
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