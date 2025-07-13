namespace GUIDemo;

public partial class TexteBearbeiten : ContentPage
{
	public TexteBearbeiten()
	{
		InitializeComponent();
	}

	private void enValidierung_TextChanged(object sender, TextChangedEventArgs e)
	{
		System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match(enValidierung.Text, @"^[0-9]+$");
		if (match.Success)
		{
			lbValidierung.BackgroundColor = Colors.Green;
		}
		else
		{
			lbValidierung.BackgroundColor = Colors.Red;
		}
	}
}