using System.Collections.ObjectModel;

namespace GUIDemo;

public partial class CollectionViewDemo : ContentPage
{
	ObservableCollection<Item> items = new ObservableCollection<Item>();
	public ObservableCollection<Item> Items { get { return items; } }
    public CollectionViewDemo()
	{
		InitializeComponent();
		items.Add(new Item() { Name = "Krone", Beschreibung = "Die Krone ist das Merkmal der Könige" , Zahl = 1000, Bild = "crown.jpg" });
        items.Add(new Item() { Name = "Stern", Beschreibung = "Ein Stern erhellt die Nacht", Zahl = 300, Bild = "bookmark.ico" });
        items.Add(new Item() { Name = "Smile", Beschreibung = "Ein Lachen ist unbezahlbar", Zahl = 999, Bild = "face_smile.ico" });
        collectionView.ItemsSource = items;
	}
}