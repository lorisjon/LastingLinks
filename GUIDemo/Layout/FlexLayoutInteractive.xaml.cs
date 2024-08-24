using Microsoft.Maui.Layouts;
namespace GUIDemo;

public partial class FlexLayoutInteractive : ContentPage
{
	public FlexLayoutInteractive()
	{
		InitializeComponent();
        piDirection.SelectedIndex = 0;
        piAlignContent.SelectedIndex = 0;
        piJustifyContent.SelectedIndex = 0;
        piAlignItems.SelectedIndex = 0;
        piWrap.SelectedIndex = 0;
    }
    private void piDirection_SelectedIndexChanged(object sender, EventArgs e)
    {
        string state = piDirection.SelectedItem.ToString();
        if (state == "Row")
        {
            DemoLayout.Direction = Microsoft.Maui.Layouts.FlexDirection.Row;
        }
        else if (state == "Column")
        {
            DemoLayout.Direction = Microsoft.Maui.Layouts.FlexDirection.Column;
        }
    }

    private void piAlignContent_SelectedIndexChanged(object sender, EventArgs e)
    {
        string state = piAlignContent.SelectedItem.ToString();
        if (state == "Center")
        {
            DemoLayout.AlignContent = Microsoft.Maui.Layouts.FlexAlignContent.Center;
        }
        else if (state == "SpaceEvenly")
        {
            DemoLayout.AlignContent = Microsoft.Maui.Layouts.FlexAlignContent.SpaceEvenly;
        }
        else if (state == "End")
        {
            DemoLayout.AlignContent = Microsoft.Maui.Layouts.FlexAlignContent.End;
        }
        else if (state == "SpaceBetween")
        {
            DemoLayout.AlignContent = Microsoft.Maui.Layouts.FlexAlignContent.SpaceBetween;
        }
        else if (state == "SpaceAround")
        {
            DemoLayout.AlignContent = Microsoft.Maui.Layouts.FlexAlignContent.SpaceAround;
        }
        else if (state == "Stretch")
        {
            DemoLayout.AlignContent = Microsoft.Maui.Layouts.FlexAlignContent.Stretch;
        }
        else if (state == "Start")
        {
            DemoLayout.AlignContent = Microsoft.Maui.Layouts.FlexAlignContent.Start;
        }
    }

    private void piJustifyContent_SelectedIndexChanged(object sender, EventArgs e)
    {
        string state = piJustifyContent.SelectedItem.ToString();
        if (state == "Center")
        {
            DemoLayout.JustifyContent = Microsoft.Maui.Layouts.FlexJustify.Center;
        }
        else if (state == "SpaceEvenly")
        {
            DemoLayout.JustifyContent = Microsoft.Maui.Layouts.FlexJustify.SpaceEvenly;
        }
        else if (state == "End")
        {
            DemoLayout.JustifyContent = Microsoft.Maui.Layouts.FlexJustify.End;
        }
        else if (state == "SpaceBetween")
        {
            DemoLayout.JustifyContent = Microsoft.Maui.Layouts.FlexJustify.SpaceBetween;
        }
        else if (state == "SpaceAround")
        {
            DemoLayout.JustifyContent = Microsoft.Maui.Layouts.FlexJustify.SpaceAround;
        }
        else if (state == "Start")
        {
            DemoLayout.JustifyContent = Microsoft.Maui.Layouts.FlexJustify.Start;
        }
    }

    private void piAlignItems_SelectedIndexChanged(object sender, EventArgs e)
    {
        string state = piAlignItems.SelectedItem.ToString();
        if (state == "Center")
        {
            DemoLayout.AlignItems = Microsoft.Maui.Layouts.FlexAlignItems.Center;
        }
        else if (state == "End")
        {
            DemoLayout.AlignItems = Microsoft.Maui.Layouts.FlexAlignItems.End;
        }
        else if (state == "Start")
        {
            DemoLayout.AlignItems = Microsoft.Maui.Layouts.FlexAlignItems.Start;
        }
        else if (state == "Stretch")
        {
            DemoLayout.AlignItems = Microsoft.Maui.Layouts.FlexAlignItems.Stretch;
        }
    }

    private void piWrap_SelectedIndexChanged(object sender, EventArgs e)
    {
        string state = piWrap.SelectedItem.ToString();
        if (state == "NoWrap")
        {
            DemoLayout.Wrap = Microsoft.Maui.Layouts.FlexWrap.NoWrap;
        }
        else if (state == "Reverse")
        {
            DemoLayout.Wrap = Microsoft.Maui.Layouts.FlexWrap.Reverse;
        }
        else if (state == "Wrap")
        {
            DemoLayout.Wrap = Microsoft.Maui.Layouts.FlexWrap.Wrap;
        }
    }
}