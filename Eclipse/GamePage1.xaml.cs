namespace Eclipse;

public partial class GamePage1 : ContentPage
{
	public GamePage1()
	{
		InitializeComponent();
	}
	
	void Volta(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage();
	}
	 void Esquerda(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage2();
	}
	 void Direita(object sender, EventArgs args)
	{
		Application.Current.MainPage = new OverursoPage();
	}
}