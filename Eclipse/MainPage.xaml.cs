namespace Eclipse;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

	 void Start(object sender, EventArgs args)
	{
		Application.Current.MainPage = new GamePage();
	}
}

