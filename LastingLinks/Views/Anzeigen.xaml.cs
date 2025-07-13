using Microsoft.Maui.Layouts;

namespace GUIDemo;

public partial class Anzeigen : ContentPage
{
    public Anzeigen()
    {
        InitializeComponent();
        ShowFirstMessage();
    }

   private async void ShowFirstMessage()
{
    // Nachricht zunächst vorbereiten (unsichtbar, aber vorhanden)
    IncomingMessageBubble1.Opacity = 0; // Unsichtbar, aber im Layout
    IncomingMessageBubble1.TranslationX = -300; // Startposition (300px links vom Ursprung)

    IncomingMessageText1.Opacity = 0;
    IncomingMessageText1.TranslationX = -300;

    // Warte 2 Sekunden, bevor die Animation startet
    await Task.Delay(2000);

    // Nachricht animiert hereinsliden und dabei einblenden
    await Task.WhenAll(
        IncomingMessageBubble1.TranslateTo(0, 0, 800, Easing.CubicIn), // Langsames Starten, dann Beschleunigung
        IncomingMessageText1.TranslateTo(0, 0, 800, Easing.CubicIn),   // Gleicher Effekt für Text
        IncomingMessageBubble1.FadeTo(1, 800), // Parallel weiches Einblenden
        IncomingMessageText1.FadeTo(1, 800)    // Parallel weiches Einblenden
    );
}

    private void SendButton_Clicked(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(MessageEntry.Text))
        {
            // Neue Nachricht erstellen
            var newMessageBubble = new Button
            {
                Text = MessageEntry.Text,
                Style = (Style)Application.Current.Resources["OutgoingText"], // Style anwenden
                CornerRadius = 15, // Rundes Designk
                WidthRequest = 270,
                HorizontalOptions = LayoutOptions.End
            };

            // Positionierung
            AbsoluteLayout.SetLayoutBounds(newMessageBubble, new Rect(1.0, 0.2 + messageCount * 0.1, -1, -1));
            AbsoluteLayout.SetLayoutFlags(newMessageBubble, AbsoluteLayoutFlags.PositionProportional);

            // Nachricht zum Layout hinzufügen
            ChatLayout.Children.Add(newMessageBubble); // Hier auf die Instanz von AbsoluteLayout zugreifen

            // Textfeld leeren
            MessageEntry.Text = string.Empty;

            // Nachrichtenzähler erhöhen
            messageCount++;
        }
    }

    // Zähler für Nachrichten (zur Positionierung)
    private int messageCount = 1;







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