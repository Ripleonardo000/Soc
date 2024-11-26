namespace soc;

public partial class LigaDetailPage : ContentPage
{
    public string LigaNombre { get; set; }
    public string LigaDescripcion { get; set; }

    public LigaDetailPage(string liga)
    {
        InitializeComponent();

        // Asignar la liga seleccionada y su descripci�n
        LigaNombre = liga;
        LigaDescripcion = GetLigaDescripcion(liga);

        // Configurar el BindingContext
        BindingContext = this;
    }

    // M�todo para obtener la descripci�n de cada liga
    private string GetLigaDescripcion(string liga)
    {
        return liga switch
        {
            "cbbche" => "hchdwc",
            "Premier League" => "La Premier League es la liga de f�tbol profesional en Inglaterra.",
            "Serie A" => "Serie A es la liga de f�tbol profesional en Italia.",
            "Bundesliga" => "La Bundesliga es la liga de f�tbol profesional en Alemania.",
            "Ligue 1" => "Ligue 1 es la liga de f�tbol profesional en Francia.",
            _ => "Descripci�n no disponible"
        };
    }
}
