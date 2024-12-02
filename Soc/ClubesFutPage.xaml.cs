using Microsoft.Maui.Controls;

namespace soc
{
    public partial class ClubesFutPage : ContentPage
    {
        public ClubesFutPage()
        {
            InitializeComponent();
        }

        private async void OnLeagueClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string league = button.Text;

                // Determina los equipos según la liga seleccionada
                List<string> teams = league switch
                {
                "Premier League" => new List<string> { "Manchester United", "Manchester City", "Chelsea" },
                "Serie A" => new List<string> { "Juventus", "AC Milan", "Inter de Milán" },
                "Bundesliga" => new List<string> { "Bayern Múnich", "Borussia Dortmund", "RB Leipzig" },
                    "Ligue 1" => new List<string> { "Paris Saint-Germain", "Olympique Lyon", "Olympique Marsella" },
                    _ => new List<string>()
                };

                // Navega a una nueva página mostrando los equipos
                await Navigation.PushAsync(new TeamsPage(league, teams));
            }
        }
    }
}

