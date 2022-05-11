using CommunityToolkit.Mvvm.ComponentModel;
using WordsApp.ViewModel;

namespace WordsApp;

public partial class MenuPage : ContentPage
{
	public MenuPage(MainViewModel mainViewModel)
	{
		InitializeComponent();
		BindingContext = mainViewModel;
		var frame = new Frame();
		RecordLabel.Text = $"Текущий рекорд: 0";
	}
}