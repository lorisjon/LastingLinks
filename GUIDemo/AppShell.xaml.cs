namespace GUIDemo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        // Dieser werden gebraucht für den Aufruf aus AppShell.xaml und MainPage.xaml.cs
        // 1. Paramater frei wählbarer Name (unique)
        // 2. Parameter Name der Klasse in Projekt

        Routing.RegisterRoute("Anzeigen", typeof(Anzeigen));
        Routing.RegisterRoute("BefehleAusfuehren", typeof(BefehleAusfuehren));
        Routing.RegisterRoute("WerteSetzen", typeof(WerteSetzen));
        Routing.RegisterRoute("TexteBearbeiten", typeof(TexteBearbeiten));

        Routing.RegisterRoute("StackLayoutDemo", typeof(StackLayoutDemo));
        Routing.RegisterRoute("AbsoluteLayoutDemo", typeof(AbsoluteLayoutDemo));
        Routing.RegisterRoute("GridDemo", typeof(GridDemo));
        Routing.RegisterRoute("FlexLayoutInteractive", typeof(FlexLayoutInteractive));
    }
}