namespace WordsApp;

public partial class App : Application
{
	public App(GamePage gamePage, MenuPage menuPage)
	{
		InitializeComponent();
		MainPage = menuPage;
		
	}
}
