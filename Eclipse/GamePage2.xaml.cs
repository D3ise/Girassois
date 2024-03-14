namespace Eclipse;

public partial class GamePage2 : ContentPage
{
	

	public GamePage2()
	{
		InitializeComponent();
	}
     void Inicio(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}
}