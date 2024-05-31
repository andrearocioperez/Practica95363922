namespace MatchGame5363922;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		SetUpGame();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		//count++;

		//if (count == 1)
		//	CounterBtn.Text = $"Clicked {count} time";
		//else
		//	CounterBtn.Text = $"Clicked {count} times";

		//SemanticScreenReader.Announce(CounterBtn.Text);
	}

	//Metodo que se utilizara para el funcionamiento del juego
	private void SetUpGame()
	{
		List<string> animalEmoji= new List<string>()
		{
			"❤️","❤️",
			"🙈","🙈",
			"🐘","🐘",
			"🦋","🦋",
			"🦒","🦒",
			"🐶","🐶",
			"😁","😁",
			"😥","😥",
        };
		Random random= new Random();
		foreach(Button view in Grid1.Children)
		{
			int index= random.Next(animalEmoji.Count);
			string nextEmoji = animalEmoji[index];
			view.Text = nextEmoji;
			animalEmoji.RemoveAt(index);
		}
	}
	Button ultimoButtonCliked;
	bool encontrandoMatch = false;
	
	//AltitudeReferenceSystem dar click al boton se generara el metodo ddeclarrado anteriormente
    private void Button_Clicked(object sender, EventArgs e)
    {
		Button button = sender as Button;
		if(encontrandoMatch == false)
		{
			button.IsVisible = false;
			ultimoButtonCliked= button;
			encontrandoMatch = true;
		}
		else if (button.Text == ultimoButtonCliked.Text)
		{
			button.IsVisible = false;
			encontrandoMatch= false;
		}
		else
		{
			ultimoButtonCliked.IsVisible= true;
			encontrandoMatch = false;
		}
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {

    }
}

