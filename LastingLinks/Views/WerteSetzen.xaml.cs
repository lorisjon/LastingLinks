using System.Globalization;

namespace GUIDemo;

public partial class WerteSetzen : ContentPage
{
    bool isInitializing = true;
    public WerteSetzen()
	{
        CultureInfo cultureInfo = new CultureInfo("de-CH"); //TODO Korrektes Format Schweiz
        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        InitializeComponent();
        isInitializing = false;
    }
    private async void JaNein_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        await DisplayAlert("Alert", "Checkbox CheckedChanged", "OK");
    }

    private async void Group1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (!isInitializing && (((RadioButton)sender).IsChecked)) // Links: Notwendig wegen IsChecked in XAML, Rechts: Damit nur 1x angezeigt statt 2x
        {
            string wert = String.Empty;
            if (Option1.IsChecked) { wert = (string)Option1.Value; }
            else if (Option2.IsChecked) { wert = (string)Option2.Value; }
            await DisplayAlert("Radiobutton", $"Ausgewählter Wert {wert.ToString()}''", "OK");
        }
    }

    private void PlusMinus_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        AnzeigeStepper.Text = $"Stepper Wert: {PlusMinus.Value.ToString()}";
    }

    private void Schieberegler_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        lbSlider.Text = ((int)Schieberegler.Value).ToString();
    }

    private async void DemoPicker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(DemoPicker.SelectedItem != null)
        {
            await DisplayAlert("Picker Auswahl geändert", $"Ausgewählt ''{DemoPicker.SelectedItem.ToString()}''", "OK");
        }
    }
}