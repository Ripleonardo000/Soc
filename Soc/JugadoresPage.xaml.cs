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
                    "Premier League" => new List<string>
                    {
                        "Manchester United", "Manchester City", "Chelsea", "Liverpool",
                        "Arsenal", "Tottenham", "West Ham", "Leicester City", "Everton"
                    },
                    "Serie A" => new List<string>
                    {
                        "Juventus", "AC Milan", "Inter de Milán", "Roma",
                        "Napoli", "Lazio", "Fiorentina", "Atalanta", "Torino"
                    },
                    "Bundesliga" => new List<string>
                    {
                        "Bayern Múnich", "Borussia Dortmund", "RB Leipzig",
                        "Bayer Leverkusen", "Wolfsburg", "Schalke 04", "Mönchengladbach"
                    },
                    "Ligue 1" => new List<string>
                    {
                        "Paris Saint-Germain", "Olympique Lyon", "Olympique Marsella",
                        "Lille", "Monaco", "Niza", "Rennes", "Montpellier", "Lorient"
                    },
                    "La Liga" => new List<string>
                    {
                        "Real Madrid", "FC Barcelona", "Atlético de Madrid", "Sevilla",
                        "Valencia", "Real Sociedad", "Villarreal", "Athletic Club", "Betis"
                    },
                    "MLS" => new List<string>
                    {
                        "LA Galaxy", "Inter Miami", "New York City FC", "Seattle Sounders",
                        "Portland Timbers", "Atlanta United", "LAFC", "Chicago Fire", "Columbus Crew"
                    },
                    "Eredivisie" => new List<string>
                    {
                        "Ajax", "PSV Eindhoven", "Feyenoord", "AZ Alkmaar", "Utrecht", "Vitesse", "Twente"
                    },
                    "Primeira Liga" => new List<string>
                    {
                        "Benfica", "Portimonense", "Porto", "Sporting CP", "Braga", "Boavista", "Marítimo"
                    },
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
            // Aquí tienes más jugadores representativos para cada liga y equipo
            var jugadores = new List<Jugador>
    {
        // Premier League - Manchester United
        
    new Jugador { Nombre = "David De Gea", Posicion = "Portero", Equipo = "Manchester United", Liga = "Premier League" },
    new Jugador { Nombre = "Aaron Wan-Bissaka", Posicion = "Defensor", Equipo = "Manchester United", Liga = "Premier League" },
    new Jugador { Nombre = "Raphaël Varane", Posicion = "Defensor", Equipo = "Manchester United", Liga = "Premier League" },
    new Jugador { Nombre = "Harry Maguire", Posicion = "Defensor", Equipo = "Manchester United", Liga = "Premier League" },
    new Jugador { Nombre = "Luke Shaw", Posicion = "Defensor", Equipo = "Manchester United", Liga = "Premier League" },
    new Jugador { Nombre = "Casemiro", Posicion = "Centrocampista", Equipo = "Manchester United", Liga = "Premier League" },
    new Jugador { Nombre = "Christian Eriksen", Posicion = "Centrocampista", Equipo = "Manchester United", Liga = "Premier League" },
    new Jugador { Nombre = "Bruno Fernandes", Posicion = "Centrocampista", Equipo = "Manchester United", Liga = "Premier League" },
    new Jugador { Nombre = "Antony", Posicion = "Delantero", Equipo = "Manchester United", Liga = "Premier League" },
    new Jugador { Nombre = "Marcus Rashford", Posicion = "Delantero", Equipo = "Manchester United", Liga = "Premier League" },
    new Jugador { Nombre = "Cristiano Ronaldo", Posicion = "Delantero", Equipo = "Manchester United", Liga = "Premier League" },





        // Premier League - Manchester City
        new Jugador { Nombre = "Ederson", Posicion = "Portero", Equipo = "Manchester City", Liga = "Premier League" },
    new Jugador { Nombre = "Kyle Walker", Posicion = "Defensor", Equipo = "Manchester City", Liga = "Premier League" },
    new Jugador { Nombre = "Ruben Dias", Posicion = "Defensor", Equipo = "Manchester City", Liga = "Premier League" },
    new Jugador { Nombre = "John Stones", Posicion = "Defensor", Equipo = "Manchester City", Liga = "Premier League" },
    new Jugador { Nombre = "João Cancelo", Posicion = "Defensor", Equipo = "Manchester City", Liga = "Premier League" },
    new Jugador { Nombre = "Rodri", Posicion = "Centrocampista", Equipo = "Manchester City", Liga = "Premier League" },
    new Jugador { Nombre = "Kevin De Bruyne", Posicion = "Centrocampista", Equipo = "Manchester City", Liga = "Premier League" },
    new Jugador { Nombre = "Bernardo Silva", Posicion = "Centrocampista", Equipo = "Manchester City", Liga = "Premier League" },
    new Jugador { Nombre = "Jack Grealish", Posicion = "Delantero", Equipo = "Manchester City", Liga = "Premier League" },
    new Jugador { Nombre = "Erling Haaland", Posicion = "Delantero", Equipo = "Manchester City", Liga = "Premier League" },
    new Jugador { Nombre = "Phil Foden", Posicion = "Delantero", Equipo = "Manchester City", Liga = "Premier League" },



    //chelsea
    new Jugador { Nombre = "Kepa Arrizabalaga", Posicion = "Portero", Equipo = "Chelsea", Liga = "Premier League" },
    new Jugador { Nombre = "Reece James", Posicion = "Defensor", Equipo = "Chelsea", Liga = "Premier League" },
    new Jugador { Nombre = "Thiago Silva", Posicion = "Defensor", Equipo = "Chelsea", Liga = "Premier League" },
    new Jugador { Nombre = "Kalidou Koulibaly", Posicion = "Defensor", Equipo = "Chelsea", Liga = "Premier League" },
    new Jugador { Nombre = "Marc Cucurella", Posicion = "Defensor", Equipo = "Chelsea", Liga = "Premier League" },
    new Jugador { Nombre = "N'Golo Kanté", Posicion = "Centrocampista", Equipo = "Chelsea", Liga = "Premier League" },
    new Jugador { Nombre = "Jorginho", Posicion = "Centrocampista", Equipo = "Chelsea", Liga = "Premier League" },
    new Jugador { Nombre = "Mason Mount", Posicion = "Centrocampista", Equipo = "Chelsea", Liga = "Premier League" },
    new Jugador { Nombre = "Raheem Sterling", Posicion = "Delantero", Equipo = "Chelsea", Liga = "Premier League" },
    new Jugador { Nombre = "Pierre-Emerick Aubameyang", Posicion = "Delantero", Equipo = "Chelsea", Liga = "Premier League" },
    new Jugador { Nombre = "Kai Havertz", Posicion = "Delantero", Equipo = "Chelsea", Liga = "Premier League" },


    //Liverpool
    new Jugador { Nombre = "Alisson Becker", Posicion = "Portero", Equipo = "Liverpool", Liga = "Premier League" },
    new Jugador { Nombre = "Trent Alexander-Arnold", Posicion = "Defensor", Equipo = "Liverpool", Liga = "Premier League" },
    new Jugador { Nombre = "Virgil van Dijk", Posicion = "Defensor", Equipo = "Liverpool", Liga = "Premier League" },
    new Jugador { Nombre = "Ibrahima Konaté", Posicion = "Defensor", Equipo = "Liverpool", Liga = "Premier League" },
    new Jugador { Nombre = "Andrew Robertson", Posicion = "Defensor", Equipo = "Liverpool", Liga = "Premier League" },
    new Jugador { Nombre = "Fabinho", Posicion = "Centrocampista", Equipo = "Liverpool", Liga = "Premier League" },
    new Jugador { Nombre = "Jordan Henderson", Posicion = "Centrocampista", Equipo = "Liverpool", Liga = "Premier League" },
    new Jugador { Nombre = "Thiago Alcántara", Posicion = "Centrocampista", Equipo = "Liverpool", Liga = "Premier League" },
    new Jugador { Nombre = "Mohamed Salah", Posicion = "Delantero", Equipo = "Liverpool", Liga = "Premier League" },
    new Jugador { Nombre = "Sadio Mané", Posicion = "Delantero", Equipo = "Liverpool", Liga = "Premier League" },
    new Jugador { Nombre = "Roberto Firmino", Posicion = "Delantero", Equipo = "Liverpool", Liga = "Premier League" },



    //ARSENAL

    new Jugador { Nombre = "Aaron Ramsdale", Posicion = "Portero", Equipo = "Arsenal", Liga = "Premier League" },
    new Jugador { Nombre = "Ben White", Posicion = "Defensor", Equipo = "Arsenal", Liga = "Premier League" },
    new Jugador { Nombre = "Gabriel Magalhães", Posicion = "Defensor", Equipo = "Arsenal", Liga = "Premier League" },
    new Jugador { Nombre = "William Saliba", Posicion = "Defensor", Equipo = "Arsenal", Liga = "Premier League" },
    new Jugador { Nombre = "Kieran Tierney", Posicion = "Defensor", Equipo = "Arsenal", Liga = "Premier League" },
    new Jugador { Nombre = "Thomas Partey", Posicion = "Centrocampista", Equipo = "Arsenal", Liga = "Premier League" },
    new Jugador { Nombre = "Martin Ødegaard", Posicion = "Centrocampista", Equipo = "Arsenal", Liga = "Premier League" },
    new Jugador { Nombre = "Granit Xhaka", Posicion = "Centrocampista", Equipo = "Arsenal", Liga = "Premier League" },
    new Jugador { Nombre = "Bukayo Saka", Posicion = "Delantero", Equipo = "Arsenal", Liga = "Premier League" },
    new Jugador { Nombre = "Gabriel Jesus", Posicion = "Delantero", Equipo = "Arsenal", Liga = "Premier League" },
    new Jugador { Nombre = "Eddie Nketiah", Posicion = "Delantero", Equipo = "Arsenal", Liga = "Premier League" },


    //totenhamm

    new Jugador { Nombre = "Hugo Lloris", Posicion = "Portero", Equipo = "Tottenham", Liga = "Premier League" },
    new Jugador { Nombre = "Emerson Royal", Posicion = "Defensor", Equipo = "Tottenham", Liga = "Premier League" },
    new Jugador { Nombre = "Cristian Romero", Posicion = "Defensor", Equipo = "Tottenham", Liga = "Premier League" },
    new Jugador { Nombre = "Eric Dier", Posicion = "Defensor", Equipo = "Tottenham", Liga = "Premier League" },
    new Jugador { Nombre = "Ivan Perišić", Posicion = "Defensor", Equipo = "Tottenham", Liga = "Premier League" },
    new Jugador { Nombre = "Pierre-Emile Højbjerg", Posicion = "Centrocampista", Equipo = "Tottenham", Liga = "Premier League" },
    new Jugador { Nombre = "Rodrigo Bentancur", Posicion = "Centrocampista", Equipo = "Tottenham", Liga = "Premier League" },
    new Jugador { Nombre = "Dejan Kulusevski", Posicion = "Centrocampista", Equipo = "Tottenham", Liga = "Premier League" },
    new Jugador { Nombre = "Harry Kane", Posicion = "Delantero", Equipo = "Tottenham", Liga = "Premier League" },
    new Jugador { Nombre = "Son Heung-min", Posicion = "Delantero", Equipo = "Tottenham", Liga = "Premier League" },
    new Jugador { Nombre = "Richarlison", Posicion = "Delantero", Equipo = "Tottenham", Liga = "Premier League" },


    //west ham

    new Jugador { Nombre = "Lukasz Fabiański", Posicion = "Portero", Equipo = "West Ham", Liga = "Premier League" },
    new Jugador { Nombre = "Vladimir Coufal", Posicion = "Defensor", Equipo = "West Ham", Liga = "Premier League" },
    new Jugador { Nombre = "Kurt Zouma", Posicion = "Defensor", Equipo = "West Ham", Liga = "Premier League" },
    new Jugador { Nombre = "Angelo Ogbonna", Posicion = "Defensor", Equipo = "West Ham", Liga = "Premier League" },
    new Jugador { Nombre = "Aaron Cresswell", Posicion = "Defensor", Equipo = "West Ham", Liga = "Premier League" },
    new Jugador { Nombre = "Declan Rice", Posicion = "Centrocampista", Equipo = "West Ham", Liga = "Premier League" },
    new Jugador { Nombre = "Tomas Soucek", Posicion = "Centrocampista", Equipo = "West Ham", Liga = "Premier League" },
    new Jugador { Nombre = "Pablo Fornals", Posicion = "Centrocampista", Equipo = "West Ham", Liga = "Premier League" },
    new Jugador { Nombre = "Jarrod Bowen", Posicion = "Delantero", Equipo = "West Ham", Liga = "Premier League" },
    new Jugador { Nombre = "Michail Antonio", Posicion = "Delantero", Equipo = "West Ham", Liga = "Premier League" },
    new Jugador { Nombre = "Said Benrahma", Posicion = "Delantero", Equipo = "West Ham", Liga = "Premier League" },



    //leicester

    new Jugador { Nombre = "Kasper Schmeichel", Posicion = "Portero", Equipo = "Leicester City", Liga = "Premier League" },
    new Jugador { Nombre = "Ricardo Pereira", Posicion = "Defensor", Equipo = "Leicester City", Liga = "Premier League" },
    new Jugador { Nombre = "Jonny Evans", Posicion = "Defensor", Equipo = "Leicester City", Liga = "Premier League" },
    new Jugador { Nombre = "Caglar Söyüncü", Posicion = "Defensor", Equipo = "Leicester City", Liga = "Premier League" },
    new Jugador { Nombre = "James Justin", Posicion = "Defensor", Equipo = "Leicester City", Liga = "Premier League" },
    new Jugador { Nombre = "Wilfred Ndidi", Posicion = "Centrocampista", Equipo = "Leicester City", Liga = "Premier League" },
    new Jugador { Nombre = "Youri Tielemans", Posicion = "Centrocampista", Equipo = "Leicester City", Liga = "Premier League" },
    new Jugador { Nombre = "James Maddison", Posicion = "Centrocampista", Equipo = "Leicester City", Liga = "Premier League" },
    new Jugador { Nombre = "Harvey Barnes", Posicion = "Delantero", Equipo = "Leicester City", Liga = "Premier League" },
    new Jugador { Nombre = "Patson Daka", Posicion = "Delantero", Equipo = "Leicester City", Liga = "Premier League" },
    new Jugador { Nombre = "Jamie Vardy", Posicion = "Delantero", Equipo = "Leicester City", Liga = "Premier League" },



    //everton


     new Jugador { Nombre = "Jordan Pickford", Posicion = "Portero", Equipo = "Everton", Liga = "Premier League" },
    new Jugador { Nombre = "Seamus Coleman", Posicion = "Defensor", Equipo = "Everton", Liga = "Premier League" },
    new Jugador { Nombre = "Yerry Mina", Posicion = "Defensor", Equipo = "Everton", Liga = "Premier League" },
    new Jugador { Nombre = "Michael Keane", Posicion = "Defensor", Equipo = "Everton", Liga = "Premier League" },
    new Jugador { Nombre = "Vitalii Mykolenko", Posicion = "Defensor", Equipo = "Everton", Liga = "Premier League" },
    new Jugador { Nombre = "Abdoulaye Doucouré", Posicion = "Centrocampista", Equipo = "Everton", Liga = "Premier League" },
    new Jugador { Nombre = "Allan", Posicion = "Centrocampista", Equipo = "Everton", Liga = "Premier League" },
    new Jugador { Nombre = "Alex Iwobi", Posicion = "Centrocampista", Equipo = "Everton", Liga = "Premier League" },
    new Jugador { Nombre = "Demarai Gray", Posicion = "Delantero", Equipo = "Everton", Liga = "Premier League" },
    new Jugador { Nombre = "Dominic Calvert-Lewin", Posicion = "Delantero", Equipo = "Everton", Liga = "Premier League" },
    new Jugador { Nombre = "Dwight McNeil", Posicion = "Delantero", Equipo = "Everton", Liga = "Premier League" },




        // La Liga - Real Madrid
        new Jugador { Nombre = "Thibaut Courtois", Posicion = "Portero", Equipo = "Real Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Dani Carvajal", Posicion = "Defensor", Equipo = "Real Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Éder Militão", Posicion = "Defensor", Equipo = "Real Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "David Alaba", Posicion = "Defensor", Equipo = "Real Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Ferland Mendy", Posicion = "Defensor", Equipo = "Real Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Casemiro", Posicion = "Centrocampista", Equipo = "Real Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Luka Modrić", Posicion = "Centrocampista", Equipo = "Real Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Toni Kroos", Posicion = "Centrocampista", Equipo = "Real Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Vinícius Júnior", Posicion = "Delantero", Equipo = "Real Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Karim Benzema", Posicion = "Delantero", Equipo = "Real Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Rodrygo", Posicion = "Delantero", Equipo = "Real Madrid", Liga = "La Liga" },


    new Jugador { Nombre = "Jan Oblak", Posicion = "Portero", Equipo = "Atlético de Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Kieran Trippier", Posicion = "Defensor", Equipo = "Atlético de Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "José María Giménez", Posicion = "Defensor", Equipo = "Atlético de Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Stefan Savić", Posicion = "Defensor", Equipo = "Atlético de Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Renan Lodi", Posicion = "Defensor", Equipo = "Atlético de Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Koke", Posicion = "Centrocampista", Equipo = "Atlético de Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Marcos Llorente", Posicion = "Centrocampista", Equipo = "Atlético de Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Saúl Ñíguez", Posicion = "Centrocampista", Equipo = "Atlético de Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Antoine Griezmann", Posicion = "Delantero", Equipo = "Atlético de Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "Álvaro Morata", Posicion = "Delantero", Equipo = "Atlético de Madrid", Liga = "La Liga" },
    new Jugador { Nombre = "João Félix", Posicion = "Delantero", Equipo = "Atlético de Madrid", Liga = "La Liga" },









        // Serie A - Juventus
        new Jugador { Nombre = "Wojciech Szczęsny", Posicion = "Portero", Equipo = "Juventus", Liga = "Serie A" },
        new Jugador { Nombre = "Leonardo Bonucci", Posicion = "Defensor", Equipo = "Juventus", Liga = "Serie A" },
        new Jugador { Nombre = "Paulo Dybala", Posicion = "Delantero", Equipo = "Juventus", Liga = "Serie A" },
        new Jugador { Nombre = "Federico Chiesa", Posicion = "Delantero", Equipo = "Juventus", Liga = "Serie A" },
        new Jugador { Nombre = "Ángel Di María", Posicion = "Centrocampista", Equipo = "Juventus", Liga = "Serie A" },

        // Bundesliga - Bayern Múnich
        new Jugador { Nombre = "Manuel Neuer", Posicion = "Portero", Equipo = "Bayern Múnich", Liga = "Bundesliga" },
        new Jugador { Nombre = "Joshua Kimmich", Posicion = "Centrocampista", Equipo = "Bayern Múnich", Liga = "Bundesliga" },
        new Jugador { Nombre = "Robert Lewandowski", Posicion = "Delantero", Equipo = "Bayern Múnich", Liga = "Bundesliga" },
        new Jugador { Nombre = "Thomas Müller", Posicion = "Centrocampista", Equipo = "Bayern Múnich", Liga = "Bundesliga" },
        new Jugador { Nombre = "Leroy Sané", Posicion = "Delantero", Equipo = "Bayern Múnich", Liga = "Bundesliga" },

        // Ligue 1 - Paris Saint-Germain
        new Jugador { Nombre = "Gianluigi Donnarumma", Posicion = "Portero", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },
        new Jugador { Nombre = "Marquinhos", Posicion = "Defensor", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },
        new Jugador { Nombre = "Kylian Mbappé", Posicion = "Delantero", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },
        new Jugador { Nombre = "Lionel Messi", Posicion = "Delantero", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },
        new Jugador { Nombre = "Neymar", Posicion = "Delantero", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },

        // MLS - LA Galaxy
        new Jugador { Nombre = "Jonathan Bond", Posicion = "Portero", Equipo = "LA Galaxy", Liga = "MLS" },
        new Jugador { Nombre = "Chicharito Hernández", Posicion = "Delantero", Equipo = "LA Galaxy", Liga = "MLS" },
        new Jugador { Nombre = "Ricky Puig", Posicion = "Centrocampista", Equipo = "LA Galaxy", Liga = "MLS" },
        new Jugador { Nombre = "Douglas Costa", Posicion = "Delantero", Equipo = "LA Galaxy", Liga = "MLS" },
        new Jugador { Nombre = "Raheem Edwards", Posicion = "Defensor", Equipo = "LA Galaxy", Liga = "MLS" },

        // Eredivisie - Ajax
        new Jugador { Nombre = "André Onana", Posicion = "Portero", Equipo = "Ajax", Liga = "Eredivisie" },
        new Jugador { Nombre = "Lisandro Martínez", Posicion = "Defensor", Equipo = "Ajax", Liga = "Eredivisie" },
        new Jugador { Nombre = "Dusan Tadic", Posicion = "Centrocampista", Equipo = "Ajax", Liga = "Eredivisie" },
        new Jugador { Nombre = "Sebastián Haller", Posicion = "Delantero", Equipo = "Ajax", Liga = "Eredivisie" },
        new Jugador { Nombre = "Antony", Posicion = "Delantero", Equipo = "Ajax", Liga = "Eredivisie" },

        // Primeira Liga - Benfica
        new Jugador { Nombre = "Odisseas Vlachodimos", Posicion = "Portero", Equipo = "Benfica", Liga = "Primeira Liga" },
        new Jugador { Nombre = "Jan Vertonghen", Posicion = "Defensor", Equipo = "Benfica", Liga = "Primeira Liga" },
        new Jugador { Nombre = "Darwin Núñez", Posicion = "Delantero", Equipo = "Benfica", Liga = "Primeira Liga" },
        new Jugador { Nombre = "Pizzi", Posicion = "Centrocampista", Equipo = "Benfica", Liga = "Primeira Liga" },
        new Jugador { Nombre = "Rafa Silva", Posicion = "Delantero", Equipo = "Benfica", Liga = "Primeira Liga" },
    };

            return jugadores.Where(j => j.Liga == liga && j.Equipo == equipo).ToList();
        }

    }
}
