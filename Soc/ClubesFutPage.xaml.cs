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

                List<string> teams = league switch
                {
                    "Premier League" => new List<string>
    {
        "Arsenal", "Aston Villa", "Bournemouth", "Brentford", "Brighton & Hove Albion",
        "Burnley", "Chelsea", "Crystal Palace", "Everton", "Fulham",
        "Liverpool", "Luton Town", "Manchester City", "Manchester United",
        "Newcastle United", "Nottingham Forest", "Sheffield United",
        "Tottenham Hotspur", "West Ham United", "Wolverhampton Wanderers"
    },
                    "Serie A" => new List<string>
    {
        "Atalanta", "Bologna", "Cagliari", "Empoli", "Fiorentina",
        "Genoa", "Hellas Verona", "Inter de Mil�n", "Juventus", "Lazio",
        "Lecce", "AC Milan", "Monza", "Napoli", "Roma",
        "Salernitana", "Sassuolo", "Torino", "Udinese", "Frosinone"
    },
                    "Bundesliga" => new List<string>
    {
        "Augsburgo", "Bayer Leverkusen", "Bayern M�nich", "Bochum", "Borussia Dortmund",
        "Borussia M�nchengladbach", "Darmstadt 98", "Eintracht Frankfurt", "Friburgo",
        "Heidenheim", "Hoffenheim", "K�ln", "Mainz 05", "RB Leipzig",
        "Stuttgart", "Union Berl�n", "Werder Bremen", "Wolfsburgo"
    },
                    "Ligue 1" => new List<string>
    {
        "AS M�naco", "Clermont Foot", "Havre AC", "Lens", "Lille",
        "Lorient", "Lyon", "Marsella", "Metz", "Montpellier",
        "Nantes", "Nice", "Paris Saint-Germain", "Reims",
        "Rennes", "Strasbourg", "Toulouse", "Brest"
    },
                    "LaLiga" => new List<string>
    {
        "Alav�s", "Almer�a", "Athletic Club", "Atl�tico Madrid", "Barcelona",
        "C�diz", "Celta de Vigo", "Getafe", "Girona", "Granada",
        "Las Palmas", "Mallorca", "Osasuna", "Rayo Vallecano",
        "Real Betis", "Real Madrid", "Real Sociedad", "Sevilla",
        "Valencia", "Villarreal"
    },
                    "Eredivisie" => new List<string>
    {
        "Ajax", "AZ Alkmaar", "Excelsior", "Feyenoord", "Fortuna Sittard",
        "Go Ahead Eagles", "Heracles Almelo", "NEC Nijmegen", "PSV Eindhoven",
        "RKC Waalwijk", "SC Cambuur", "Sparta Rotterdam", "Twente",
        "Utrecht", "Vitesse", "Volendam", "Willem II", "Zwolle"
    },
                    "Primeira Liga" => new List<string>
    {
        "Arouca", "Benfica", "Boavista", "Braga", "Casa Pia",
        "Chaves", "Estoril", "Famalic�o", "Gil Vicente", "Moreirense",
        "Portimonense", "Porto", "Rio Ave", "Sporting CP",
        "Vizela", "Vit�ria de Guimar�es"
    },
                    "Russian Premier League" => new List<string>
    {
        "Akhmat Grozny", "Baltika Kaliningrad", "CSKA Mosc�", "Dinamo Mosc�",
        "Fakel Voronezh", "Krylia Sovetov", "Khimki", "Lokomotiv Mosc�",
        "Nizhny Novgorod", "Orenburg", "Rostov", "Rubin Kazan",
        "Sochi", "Spartak Mosc�", "Ural", "Zenit San Petersburgo"
    },



                    "Argentina Primera Divisi�n" => new List<string>
    {
        "Argentinos Juniors", "Arsenal", "Atl�tico Tucum�n", "Banfield", "Barracas Central",
        "Belgrano", "Boca Juniors", "Central C�rdoba", "Col�n", "Defensa y Justicia",
        "Estudiantes", "Gimnasia", "Godoy Cruz", "Hurac�n", "Independiente",
        "Instituto", "Lan�s", "Newell's Old Boys", "Platense", "Racing Club",
        "River Plate", "Rosario Central", "San Lorenzo", "Sarmiento", "Tigre",
        "Uni�n", "V�lez Sarsfield"
    },
                    "Brasil Serie A" => new List<string>
    {
        "Am�rica Mineiro", "Atl�tico Mineiro", "Atl�tico Paranaense", "Bah�a", "Botafogo",
        "Corinthians", "Coritiba", "Cuiab�", "Cruzeiro", "Flamengo",
        "Fluminense", "Fortaleza", "Goi�s", "Gr�mio", "Internacional",
        "Palmeiras", "Red Bull Bragantino", "Santos", "S�o Paulo", "Vasco da Gama"
    },
                    "Chile Primera Divisi�n" => new List<string>
    {
        "Audax Italiano", "Coquimbo Unido", "Colo Colo", "Curic� Unido", "Everton",
        "Huachipato", "Magallanes", "�ublense", "O'Higgins", "Palestino",
        "Cobresal", "Santiago Wanderers", "Uni�n Espa�ola", "Uni�n La Calera",
        "Universidad Cat�lica", "Universidad de Chile"
    },


                    "Colombia Liga BetPlay" => new List<string>
    {
        "�guilas Doradas", "Am�rica de Cali", "Atl�tico Bucaramanga", "Atl�tico Huila",
        "Atl�tico Nacional", "Boyac� Chic�", "Deportivo Cali", "Deportivo Pasto",
        "Deportes Tolima", "Envigado", "Independiente Medell�n", "Independiente Santa Fe",
        "Junior", "La Equidad", "Millonarios", "Once Caldas", "Uni�n Magdalena", "Jaguares"
    },
                    "Per� Liga 1" => new List<string>
    {
        "Alianza Atl�tico", "Alianza Lima", "Atl�tico Grau", "Binacional", "C�sar Vallejo",
        "Carlos A. Mannucci", "Cantolao", "Cusco FC", "Cienciano", "Deportivo Garcilaso",
        "Deportivo Municipal", "Melgar", "Sport Boys", "Sport Huancayo", "Universitario",
        "UTC", "Uni�n Comercio"
    },
                    "Uruguay Primera Divisi�n" => new List<string>
    {
        "Boston River", "Cerro Largo", "Danubio", "Defensor Sporting", "Deportivo Maldonado",
        "F�nix", "La Luz", "Liverpool", "Montevideo City Torque", "Montevideo Wanderers",
        "Nacional", "Pe�arol", "Plaza Colonia", "Racing", "River Plate", "Cerro"
    },


                    "Ecuador Serie A" => new List<string>
    {
        "Aucas", "Barcelona SC", "Cumbay�", "Delf�n", "Deportivo Cuenca",
        "El Nacional", "Emelec", "Gualaceo", "Guayaquil City", "Independiente del Valle",
        "LDU Quito", "Libertad", "Mushuc Runa", "Orense", "Tecnico Universitario"
    },
                    "Paraguay Primera Divisi�n" => new List<string>
    {
        "Cerro Porte�o", "Club Guaran�", "General Caballero", "Guaire�a", "Libertad",
        "Nacional", "Olimpia", "Resistencia", "Sportivo Ameliano", "Sportivo Luque�o",
        "Tacuary", "Trinidense"
    },
                    "Bolivia Primera Divisi�n" => new List<string>
    {
        "Always Ready", "Aurora", "Blooming", "Bol�var", "Guabir�",
        "Independiente Petrolero", "Nacional Potos�", "Oriente Petrolero",
        "Palmaflor", "Real Santa Cruz", "Royal Pari", "The Strongest",
        "Universitario de Vinto", "Vaca D�ez", "Libertad Gran Mamor�"
    },


                    "Venezuela Primera Divisi�n" => new List<string>
    {
        "Academia Puerto Cabello", "Angostura", "Caracas FC", "Carabobo", "Deportivo La Guaira",
        "Deportivo Lara", "Deportivo T�chira", "Estudiantes de M�rida", "Hermanos Colmen�rez",
        "Metropolitanos", "Mineros de Guayana", "Monagas", "Portuguesa FC", "Rayo Zuliano",
        "Zamora FC"
    },








                    // **Centroam�rica** - Equipos de las ligas centroamericanas
                    "Costa Rica Primera Divisi�n" => new List<string>
    {
        "AD Guanacasteca", "AD San Carlos", "CS Cartagin�s", "Deportivo Saprissa",
        "Grecia", "Herediano", "Jicaral Sercoba", "Lim�n FC", "Municipal P�rez Zeled�n",
        "Puntarenas FC", "Santos de Gu�piles", "Sporting FC"
    },
                    "El Salvador Primera Divisi�n" => new List<string>
    {
        "Alianza", "�guila", "Chalatenango", "FAS", "Firpo", "Isidro Metap�n",
        "Jocoro", "Lime�o", "Once Deportivo", "Santa Tecla"
    },
                    "Guatemala Liga Nacional" => new List<string>
    {
        "Antigua GFC", "Coban Imperial", "Deportivo Guastatoya", "Deportivo Malacateco",
        "Municipal", "Xelaj� MC", "Santa Lucia Cotzumalguapa", "Achuapa", "Solol�", "Iztapa"
    },
                    "Honduras Liga Nacional" => new List<string>
    {
        "Atl�tico Choloma", "Club Deportivo Olimpia", "Club Deportivo Motagua", "Real Espa�a",
        "Club Deportivo Honduras Progreso", "Platense", "Juticalpa FC", "UPNFM", "Vida"
    },


                    "Nicaragua Liga Primera" => new List<string>
    {
        "Real Estel�", "Diriang�n", "Chinandega", "Club Deportivo Walter Ferreti", "Estel�",
        "Jinotega", "Managua FC", "Nicaragua FC", "Unan Managua", "Deportivo Ocotal"
    },

                    // **Norteam�rica** - Equipos de las ligas de Norteam�rica
                    "M�xico Liga MX" => new List<string>
    {
        "Am�rica", "Atlas", "Cruz Azul", "Club Le�n", "Club Tijuana", "Chivas", "Monterrey",
        "Necaxa", "Puebla", "Quer�taro", "Santos Laguna", "Toluca", "Tigres UANL", "Pumas UNAM",
        "Ju�rez", "Mazatl�n", "Pachuca"
    },
                    "Estados Unidos Major League Soccer" => new List<string>
    {
        "Atlanta United", "Chicago Fire", "FC Cincinnati", "Colorado Rapids", "Columbus Crew",
        "D.C. United", "FC Dallas", "Houston Dynamo", "Inter Miami", "LA Galaxy", "LAFC", "Minnesota United",
        "Montreal Impact", "Nashville SC", "New England Revolution", "New York City FC", "New York Red Bulls",
        "Orlando City", "Philadelphia Union", "Portland Timbers", "Real Salt Lake", "San Jose Earthquakes",
        "Seattle Sounders", "Sporting Kansas City", "Toronto FC", "Vancouver Whitecaps"
    },
                    "Canad� Major League Soccer" => new List<string>
    {
        "Toronto FC", "Vancouver Whitecaps", "Montreal Impact"
    },



                    "Sud�frica Premier Division" => new List<string>
{
    "AmaZulu", "Cape Town City", "Chippa United", "Golden Arrows", "Kaizer Chiefs",
    "Maritzburg United", "Mamelodi Sundowns", "Moroka Swallows", "Orlando Pirates",
    "Richards Bay", "Sekhukhune United", "Stellenbosch", "SuperSport United",
    "TS Galaxy"
},
                    "Egipto Premier League" => new List<string>
{
    "Al Ahly", "Al Ittihad", "Al Masry", "Aswan", "El Dakhleya",
    "El Gaish", "El Mokawloon", "El Zamalek", "Enppi", "Ghazl El Mahalla",
    "Ismaily", "National Bank", "Pyramids", "Smouha", "Future FC",
    "Ceramica Cleopatra", "Pharco", "Haras El Hodood"
},










                };


                // Navega a una nueva p�gina mostrando los equipos
                await Navigation.PushAsync(new TeamsPage(league, teams));
            }
        }
    }
}

