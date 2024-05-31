namespace NumerosAB5363922;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		//Colocamos un if donde validamos la entrada de texto segun lo requerido
		if (!string.IsNullOrEmpty(EntryA.Text)&& !string.IsNullOrEmpty(EntryB.Text))
		{
			//Declaramos las variables a utilizar
			double resultado;
			double datoa;
			double datob;
			
			//Convertimos las variables que se ingresaran a los entry
			datoa= Convert.ToDouble(EntryA.Text);
			datob= Convert.ToDouble(EntryB.Text);
			//La variable resultado se declara y se coloca la formula que se realizará 
			resultado = ((datoa + datob) * (datoa + datob)) / 2;
			//Se muestra el resultado en el entry declarado
			EntryResul.Text= resultado.ToString();
        }
		else
		{
			//Si los datos no se ingresaron correctamente se mostrara el siguiente mensaje
			DisplayAlert("Error", "Introduce todos los numeros", "ok");
		}
    }
}

