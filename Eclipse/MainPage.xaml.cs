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
	 void About(object sender, EventArgs args)
	{
		frameAbout.IsVisible = true;
	}
	void Back(object sender, EventArgs args)
	{
		frameAbout.IsVisible =  false;
	}
}

