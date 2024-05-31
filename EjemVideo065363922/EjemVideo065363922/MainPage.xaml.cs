namespace EjemVideo065363922;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

	}

    private void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
		//Se declaran las variables a utilizar ccon el metodo de evaluar texto pasado y nuevo
		string pasado = e.OldTextValue;
		string nuevo = e.NewTextValue;
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
		//Luego declaramos una variable que es la que entrara en el campo de la entrada de texto
		string text= ((Entry)sender).Text;
    }
}

