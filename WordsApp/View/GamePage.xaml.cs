using WordsApp.ViewModel;

namespace WordsApp;

public partial class GamePage : ContentPage
{

	public GamePage(MainViewModel mainViewModel)
	{
		InitializeComponent();
		BindingContext = mainViewModel;
		var frame = new Frame();
	}

}

