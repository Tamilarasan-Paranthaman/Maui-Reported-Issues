using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CollectionViewIssue;

public partial class MainPage : ContentPage
{

	DemoViewModel ViewModel;

	public MainPage()
	{
		InitializeComponent();
		ViewModel = new DemoViewModel();
		BindingContext = ViewModel;
	}
}


public class ItemGroup : List<Items>
{
	public string Name { get; private set; }

	public ItemGroup(string name, List<Items> animals) : base(animals)
	{
		Name = name;
	}
}

public class Items
{
	public string? Name { get; set; }
}

public class DemoViewModel : INotifyPropertyChanged
{
	public event PropertyChangedEventHandler? PropertyChanged;

	// Collection of grouped items
	public List<ItemGroup> Items { get; private set; } = new List<ItemGroup>();

	public DemoViewModel()
	{
		Items.Add(new ItemGroup("Collection 1", new List<Items> { new Items { Name = "Item 1" }, new Items { Name = "Item 2" } }));
		Items.Add(new ItemGroup("Collection 2", new List<Items> { new Items { Name = "Item 1" }, new Items { Name = "Item 2" } }));
		Items.Add(new ItemGroup("Collection 3", new List<Items> { new Items { Name = "Item 1" }, new Items { Name = "Item 2" } }));


	}

	// Helper method to raise the PropertyChanged event
	protected void OnPropertyChanged(string propertyName)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}

