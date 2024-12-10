namespace soc;

public partial class LigasPage : ContentPage
{


    // Lista de ligas
    public List<string> Ligas { get; set; }

    // Comando de navegación
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

        // Definir el comando de navegación
        NavigateCommand = new Command<string>(async (liga) => await NavigateToLigaDetail(liga));

        // Configurar el BindingContext
        BindingContext = this;
    }

    // Método para navegar a la página de detalles de la liga
    private async Task NavigateToLigaDetail(string liga)
    {
        // Llamamos a una página de detalles con la información de la liga
        await Navigation.PushAsync(new LigaDetailPage(liga));










    }
}
