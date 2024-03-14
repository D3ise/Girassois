namespace Eclipse;

public partial class GamePage1 : ContentPage
{
	public GamePage1()
	{
		InitializeComponent();
	}
	
	void Volta(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}
	 void Próximo(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage2();
	}
}