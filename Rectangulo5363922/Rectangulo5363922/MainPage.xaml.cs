namespace Rectangulo5363922;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{ 
	}

    private void CounterBtn_Clicked(object sender, EventArgs e)
    {
        //Colocamos un if donde validamos la entrada de texto segun lo requerido
        if (!string.IsNullOrEmpty(EntryA.Text)&& !string.IsNullOrEmpty(EntryB.Text)) 
		{
            //Declaramos las variables a utilizar
            double Base;
			double Altura;
			double ResultadoPer;

            //Convertimos las variables que se ingresaran a los entry
            Altura = Convert.ToDouble(EntryA.Text);
			Base = Convert.ToDouble(EntryB.Text);
            //La variable resultado se declara y se coloca la formula que se realizará que seria la del perimetro
            ResultadoPer = 2 * (Base + Altura);
            //Se muestra el resultado en el entry declarado
            EntryResulP.Text= ResultadoPer.ToString();

		}
		else
		{
            //Si los datos no se ingresaron correctamente se mostrara el siguiente mensaje
            DisplayAlert("Error", "Digite los dos valores", "Listo");
		}
    }

    private void CounterBtn2_Clicked(object sender, EventArgs e)
    {
        //Colocamos un if donde validamos la entrada de texto segun lo requerido
        if (!string.IsNullOrEmpty(EntryA.Text) && !string.IsNullOrEmpty(EntryB.Text))
        {
            //Declaramos las variables a utilizar
            double Base;
            double Altura;
            double ResultadoSup;

            //Convertimos las variables que se ingresaran a los entry
            Altura = Convert.ToDouble(EntryA.Text);
            Base = Convert.ToDouble(EntryB.Text);
            //La variable resultado se declara y se coloca la formula que se realizará  que seria la del calculo de superficie
            ResultadoSup = (Base * Altura);
            //Se muestra el resultado en el entry declarado
            EntryResulS.Text = ResultadoSup.ToString();

        }
        else
        {
            //Si los datos no se ingresaron correctamente se mostrara el siguiente mensaje
            DisplayAlert("Error", "Digite los dos valores", "Listo");
        }
    }
}

