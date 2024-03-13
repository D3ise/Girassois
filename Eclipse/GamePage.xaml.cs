using Microsoft.Maui.Controls;

namespace Eclipse;

public partial class GamePage : ContentPage
{
	List<ConfigGamePage> historia = new List<ConfigGamePage>();
	ConfigGamePage ConfigGamePageAtual;
	

	public GamePage()
	{
		InitializeComponent();
	}
	
	void Voltar(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}
}
    