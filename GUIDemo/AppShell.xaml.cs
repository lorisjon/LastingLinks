namespace GUIDemo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("Anzeigen", typeof(Anzeigen));
        Routing.RegisterRoute("BefehleAusfuehren", typeof(BefehleAusfuehren));
        Routing.RegisterRoute("WerteSetzen", typeof(WerteSetzen));
        Routing.RegisterRoute("TexteBearbeiten", typeof(TexteBearbeiten));

        Routing.RegisterRoute("AbsoluteLayoutDemo", typeof(AbsoluteLayoutDemo));
        Routing.RegisterRoute("GridDemo", typeof(GridDemo));
        Routing.RegisterRoute("FlexLayoutInteractive", typeof(FlexLayoutInteractive));
    }
}