using Microsoft.Maui.Controls;

namespace Eclipse;

public partial class GamePage : ContentPage
{
	public GamePage()
	{
		InitializeComponent();
	}
	
	void X(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}
	 void Sim(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage1();
	}
	 void Nao(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}
}
    