using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.Linq;

namespace soc
{
    public partial class JugadoresPage : ContentPage
    {
        public List<Jugador> Jugadores { get; set; }

        public JugadoresPage()
        {
            InitializeComponent();  // Este método vincula el XAML con el código C#
            Jugadores = new List<Jugador>();  // Inicializa la lista de jugadores
            BindingContext = this;  // Establece el contexto de enlace de datos
        }

        // Método que maneja la selección de liga
        private void OnLigaSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedLiga = LigaPicker.SelectedItem?.ToString();
            if (selectedLiga != null)
            {
                // Llenar el Picker de equipos según la liga seleccionada
                List<string> equipos = selectedLiga switch
                {
                    "Premier League" => new List<string> { "Manchester United", "Manchester City", "Chelsea" },
                    "Serie A" => new List<string> { "Juventus", "AC Milan", "Inter de Milán" },
                    "Bundesliga" => new List<string> { "Bayern Múnich", "Borussia Dortmund", "RB Leipzig" },
                    "Ligue 1" => new List<string> { "Paris Saint-Germain", "Olympique Lyon", "Olympique Marsella" },
                    _ => new List<string>()
                };

                EquipoPicker.ItemsSource = equipos;
            }
        }

        // Método que maneja la selección de equipo
        private void OnEquipoSelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedEquipo = EquipoPicker.SelectedItem?.ToString();
            var selectedLiga = LigaPicker.SelectedItem?.ToString();

            if (selectedEquipo != null && selectedLiga != null)
            {
                // Filtrar los jugadores según la liga y el equipo seleccionado
                Jugadores = GetJugadores(selectedLiga, selectedEquipo);
                JugadoresCollectionView.ItemsSource = Jugadores;
            }
        }

        // Método para obtener jugadores filtrados
        private List<Jugador> GetJugadores(string liga, string equipo)
        {
            // Aquí debes tener la lógica para obtener los jugadores según la liga y el equipo.
            // Este es un ejemplo simple con datos ficticios:

            var jugadores = new List<Jugador>
            {
                new Jugador { Nombre = "Cristiano Ronaldo", Posicion = "Delantero", Equipo = "Manchester United", Liga = "Premier League" },
                new Jugador { Nombre = "Lionel Messi", Posicion = "Delantero", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },
                new Jugador { Nombre = "Robert Lewandowski", Posicion = "Delantero", Equipo = "Bayern Múnich", Liga = "Bundesliga" }
            };

            return jugadores.Where(j => j.Liga == liga && j.Equipo == equipo).ToList();
        }
    }

    
}
