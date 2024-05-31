namespace NumPositivo5363922;

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
        if (int.TryParse(Entry1.Text, out int Numero) && Numero > 0) /*Aqui se declara la variable numero donde tambien se evalua que sea un numero positivo el que se ha ingresado*/
		{
            //Declaramos las variables a utilizar
            int resultado;

            //Convertimos las variables que se ingresaran a los entry
            Numero = Convert.ToInt32(Entry1.Text);
            //La variable resultado se declara y se coloca la formula que se realizará 
            //Que primero se calculará el cuadrado de un numero que es multiplicando dos veces el mismo numero
            resultado = (Numero * Numero);
            //Se muestra el resultado en el entry declarado
            EntryresultCuadrado.Text = resultado.ToString();
		}
		else
		{
            //Si los datos no se ingresaron correctamente se mostrara el siguiente mensaje
            DisplayAlert("Error", "Digite un numero", "Digite un numero positivo");
		}
    }

    private void CounterBtn_Clicked_1(object sender, EventArgs e)
    {
        //Colocamos un if donde validamos la entrada de texto segun lo requerido
        if (int.TryParse(Entry1.Text, out int Numero) && Numero > 0)
        {
            //Declaramos las variables a utilizar
            int resultado;

            //La variable resultado se declara y se coloca la formula que se realizará 
            //Que primero se calculará el cuadrado de un numero que es multiplicando dos veces el mismo numero
            Numero = Convert.ToInt32(Entry1.Text);
            resultado = (Numero * Numero * Numero);
            //Se muestra el resultado en el entry declarado
            EntryresultCubo.Text = resultado.ToString();
        }
        else
        {
            //Si los datos no se ingresaron correctamente se mostrara el siguiente mensaje
            DisplayAlert("Error", "Digite un numero", "Digite un numero positivo");
        }
    }
}

