namespace Ejem05Video5363922;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		//Se declara la accion que hara, es que a la hora de dar click al 
		//boton este cambie suu mensaje y diga que lo vuelva a presionar de nuevo
		(sender as Button).Text = "Presioname de nuevo";
	}
}

