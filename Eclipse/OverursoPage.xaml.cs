namespace Eclipse;

public partial class OverursoPage : ContentPage
{
	

	public OverursoPage()
	{
		InitializeComponent();
	}
    void X(object sender, EventArgs args)
	{
		Application.Current.MainPage = new MainPage();
	}
	 void JogarNovamente(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage();
	}
}