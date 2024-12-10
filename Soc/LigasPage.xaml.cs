namespace soc;

public partial class LigasPage : ContentPage
{


    // Lista de ligas
    public List<string> Ligas { get; set; }

    // Comando de navegaci�n
    public Command<string> NavigateCommand { get; set; }

    public LigasPage()
    {
        InitializeComponent();


        InitializeComponent();

        // Inicializar la lista de ligas
        Ligas = new List<string>
        {
            
            "Premier League",
            "Serie A",
            "Bundesliga",
            "Ligue 1"
        };

        // Definir el comando de navegaci�n
        NavigateCommand = new Command<string>(async (liga) => await NavigateToLigaDetail(liga));

        // Configurar el BindingContext
        BindingContext = this;
    }

    // M�todo para navegar a la p�gina de detalles de la liga
    private async Task NavigateToLigaDetail(string liga)
    {
        // Llamamos a una p�gina de detalles con la informaci�n de la liga
        await Navigation.PushAsync(new LigaDetailPage(liga));










    }
}
