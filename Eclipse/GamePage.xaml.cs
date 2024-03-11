namespace Eclipse;

public partial class GamePage : ContentPage
{
	

	public GamePage()
	{
		InitializeComponent();

	}
	void Voltar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage();
	}
}
    