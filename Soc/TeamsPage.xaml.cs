using Microsoft.Maui.Controls;

namespace soc
{
    public partial class TeamsPage : ContentPage
    {
        public string League { get; }
        public List<string> Teams { get; }

        public TeamsPage(string league, List<string> teams)
        {
            InitializeComponent();
            League = league;
            Teams = teams;
            BindingContext = this;
        }

        private async void OnTeamClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string team = button.Text;
                await DisplayAlert("Equipo Seleccionado", $"Has seleccionado: {team}", "OK");
            }
        }
    }
}
