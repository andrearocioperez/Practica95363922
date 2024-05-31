namespace Promedio5363922;

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
        if (!string.IsNullOrEmpty(entry1.Text) && !string.IsNullOrEmpty(entry2.Text) && !string.IsNullOrEmpty(entry3.Text) && !string.IsNullOrEmpty(entry4.Text) && !string.IsNullOrEmpty(entry5.Text))
        {
            //Declaramos las variables a utilizar
            int Nota1;
            int Nota2;
            int Nota3;
            int Nota4;
            int Nota5;
            int Resultado;

            //Convertimos las variables que se ingresaran en cada uno de los entry
            Nota1 = Convert.ToInt32(entry1.Text);
            Nota2 = Convert.ToInt32(entry2.Text);
            Nota3 = Convert.ToInt32(entry3.Text);
            Nota4 = Convert.ToInt32(entry4.Text);
            Nota5 = Convert.ToInt32(entry5.Text);
            //La variable resultado se declara y se coloca la formula que se realizará en este caso para promediar las notas
            //primero hacemos la suma y luego lo dividimos entre  las 5 notas
            Resultado = (Nota1 + Nota2 + Nota3 + Nota4 + Nota5) / 5;
            //Luego declaramos el entry donde aparecera  el resultado
            entryResult.Text = Resultado.ToString();

        }
        else
        {
            //Si los datos no se ingresaron correctamente se mostrara el siguiente mensaje
            DisplayAlert("Error", "Ingrese todas las notas" , "esta bien");
        }
		




    }
}

