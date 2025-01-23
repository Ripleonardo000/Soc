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
                        "Napoli"

                    },
                    "Bundesliga" => new List<string>
                    {
                        "Bayern Múnich", "Borussia Dortmund", "RB Leipzig",
                        "Bayer Leverkusen", "Wolfsburg"
                    },
                    "Ligue 1" => new List<string>
                    {
                        "Paris Saint-Germain", "Olympique Lyon", "Olympique Marsella",
                        "Lille", "Monaco" 
                    },
                    "La Liga" => new List<string>
                    {
                        "Real Madrid", "FC Barcelona", "Atlético de Madrid", "Sevilla",
                        "Valencia"

                    },
                    "MLS" => new List<string>
                    {
                        "LA Galaxy", "Inter Miami", "New York City FC"


                    },

                    

                    "Primeira Liga" => new List<string>
                    {
                        "Benfica", "Portimonense", "Porto"
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
        
    new Jugador { Nombre = "André Onana", Posicion = "Portero", Equipo = "Manchester United", Liga = "Premier League" },
new Jugador { Nombre = "Noussair Mazraoui", Posicion = "Defensor", Equipo = "Manchester United", Liga = "Premier League" },
new Jugador { Nombre = "Matthijs de Ligt", Posicion = "Defensor", Equipo = "Manchester United", Liga = "Premier League" },
new Jugador { Nombre = "Harry Maguire", Posicion = "Defensor", Equipo = "Manchester United", Liga = "Premier League" },
new Jugador { Nombre = "Diogo Dalot", Posicion = "Centrocampista", Equipo = "Manchester United", Liga = "Premier League" },
new Jugador { Nombre = "Manuel Ugarte", Posicion = "Centrocampista", Equipo = "Manchester United", Liga = "Premier League" },
new Jugador { Nombre = "Bruno Fernandes", Posicion = "Centrocampista", Equipo = "Manchester United", Liga = "Premier League" },
new Jugador { Nombre = "Tyrell Malacia", Posicion = "Centrocampista", Equipo = "Manchester United", Liga = "Premier League" },
new Jugador { Nombre = "Alejandro Garnacho", Posicion = "Delantero", Equipo = "Manchester United", Liga = "Premier League" },
new Jugador { Nombre = "Mason Mount", Posicion = "Delantero", Equipo = "Manchester United", Liga = "Premier League" },
new Jugador { Nombre = "Rasmus Hojlund", Posicion = "Delantero", Equipo = "Manchester United", Liga = "Premier League" },





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
    new Jugador { Nombre = "Robert Sánchez", Posicion = "Portero", Equipo = "Chelsea", Liga = "Premier League" },
new Jugador { Nombre = "Malo Gusto", Posicion = "Defensor", Equipo = "Chelsea", Liga = "Premier League" },
new Jugador { Nombre = "Axel Disasi", Posicion = "Defensor", Equipo = "Chelsea", Liga = "Premier League" },
new Jugador { Nombre = "Levi Colwill", Posicion = "Defensor", Equipo = "Chelsea", Liga = "Premier League" },
new Jugador { Nombre = "Ben Chilwell", Posicion = "Defensor", Equipo = "Chelsea", Liga = "Premier League" },
new Jugador { Nombre = "Enzo Fernández", Posicion = "Centrocampista", Equipo = "Chelsea", Liga = "Premier League" },
new Jugador { Nombre = "Moisés Caicedo", Posicion = "Centrocampista", Equipo = "Chelsea", Liga = "Premier League" },
new Jugador { Nombre = "Conor Gallagher", Posicion = "Centrocampista", Equipo = "Chelsea", Liga = "Premier League" },
new Jugador { Nombre = "Raheem Sterling", Posicion = "Delantero", Equipo = "Chelsea", Liga = "Premier League" },
new Jugador { Nombre = "Cole Palmer", Posicion = "Delantero", Equipo = "Chelsea", Liga = "Premier League" },
new Jugador { Nombre = "Nicolas Jackson", Posicion = "Delantero", Equipo = "Chelsea", Liga = "Premier League" },


    //Liverpool
    new Jugador { Nombre = "Alisson Becker", Posicion = "Portero", Equipo = "Liverpool", Liga = "Premier League" },
new Jugador { Nombre = "Trent Alexander-Arnold", Posicion = "Defensor", Equipo = "Liverpool", Liga = "Premier League" },
new Jugador { Nombre = "Virgil van Dijk", Posicion = "Defensor", Equipo = "Liverpool", Liga = "Premier League" },
new Jugador { Nombre = "Jarell Quansah", Posicion = "Defensor", Equipo = "Liverpool", Liga = "Premier League" },
new Jugador { Nombre = "Kostas Tsimikas", Posicion = "Defensor", Equipo = "Liverpool", Liga = "Premier League" },
new Jugador { Nombre = "Wataru Endo", Posicion = "Centrocampista", Equipo = "Liverpool", Liga = "Premier League" },
new Jugador { Nombre = "Dominik Szoboszlai", Posicion = "Centrocampista", Equipo = "Liverpool", Liga = "Premier League" },
new Jugador { Nombre = "Alexis Mac Allister", Posicion = "Centrocampista", Equipo = "Liverpool", Liga = "Premier League" },
new Jugador { Nombre = "Mohamed Salah", Posicion = "Delantero", Equipo = "Liverpool", Liga = "Premier League" },
new Jugador { Nombre = "Darwin Núñez", Posicion = "Delantero", Equipo = "Liverpool", Liga = "Premier League" },
new Jugador { Nombre = "Luis Díaz", Posicion = "Delantero", Equipo = "Liverpool", Liga = "Premier League" },



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
new Jugador { Nombre = "Lucas Vázquez", Posicion = "Defensor", Equipo = "Real Madrid", Liga = "La Liga" },
new Jugador { Nombre = "Raúl Asencio", Posicion = "Defensor", Equipo = "Real Madrid", Liga = "La Liga" },
new Jugador { Nombre = "Antonio Rüdiger", Posicion = "Defensor", Equipo = "Real Madrid", Liga = "La Liga" },
new Jugador { Nombre = "Fran García", Posicion = "Defensor", Equipo = "Real Madrid", Liga = "La Liga" },
new Jugador { Nombre = "Federico Valverde", Posicion = "Centrocampista", Equipo = "Real Madrid", Liga = "La Liga" },
new Jugador { Nombre = "Aurélien Tchouaméni", Posicion = "Centrocampista", Equipo = "Real Madrid", Liga = "La Liga" },
new Jugador { Nombre = "Dani Ceballos", Posicion = "Centrocampista", Equipo = "Real Madrid", Liga = "La Liga" },
new Jugador { Nombre = "Jude Bellingham", Posicion = "Centrocampista", Equipo = "Real Madrid", Liga = "La Liga" },
new Jugador { Nombre = "Rodrygo", Posicion = "Delantero", Equipo = "Real Madrid", Liga = "La Liga" },
new Jugador { Nombre = "Kylian Mbappé", Posicion = "Delantero", Equipo = "Real Madrid", Liga = "La Liga" },


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




     new Jugador { Nombre = "Álvaro Fernández", Posicion = "Portero", Equipo = "Sevilla FC", Liga = "La Liga" },
new Jugador { Nombre = "José Ángel Carmona", Posicion = "Defensor", Equipo = "Sevilla FC", Liga = "La Liga" },
new Jugador { Nombre = "Loïc Badé", Posicion = "Defensor", Equipo = "Sevilla FC", Liga = "La Liga" },
new Jugador { Nombre = "Kike Salas", Posicion = "Defensor", Equipo = "Sevilla FC", Liga = "La Liga" },
new Jugador { Nombre = "Adrià Pedrosa", Posicion = "Defensor", Equipo = "Sevilla FC", Liga = "La Liga" },
new Jugador { Nombre = "Fernando Reges", Posicion = "Centrocampista", Equipo = "Sevilla FC", Liga = "La Liga" },
new Jugador { Nombre = "Joan Jordán", Posicion = "Centrocampista", Equipo = "Sevilla FC", Liga = "La Liga" },
new Jugador { Nombre = "Óliver Torres", Posicion = "Centrocampista", Equipo = "Sevilla FC", Liga = "La Liga" },
new Jugador { Nombre = "Lucas Ocampos", Posicion = "Delantero", Equipo = "Sevilla FC", Liga = "La Liga" },
new Jugador { Nombre = "Youssef En-Nesyri", Posicion = "Delantero", Equipo = "Sevilla FC", Liga = "La Liga" },
new Jugador { Nombre = "Erik Lamela", Posicion = "Delantero", Equipo = "Sevilla FC", Liga = "La Liga" },


new Jugador { Nombre = "Giorgi Mamardashvili", Posicion = "Portero", Equipo = "Valencia", Liga = "La Liga" },
new Jugador { Nombre = "Dimitri Foulquier", Posicion = "Defensor", Equipo = "Valencia", Liga = "La Liga" },
new Jugador { Nombre = "Cristhian Mosquera", Posicion = "Defensor", Equipo = "Valencia", Liga = "La Liga" },
new Jugador { Nombre = "Yarek Gasiorowski", Posicion = "Defensor", Equipo = "Valencia", Liga = "La Liga" },
new Jugador { Nombre = "José Gayà", Posicion = "Defensor", Equipo = "Valencia", Liga = "La Liga" },
new Jugador { Nombre = "Enzo Barrenechea", Posicion = "Centrocampista", Equipo = "Valencia", Liga = "La Liga" },
new Jugador { Nombre = "Javi Guerra", Posicion = "Centrocampista", Equipo = "Valencia", Liga = "La Liga" },
new Jugador { Nombre = "Luis Rioja", Posicion = "Centrocampista", Equipo = "Valencia", Liga = "La Liga" },
new Jugador { Nombre = "Diego López", Posicion = "Delantero", Equipo = "Valencia", Liga = "La Liga" },
new Jugador { Nombre = "Hugo Duro", Posicion = "Delantero", Equipo = "Valencia", Liga = "La Liga" },


new Jugador { Nombre = "Álex Remiro", Posicion = "Portero", Equipo = "Real Sociedad", Liga = "La Liga" },
new Jugador { Nombre = "Ander Aramburu", Posicion = "Defensor", Equipo = "Real Sociedad", Liga = "La Liga" },
new Jugador { Nombre = "Nayef Aguerd", Posicion = "Defensor", Equipo = "Real Sociedad", Liga = "La Liga" },
new Jugador { Nombre = "Igor Zubeldia", Posicion = "Defensor", Equipo = "Real Sociedad", Liga = "La Liga" },
new Jugador { Nombre = "Aihen Muñoz", Posicion = "Defensor", Equipo = "Real Sociedad", Liga = "La Liga" },
new Jugador { Nombre = "Martín Zubimendi", Posicion = "Centrocampista", Equipo = "Real Sociedad", Liga = "La Liga" },
new Jugador { Nombre = "Brais Méndez", Posicion = "Centrocampista", Equipo = "Real Sociedad", Liga = "La Liga" },
new Jugador { Nombre = "Takuhiro 'Take' Kubo", Posicion = "Centrocampista", Equipo = "Real Sociedad", Liga = "La Liga" },
new Jugador { Nombre = "Sergio Gómez", Posicion = "Centrocampista", Equipo = "Real Sociedad", Liga = "La Liga" },
new Jugador { Nombre = "Mikel Oyarzabal", Posicion = "Delantero", Equipo = "Real Sociedad", Liga = "La Liga" },
new Jugador { Nombre = "Ander Barrenetxea", Posicion = "Delantero", Equipo = "Real Sociedad", Liga = "La Liga" },


new Jugador { Nombre = "Diego Conde", Posicion = "Portero", Equipo = "Villarreal", Liga = "La Liga" },
new Jugador { Nombre = "Kiko Femenía", Posicion = "Defensor", Equipo = "Villarreal", Liga = "La Liga" },
new Jugador { Nombre = "Raúl Albiol", Posicion = "Defensor", Equipo = "Villarreal", Liga = "La Liga" },
new Jugador { Nombre = "Logan Costa", Posicion = "Defensor", Equipo = "Villarreal", Liga = "La Liga" },
new Jugador { Nombre = "Alfonso Pedraza", Posicion = "Defensor", Equipo = "Villarreal", Liga = "La Liga" },
new Jugador { Nombre = "Álex Baena", Posicion = "Centrocampista", Equipo = "Villarreal", Liga = "La Liga" },
new Jugador { Nombre = "Santi Comesaña", Posicion = "Centrocampista", Equipo = "Villarreal", Liga = "La Liga" },
new Jugador { Nombre = "Dani Parejo", Posicion = "Centrocampista", Equipo = "Villarreal", Liga = "La Liga" },
new Jugador { Nombre = "Yeremy Pino", Posicion = "Centrocampista", Equipo = "Villarreal", Liga = "La Liga" },
new Jugador { Nombre = "Thierno Barry", Posicion = "Delantero", Equipo = "Villarreal", Liga = "La Liga" },
new Jugador { Nombre = "Pape Gueye", Posicion = "Delantero", Equipo = "Villarreal", Liga = "La Liga" },

new Jugador { Nombre = "Marc-André ter Stegen", Posicion = "Portero", Equipo = "FC Barcelona", Liga = "La Liga" },
new Jugador { Nombre = "Jules Koundé", Posicion = "Defensor", Equipo = "FC Barcelona", Liga = "La Liga" },
new Jugador { Nombre = "Ronald Araújo", Posicion = "Defensor", Equipo = "FC Barcelona", Liga = "La Liga" },
new Jugador { Nombre = "Andreas Christensen", Posicion = "Defensor", Equipo = "FC Barcelona", Liga = "La Liga" },
new Jugador { Nombre = "Alejandro Balde", Posicion = "Defensor", Equipo = "FC Barcelona", Liga = "La Liga" },
new Jugador { Nombre = "Frenkie de Jong", Posicion = "Centrocampista", Equipo = "FC Barcelona", Liga = "La Liga" },
new Jugador { Nombre = "Gavi", Posicion = "Centrocampista", Equipo = "FC Barcelona", Liga = "La Liga" },
new Jugador { Nombre = "Ilkay Gündogan", Posicion = "Centrocampista", Equipo = "FC Barcelona", Liga = "La Liga" },
new Jugador { Nombre = "Robert Lewandowski", Posicion = "Delantero", Equipo = "FC Barcelona", Liga = "La Liga" },
new Jugador { Nombre = "João Félix", Posicion = "Delantero", Equipo = "FC Barcelona", Liga = "La Liga" },
new Jugador { Nombre = "Raphinha", Posicion = "Delantero", Equipo = "FC Barcelona", Liga = "La Liga" },


new Jugador { Nombre = "Ørjan Nyland", Posicion = "Portero", Equipo = "Sevilla", Liga = "La Liga" },
new Jugador { Nombre = "Jesús Navas", Posicion = "Defensor", Equipo = "Sevilla", Liga = "La Liga" },
new Jugador { Nombre = "Loïc Badé", Posicion = "Defensor", Equipo = "Sevilla", Liga = "La Liga" },
new Jugador { Nombre = "Sergio Ramos", Posicion = "Defensor", Equipo = "Sevilla", Liga = "La Liga" },
new Jugador { Nombre = "Adrià Pedrosa", Posicion = "Defensor", Equipo = "Sevilla", Liga = "La Liga" },
new Jugador { Nombre = "Joan Jordán", Posicion = "Centrocampista", Equipo = "Sevilla", Liga = "La Liga" },
new Jugador { Nombre = "Nemanja Gudelj", Posicion = "Centrocampista", Equipo = "Sevilla", Liga = "La Liga" },
new Jugador { Nombre = "Ivan Rakitić", Posicion = "Centrocampista", Equipo =    "Sevilla", Liga = "La Liga" },
new Jugador { Nombre = "Lucas Ocampos", Posicion = "Delantero", Equipo = "Sevilla", Liga = "La Liga" },
new Jugador { Nombre = "Youssef En-Nesyri", Posicion = "Delantero", Equipo = "Sevilla", Liga = "La Liga" },
new Jugador { Nombre = "Erik Lamela", Posicion = "Delantero", Equipo = "Sevilla", Liga = "La Liga" },






        // Serie A - Juventus
        

new Jugador { Nombre = "Wojciech Szczęsny", Posicion = "Portero", Equipo = "Juventus", Liga = "Serie A" },
new Jugador { Nombre = "Danilo", Posicion = "Defensor", Equipo = "Juventus", Liga = "Serie A" },
new Jugador { Nombre = "Bremer", Posicion = "Defensor", Equipo = "Juventus", Liga = "Serie A" },
new Jugador { Nombre = "Federico Gatti", Posicion = "Defensor", Equipo = "Juventus", Liga = "Serie A" },
new Jugador { Nombre = "Juan Cuadrado", Posicion = "Defensor", Equipo = "Juventus", Liga = "Serie A" },
new Jugador { Nombre = "Manuel Locatelli", Posicion = "Centrocampista", Equipo = "Juventus", Liga = "Serie A" },
new Jugador { Nombre = "Nicolo Fagioli", Posicion = "Centrocampista", Equipo = "Juventus", Liga = "Serie A" },
new Jugador { Nombre = "Teun Koopmeiners", Posicion = "Centrocampista", Equipo = "Juventus", Liga = "Serie A" },
new Jugador { Nombre = "Federico Chiesa", Posicion = "Delantero", Equipo = "Juventus", Liga = "Serie A" },
new Jugador { Nombre = "Dusan Vlahovic", Posicion = "Delantero", Equipo = "Juventus", Liga = "Serie A" },
new Jugador { Nombre = "Arkadiusz Milik", Posicion = "Delantero", Equipo = "Juventus", Liga = "Serie A" },


new Jugador { Nombre = "Mike Maignan", Posicion = "Portero", Equipo = "AC Milan", Liga = "Serie A" },
new Jugador { Nombre = "Theo Hernández", Posicion = "Defensor", Equipo = "AC Milan", Liga = "Serie A" },
new Jugador { Nombre = "Malick Thiaw", Posicion = "Defensor", Equipo = "AC Milan", Liga = "Serie A" },
new Jugador { Nombre = "Fikayo Tomori", Posicion = "Defensor", Equipo = "AC Milan", Liga = "Serie A" },
new Jugador { Nombre = "Pierre Kalulu", Posicion = "Defensor", Equipo = "AC Milan", Liga = "Serie A" },
new Jugador { Nombre = "Ismaël Bennacer", Posicion = "Centrocampista", Equipo = "AC Milan", Liga = "Serie A" },
new Jugador { Nombre = "Ruben Loftus-Cheek", Posicion = "Centrocampista", Equipo = "AC Milan", Liga = "Serie A" },
new Jugador { Nombre = "Tijjani Reijnders", Posicion = "Centrocampista", Equipo = "AC Milan", Liga = "Serie A" },
new Jugador { Nombre = "Yunus Musah", Posicion = "Centrocampista", Equipo = "AC Milan", Liga = "Serie A" },
new Jugador { Nombre = "Rafael Leão", Posicion = "Delantero", Equipo = "AC Milan", Liga = "Serie A" },
new Jugador { Nombre = "Christian Pulisic", Posicion = "Delantero", Equipo = "AC Milan", Liga = "Serie A" },




new Jugador { Nombre = "Yann Sommer", Posicion = "Portero", Equipo = "Inter de Milán", Liga = "Serie A" },
new Jugador { Nombre = "Federico Dimarco", Posicion = "Defensor", Equipo = "Inter de Milán", Liga = "Serie A" },
new Jugador { Nombre = "Milan Škriniar", Posicion = "Defensor", Equipo = "Inter de Milán", Liga = "Serie A" },
new Jugador { Nombre = "Alessandro Bastoni", Posicion = "Defensor", Equipo = "Inter de Milán", Liga = "Serie A" },
new Jugador { Nombre = "Denzel Dumfries", Posicion = "Defensor", Equipo = "Inter de Milán", Liga = "Serie A" },
new Jugador { Nombre = "Nicolò Barella", Posicion = "Centrocampista", Equipo = "Inter de Milán", Liga = "Serie A" },
new Jugador { Nombre = "Hakan Çalhanoğlu", Posicion = "Centrocampista", Equipo = "Inter de Milán", Liga = "Serie A" },
new Jugador { Nombre = "Piotr Zieliński", Posicion = "Centrocampista", Equipo = "Inter de Milán", Liga = "Serie A" },
new Jugador { Nombre = "Lautaro Martínez", Posicion = "Delantero", Equipo = "Inter de Milán", Liga = "Serie A" },
new Jugador { Nombre = "Marcus Thuram", Posicion = "Delantero", Equipo = "Inter de Milán", Liga = "Serie A" },
new Jugador { Nombre = "Mehdi Taremi", Posicion = "Delantero", Equipo = "Inter de Milán", Liga = "Serie A" },




new Jugador { Nombre = "Rui Patrício", Posicion = "Portero", Equipo = "Roma", Liga = "Serie A" },
new Jugador { Nombre = "Zeki Çelik", Posicion = "Defensor", Equipo = "Roma", Liga = "Serie A" },
new Jugador { Nombre = "Marash Kumbulla", Posicion = "Defensor", Equipo = "Roma", Liga = "Serie A" },
new Jugador { Nombre = "Chris Smalling", Posicion = "Defensor", Equipo = "Roma", Liga = "Serie A" },
new Jugador { Nombre = "Leandro Paredes", Posicion = "Centrocampista", Equipo = "Roma", Liga = "Serie A" },
new Jugador { Nombre = "Bryan Cristante", Posicion = "Centrocampista", Equipo = "Roma", Liga = "Serie A" },
new Jugador { Nombre = "Lorenzo Pellegrini", Posicion = "Centrocampista", Equipo = "Roma", Liga = "Serie A" },
new Jugador { Nombre = "Paulo Dybala", Posicion = "Delantero", Equipo = "Roma", Liga = "Serie A" },
new Jugador { Nombre = "Tammy Abraham", Posicion = "Delantero", Equipo = "Roma", Liga = "Serie A" },
new Jugador { Nombre = "Andrea Belotti", Posicion = "Delantero", Equipo = "Roma", Liga = "Serie A" },



new Jugador { Nombre = "Alex Meret", Posicion = "Portero", Equipo = "Napoli", Liga = "Serie A" },
new Jugador { Nombre = "Giovanni Di Lorenzo", Posicion = "Defensor", Equipo = "Napoli", Liga = "Serie A" },
new Jugador { Nombre = "Kim Min-jae", Posicion = "Defensor", Equipo = "Napoli", Liga = "Serie A" },
new Jugador { Nombre = "Amir Rrahmani", Posicion = "Defensor", Equipo = "Napoli", Liga = "Serie A" },
new Jugador { Nombre = "Mario Rui", Posicion = "Defensor", Equipo = "Napoli", Liga = "Serie A" },
new Jugador { Nombre = "Stanislav Lobotka", Posicion = "Centrocampista", Equipo = "Napoli", Liga = "Serie A" },
new Jugador { Nombre = "Piotr Zieliński", Posicion = "Centrocampista", Equipo = "Napoli", Liga = "Serie A" },
new Jugador { Nombre = "Eljif Elmas", Posicion = "Centrocampista", Equipo = "Napoli", Liga = "Serie A" },
new Jugador { Nombre = "Victor Osimhen", Posicion = "Delantero", Equipo = "Napoli", Liga = "Serie A" },
new Jugador { Nombre = "Khvicha Kvaratskhelia", Posicion = "Delantero", Equipo = "Napoli", Liga = "Serie A" },
new Jugador { Nombre = "Giovanni Simeone", Posicion = "Delantero", Equipo = "Napoli", Liga = "Serie A" },













        // Bundesliga - Bayern Múnich
        new Jugador { Nombre = "Manuel Neuer", Posicion = "Portero", Equipo = "Bayern Múnich", Liga = "Bundesliga" },
new Jugador { Nombre = "Dayot Upamecano", Posicion = "Defensor", Equipo = "Bayern Múnich", Liga = "Bundesliga" },
new Jugador { Nombre = "Kim Min-Jae", Posicion = "Defensor", Equipo = "Bayern Múnich", Liga = "Bundesliga" },
new Jugador { Nombre = "Alphonso Davies", Posicion = "Defensor", Equipo = "Bayern Múnich", Liga = "Bundesliga" },
new Jugador { Nombre = "Raphaël Guerreiro", Posicion = "Defensor", Equipo = "Bayern Múnich", Liga = "Bundesliga" },
new Jugador { Nombre = "Konrad Laimer", Posicion = "Centrocampista", Equipo = "Bayern Múnich", Liga = "Bundesliga" },
new Jugador { Nombre = "Joshua Kimmich", Posicion = "Centrocampista", Equipo = "Bayern Múnich", Liga = "Bundesliga" },
new Jugador { Nombre = "Leon Goretzka", Posicion = "Centrocampista", Equipo = "Bayern Múnich", Liga = "Bundesliga" },
new Jugador { Nombre = "Leroy Sané", Posicion = "Centrocampista", Equipo = "Bayern Múnich", Liga = "Bundesliga" },
new Jugador { Nombre = "Kingsley Coman", Posicion = "Centrocampista", Equipo = "Bayern Múnich", Liga = "Bundesliga" },
new Jugador { Nombre = "Harry Kane", Posicion = "Delantero", Equipo = "Bayern Múnich", Liga = "Bundesliga" },

new Jugador { Nombre = "Gregor Kobel", Posicion = "Portero", Equipo = "Borussia Dortmund", Liga = "Bundesliga" },
new Jugador { Nombre = "Julian Brandt", Posicion = "Defensor", Equipo = "Borussia Dortmund", Liga = "Bundesliga" },
new Jugador { Nombre = "Niklas Süle", Posicion = "Defensor", Equipo = "Borussia Dortmund", Liga = "Bundesliga" },
new Jugador { Nombre = "Marius Wolf", Posicion = "Defensor", Equipo = "Borussia Dortmund", Liga = "Bundesliga" },
new Jugador { Nombre = "Nico Schlotterbeck", Posicion = "Defensor", Equipo = "Borussia Dortmund", Liga = "Bundesliga" },
new Jugador { Nombre = "Emre Can", Posicion = "Centrocampista", Equipo = "Borussia Dortmund", Liga = "Bundesliga" },
new Jugador { Nombre = "Julian Brandt", Posicion = "Centrocampista", Equipo = "Borussia Dortmund", Liga = "Bundesliga" },
new Jugador { Nombre = "Giovanni Reyna", Posicion = "Centrocampista", Equipo = "Borussia Dortmund", Liga = "Bundesliga" },
new Jugador { Nombre = "Sebastian Haller", Posicion = "Delantero", Equipo = "Borussia Dortmund", Liga = "Bundesliga" },
new Jugador { Nombre = "Serhou Guirassy", Posicion = "Delantero", Equipo = "Borussia Dortmund", Liga = "Bundesliga" },
new Jugador { Nombre = "Karim Adeyemi", Posicion = "Delantero", Equipo = "Borussia Dortmund", Liga = "Bundesliga" },


new Jugador { Nombre = "Lukáš Hrádecký", Posicion = "Portero", Equipo = "Bayer Leverkusen", Liga = "Bundesliga" },
new Jugador { Nombre = "Odilon Kossounou", Posicion = "Defensor", Equipo = "Bayer Leverkusen", Liga = "Bundesliga" },
new Jugador { Nombre = "Jonathan Tah", Posicion = "Defensor", Equipo = "Bayer Leverkusen", Liga = "Bundesliga" },
new Jugador { Nombre = "Piero Hincapié", Posicion = "Defensor", Equipo = "Bayer Leverkusen", Liga = "Bundesliga" },
new Jugador { Nombre = "Jeremie Frimpong", Posicion = "Defensor", Equipo = "Bayer Leverkusen", Liga = "Bundesliga" },
new Jugador { Nombre = "Granit Xhaka", Posicion = "Centrocampista", Equipo = "Bayer Leverkusen", Liga = "Bundesliga" },
new Jugador { Nombre = "Exequiel Palacios", Posicion = "Centrocampista", Equipo = "Bayer Leverkusen", Liga = "Bundesliga" },
new Jugador { Nombre = "Florian Wirtz", Posicion = "Centrocampista", Equipo = "Bayer Leverkusen", Liga = "Bundesliga" },
new Jugador { Nombre = "Amine Adli", Posicion = "Centrocampista", Equipo = "Bayer Leverkusen", Liga = "Bundesliga" },
new Jugador { Nombre = "Victor Boniface", Posicion = "Delantero", Equipo = "Bayer Leverkusen", Liga = "Bundesliga" },
new Jugador { Nombre = "Nadiem Amiri", Posicion = "Delantero", Equipo = "Bayer Leverkusen", Liga = "Bundesliga" },





// RB Leipzig
new Jugador { Nombre = "Janis Blaswich", Posicion = "Portero", Equipo = "RB Leipzig", Liga = "Bundesliga" },
new Jugador { Nombre = "Mohamed Simakan", Posicion = "Defensor", Equipo = "RB Leipzig", Liga = "Bundesliga" },
new Jugador { Nombre = "Josko Gvardiol", Posicion = "Defensor", Equipo = "RB Leipzig", Liga = "Bundesliga" },
new Jugador { Nombre = "David Raum", Posicion = "Defensor", Equipo = "RB Leipzig", Liga = "Bundesliga" },
new Jugador { Nombre = "Lukas Klostermann", Posicion = "Defensor", Equipo = "RB Leipzig", Liga = "Bundesliga" },
new Jugador { Nombre = "Xaver Schlager", Posicion = "Centrocampista", Equipo = "RB Leipzig", Liga = "Bundesliga" },
new Jugador { Nombre = "Kevin Kampl", Posicion = "Centrocampista", Equipo = "RB Leipzig", Liga = "Bundesliga" },
new Jugador { Nombre = "Dani Olmo", Posicion = "Centrocampista", Equipo = "RB Leipzig", Liga = "Bundesliga" },
new Jugador { Nombre = "Christopher Nkunku", Posicion = "Delantero", Equipo = "RB Leipzig", Liga = "Bundesliga" },
new Jugador { Nombre = "Timo Werner", Posicion = "Delantero", Equipo = "RB Leipzig", Liga = "Bundesliga" },
new Jugador { Nombre = "Dominik Szoboszlai", Posicion = "Delantero", Equipo = "RB Leipzig", Liga = "Bundesliga" },

// Wolfsburg
new Jugador { Nombre = "Koen Casteels", Posicion = "Portero", Equipo = "Wolfsburg", Liga = "Bundesliga" },
new Jugador { Nombre = "Ridle Baku", Posicion = "Defensor", Equipo = "Wolfsburg", Liga = "Bundesliga" },
new Jugador { Nombre = "Micky van de Ven", Posicion = "Defensor", Equipo = "Wolfsburg", Liga = "Bundesliga" },
new Jugador { Nombre = "Sebastiaan Bornauw", Posicion = "Defensor", Equipo = "Wolfsburg", Liga = "Bundesliga" },
new Jugador { Nombre = "Jerome Roussillon", Posicion = "Defensor", Equipo = "Wolfsburg", Liga = "Bundesliga" },
new Jugador { Nombre = "Maximilian Arnold", Posicion = "Centrocampista", Equipo = "Wolfsburg", Liga = "Bundesliga" },
new Jugador { Nombre = "Josuha Guilavogui", Posicion = "Centrocampista", Equipo = "Wolfsburg", Liga = "Bundesliga" },
new Jugador { Nombre = "Yannick Gerhardt", Posicion = "Centrocampista", Equipo = "Wolfsburg", Liga = "Bundesliga" },
new Jugador { Nombre = "Lukas Nmecha", Posicion = "Delantero", Equipo = "Wolfsburg", Liga = "Bundesliga" },
new Jugador { Nombre = "Jonas Wind", Posicion = "Delantero", Equipo = "Wolfsburg", Liga = "Bundesliga" },






       new Jugador { Nombre = "Gianluigi Donnarumma", Posicion = "Portero", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },
new Jugador { Nombre = "Marquinhos", Posicion = "Defensor", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },
new Jugador { Nombre = "Achraf Hakimi", Posicion = "Defensor", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },
new Jugador { Nombre = "Lucas Hernández", Posicion = "Defensor", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },
new Jugador { Nombre = "Presnel Kimpembe", Posicion = "Defensor", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },
new Jugador { Nombre = "Marco Verratti", Posicion = "Centrocampista", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },
new Jugador { Nombre = "Warren Zaire-Emery", Posicion = "Centrocampista", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },
new Jugador { Nombre = "Gonçalo Ramos", Posicion = "Delantero", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },
new Jugador { Nombre = "Ousmane Dembélé", Posicion = "Delantero", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },
new Jugador { Nombre = "Randal Kolo Muani", Posicion = "Delantero", Equipo = "Paris Saint-Germain", Liga = "Ligue 1" },


new Jugador { Nombre = "Anthony Lopes", Posicion = "Portero", Equipo = "Olympique Lyon", Liga = "Ligue 1" },
new Jugador { Nombre = "Nicolás Tagliafico", Posicion = "Defensor", Equipo = "Olympique Lyon", Liga = "Ligue 1" },
new Jugador { Nombre = "Duje Ćaleta-Car", Posicion = "Defensor", Equipo = "Olympique Lyon", Liga = "Ligue 1" },
new Jugador { Nombre = "Saël Kumbedi", Posicion = "Defensor", Equipo = "Olympique Lyon", Liga = "Ligue 1" },
new Jugador { Nombre = "Maxence Caqueret", Posicion = "Centrocampista", Equipo = "Olympique Lyon", Liga = "Ligue 1" },
new Jugador { Nombre = "Jordan Veretout", Posicion = "Centrocampista", Equipo = "Olympique Lyon", Liga = "Ligue 1" },
new Jugador { Nombre = "Corentin Tolisso", Posicion = "Centrocampista", Equipo = "Olympique Lyon", Liga = "Ligue 1" },
new Jugador { Nombre = "Alexandre Lacazette", Posicion = "Delantero", Equipo = "Olympique Lyon", Liga = "Ligue 1" },
new Jugador { Nombre = "Rayan Cherki", Posicion = "Delantero", Equipo = "Olympique Lyon", Liga = "Ligue 1" },
new Jugador { Nombre = "Wilfried Zaha", Posicion = "Delantero", Equipo = "Olympique Lyon", Liga = "Ligue 1" },


new Jugador { Nombre = "Pau López", Posicion = "Portero", Equipo = "Olympique Marsella", Liga = "Ligue 1" },
new Jugador { Nombre = "Chancel Mbemba", Posicion = "Defensor", Equipo = "Olympique Marsella", Liga = "Ligue 1" },
new Jugador { Nombre = "Leonardo Balerdi", Posicion = "Defensor", Equipo = "Olympique Marsella", Liga = "Ligue 1" },
new Jugador { Nombre = "Sead Kolašinac", Posicion = "Defensor", Equipo = "Olympique Marsella", Liga = "Ligue 1" },
new Jugador { Nombre = "Amine Harit", Posicion = "Centrocampista", Equipo = "Olympique Marsella", Liga = "Ligue 1" },
new Jugador { Nombre = "Valentin Rongier", Posicion = "Centrocampista", Equipo = "Olympique Marsella", Liga = "Ligue 1" },
new Jugador { Nombre = "Iliman Ndiaye", Posicion = "Centrocampista", Equipo = "Olympique Marsella", Liga = "Ligue 1" },
new Jugador { Nombre = "Azzedine Ounahi", Posicion = "Centrocampista", Equipo = "Olympique Marsella", Liga = "Ligue 1" },
new Jugador { Nombre = "Alexis Sánchez", Posicion = "Delantero", Equipo = "Olympique Marsella", Liga = "Ligue 1" },

new Jugador { Nombre = "Lucas Chevalier", Posicion = "Portero", Equipo = "Lille", Liga = "Ligue 1" },
new Jugador { Nombre = "Tiago Djalo", Posicion = "Defensor", Equipo = "Lille", Liga = "Ligue 1" },
new Jugador { Nombre = "José Fonte", Posicion = "Defensor", Equipo = "Lille", Liga = "Ligue 1" },
new Jugador { Nombre = "Gabriel Gudmundsson", Posicion = "Defensor", Equipo = "Lille", Liga = "Ligue 1" },
new Jugador { Nombre = "Benjamin André", Posicion = "Centrocampista", Equipo = "Lille", Liga = "Ligue 1" },
new Jugador { Nombre = "Amadou Onana", Posicion = "Centrocampista", Equipo = "Lille", Liga = "Ligue 1" },
new Jugador { Nombre = "José Ángel Esmorís Tasende", Posicion = "Centrocampista", Equipo = "Lille", Liga = "Ligue 1" },
new Jugador { Nombre = "Jonathan David", Posicion = "Delantero", Equipo = "Lille", Liga = "Ligue 1" },
new Jugador { Nombre = "Jonathan Bamba", Posicion = "Delantero", Equipo = "Lille", Liga = "Ligue 1" },


new Jugador { Nombre = "Alexander Nübel", Posicion = "Portero", Equipo = "Monaco", Liga = "Ligue 1" },
new Jugador { Nombre = "Axel Disasi", Posicion = "Defensor", Equipo = "Monaco", Liga = "Ligue 1" },
new Jugador { Nombre = "Guillermo Maripan", Posicion = "Defensor", Equipo = "Monaco", Liga = "Ligue 1" },
new Jugador { Nombre = "Malang Sarr", Posicion = "Defensor", Equipo = "Monaco", Liga = "Ligue 1" },
new Jugador { Nombre = "Mohamed Camara", Posicion = "Centrocampista", Equipo = "Monaco", Liga = "Ligue 1" },
new Jugador { Nombre = "Aurélien Tchouaméni", Posicion = "Centrocampista", Equipo = "Monaco", Liga = "Ligue 1" },
new Jugador { Nombre = "Sofiane Diop", Posicion = "Centrocampista", Equipo = "Monaco", Liga = "Ligue 1" },
new Jugador { Nombre = "Eliesse Ben Seghir", Posicion = "Centrocampista", Equipo = "Monaco", Liga = "Ligue 1" },




        // MLS - LA Galaxy
       new Jugador { Nombre = "Jonathan Bond", Posicion = "Portero", Equipo = "LA Galaxy", Liga = "MLS" },
new Jugador { Nombre = "Julian Araujo", Posicion = "Defensor", Equipo = "LA Galaxy", Liga = "MLS" },
new Jugador { Nombre = "Jalen Neal", Posicion = "Defensor", Equipo = "LA Galaxy", Liga = "MLS" },
new Jugador { Nombre = "Raheem Edwards", Posicion = "Defensor", Equipo = "LA Galaxy", Liga = "MLS" },
new Jugador { Nombre = "Victor Vazquez", Posicion = "Centrocampista", Equipo = "LA Galaxy", Liga = "MLS" },
new Jugador { Nombre = "Riqui Puig", Posicion = "Centrocampista", Equipo = "LA Galaxy", Liga = "MLS" },
new Jugador { Nombre = "Chicharito Hernández", Posicion = "Delantero", Equipo = "LA Galaxy", Liga = "MLS" },
new Jugador { Nombre = "Douglas Costa", Posicion = "Delantero", Equipo = "LA Galaxy", Liga = "MLS" },

new Jugador { Nombre = "Drake Callender", Posicion = "Portero", Equipo = "Inter Miami", Liga = "MLS" },
new Jugador { Nombre = "DeAndre Yedlin", Posicion = "Defensor", Equipo = "Inter Miami", Liga = "MLS" },
new Jugador { Nombre = "Sergio Busquets", Posicion = "Centrocampista", Equipo = "Inter Miami", Liga = "MLS" },
new Jugador { Nombre = "Lionel Messi", Posicion = "Delantero", Equipo = "Inter Miami", Liga = "MLS" },
new Jugador { Nombre = "Luis Suárez", Posicion = "Delantero", Equipo = "Inter Miami", Liga = "MLS" },
new Jugador { Nombre = "Jordi Alba", Posicion = "Defensor", Equipo = "Inter Miami", Liga = "MLS" },
new Jugador { Nombre = "Facundo Farías", Posicion = "Centrocampista", Equipo = "Inter Miami", Liga = "MLS" },
new Jugador { Nombre = "Robert Taylor", Posicion = "Centrocampista", Equipo = "Inter Miami", Liga = "MLS" },


new Jugador { Nombre = "Sean Johnson", Posicion = "Portero", Equipo = "New York City FC", Liga = "MLS" },
new Jugador { Nombre = "Thiago Martins", Posicion = "Defensor", Equipo = "New York City FC", Liga = "MLS" },
new Jugador { Nombre = "Maxime Chanot", Posicion = "Defensor", Equipo = "New York City FC", Liga = "MLS" },
new Jugador { Nombre = "Santi Rodríguez", Posicion = "Centrocampista", Equipo = "New York City FC", Liga = "MLS" },
new Jugador { Nombre = "Talles Magno", Posicion = "Delantero", Equipo = "New York City FC", Liga = "MLS" },
new Jugador { Nombre = "Gabriel Pereira", Posicion = "Centrocampista", Equipo = "New York City FC", Liga = "MLS" },
new Jugador { Nombre = "Luis Barraza", Posicion = "Portero", Equipo = "New York City FC", Liga = "MLS" },





        new Jugador { Nombre = "Anatoliy Trubin", Posicion = "Portero", Equipo = "Benfica", Liga = "Primeira Liga" },
new Jugador { Nombre = "Nicolás Otamendi", Posicion = "Defensor", Equipo = "Benfica", Liga = "Primeira Liga" },
new Jugador { Nombre = "Álex Bah", Posicion = "Defensor", Equipo = "Benfica", Liga = "Primeira Liga" },
new Jugador { Nombre = "António Silva", Posicion = "Defensor", Equipo = "Benfica", Liga = "Primeira Liga" },
new Jugador { Nombre = "Issa Kaboré", Posicion = "Defensor", Equipo = "Benfica", Liga = "Primeira Liga" },
new Jugador { Nombre = "Florentino", Posicion = "Centrocampista", Equipo = "Benfica", Liga = "Primeira Liga" },
new Jugador { Nombre = "Orkun Kökçü", Posicion = "Centrocampista", Equipo = "Benfica", Liga = "Primeira Liga" },
new Jugador { Nombre = "Fredrik Aursnes", Posicion = "Centrocampista", Equipo = "Benfica", Liga = "Primeira Liga" },
new Jugador { Nombre = "Ángel Di María", Posicion = "Delantero", Equipo = "Benfica", Liga = "Primeira Liga" },
new Jugador { Nombre = "Arthur Cabral", Posicion = "Delantero", Equipo = "Benfica", Liga = "Primeira Liga" },




        new Jugador { Nombre = "Beto", Posicion = "Portero", Equipo = "Portimonense", Liga = "Primeira Liga" },
new Jugador { Nombre = "Koki Anzai", Posicion = "Defensor", Equipo = "Portimonense", Liga = "Primeira Liga" },
new Jugador { Nombre = "Lucas Possignolo", Posicion = "Defensor", Equipo = "Portimonense", Liga = "Primeira Liga" },
new Jugador { Nombre = "Murat Sağlam", Posicion = "Centrocampista", Equipo = "Portimonense", Liga = "Primeira Liga" },
new Jugador { Nombre = "Gustavo Sangaré", Posicion = "Centrocampista", Equipo = "Portimonense", Liga = "Primeira Liga" },
new Jugador { Nombre = "Beto", Posicion = "Delantero", Equipo = "Portimonense", Liga = "Primeira Liga" },


new Jugador { Nombre = "Diogo Costa", Posicion = "Portero", Equipo = "Porto", Liga = "Primeira Liga" },
new Jugador { Nombre = "Pepe", Posicion = "Defensor", Equipo = "Porto", Liga = "Primeira Liga" },
new Jugador { Nombre = "Chancel Mbemba", Posicion = "Defensor", Equipo = "Porto", Liga = "Primeira Liga" },
new Jugador { Nombre = "Otávio", Posicion = "Centrocampista", Equipo = "Porto", Liga = "Primeira Liga" },
new Jugador { Nombre = "Musa", Posicion = "Delantero", Equipo = "Porto", Liga = "Primeira Liga" },






    };

            return jugadores.Where(j => j.Liga == liga && j.Equipo == equipo).ToList();
        }

    }
}
