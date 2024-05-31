namespace NumInvertidos5363922;

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
		//Colocamos un if para validar la informacion ingresada a los entry
		if(!string.IsNullOrEmpty(Entry1.Text)&& !string.IsNullOrEmpty(Entry2.Text) && !string.IsNullOrEmpty(Entry3.Text) && !string.IsNullOrEmpty(Entry4.Text))
		{
			//Declaramos las variables a utilizar y con estos también
			//se colocaran segun el orden en que queramos invertir los numeros
			int Numero1;
            int Numero2;
            int Numero3;
            int Numero4;
			//Convertimos los valores para mostrarlos en los entry
			//Colocamos las vvariibles en orden normal, porque acá solo ingresaremos los valores
			Numero1 = Convert.ToInt32(Entry1.Text);
            Numero2 = Convert.ToInt32(Entry2.Text);
            Numero3 = Convert.ToInt32(Entry3.Text);
            Numero4 = Convert.ToInt32(Entry4.Text);
			//Luego convertimos nuevamente pero ahora para pasarlos a tipo texto, donde se mostraran en los entry 
			//y tambien se realizara la acción para invertir los números
			//Colocamos las varibles en distinto orden
			Entry1In.Text = Numero4.ToString();
            Entry2In.Text = Numero3.ToString();
            Entry3In.Text = Numero2.ToString();
            Entry4In.Text = Numero1.ToString();
        }
        else
		{
			//Si los valores son nulos o no corresponden a lo solicitado mostrara el siguiente mensaje
			DisplayAlert("Error", "Ingrese todos los numeros", "Listo");
		}
    }
}

