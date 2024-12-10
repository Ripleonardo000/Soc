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



                    // **Europa** - Equipos de las ligas europeas

                    // Premier League
                    "Premier League" => new List<string>
{
    "Arsenal", "Aston Villa", "Bournemouth", "Brentford", "Brighton & Hove Albion",
    "Burnley", "Chelsea", "Crystal Palace", "Everton", "Fulham",
    "Liverpool", "Luton Town", "Manchester City", "Manchester United",
    "Newcastle United", "Nottingham Forest", "Sheffield United",
    "Tottenham Hotspur", "West Ham United", "Wolverhampton Wanderers"
},

                    // Serie A
                    "Serie A" => new List<string>
{
    "Atalanta", "Bologna", "Cagliari", "Empoli", "Fiorentina",
    "Genoa", "Hellas Verona", "Inter de Milán", "Juventus", "Lazio",
    "Lecce", "AC Milan", "Monza", "Napoli", "Roma",
    "Salernitana", "Sassuolo", "Torino", "Udinese", "Frosinone"
},

                    // Bundesliga
                    "Bundesliga" => new List<string>
{
    "Augsburgo", "Bayer Leverkusen", "Bayern Múnich", "Bochum", "Borussia Dortmund",
    "Borussia Mönchengladbach", "Darmstadt 98", "Eintracht Frankfurt", "Friburgo",
    "Heidenheim", "Hoffenheim", "Köln", "Mainz 05", "RB Leipzig",
    "Stuttgart", "Union Berlín", "Werder Bremen", "Wolfsburgo"
},

                    // Ligue 1
                    "Ligue 1" => new List<string>
{
    "AS Mónaco", "Clermont Foot", "Havre AC", "Lens", "Lille",
    "Lorient", "Lyon", "Marsella", "Metz", "Montpellier",
    "Nantes", "Nice", "Paris Saint-Germain", "Reims",
    "Rennes", "Strasbourg", "Toulouse", "Brest"
},

                    // LaLiga
                    "LaLiga" => new List<string>
{
    "Alavés", "Almería", "Athletic Club", "Atlético Madrid", "Barcelona",
    "Cádiz", "Celta de Vigo", "Getafe", "Girona", "Granada",
    "Las Palmas", "Mallorca", "Osasuna", "Rayo Vallecano",
    "Real Betis", "Real Madrid", "Real Sociedad", "Sevilla",
    "Valencia", "Villarreal"
},

                    // Eredivisie
                    "Eredivisie" => new List<string>
{
    "Ajax", "AZ Alkmaar", "Excelsior", "Feyenoord", "Fortuna Sittard",
    "Go Ahead Eagles", "Heracles Almelo", "NEC Nijmegen", "PSV Eindhoven",
    "RKC Waalwijk", "SC Cambuur", "Sparta Rotterdam", "Twente",
    "Utrecht", "Vitesse", "Volendam", "Willem II", "Zwolle"
},

                    // Primeira Liga
                    "Primeira Liga" => new List<string>
{
    "Arouca", "Benfica", "Boavista", "Braga", "Casa Pia",
    "Chaves", "Estoril", "Famalicão", "Gil Vicente", "Moreirense",
    "Portimonense", "Porto", "Rio Ave", "Sporting CP",
    "Vizela", "Vitória de Guimarães"
},

                    // Russian Premier League
                    "Russian Premier League" => new List<string>
{
    "Akhmat Grozny", "Baltika Kaliningrad", "CSKA Moscú", "Dinamo Moscú",
    "Fakel Voronezh", "Krylia Sovetov", "Khimki", "Lokomotiv Moscú",
    "Nizhny Novgorod", "Orenburg", "Rostov", "Rubin Kazan",
    "Sochi", "Spartak Moscú", "Ural", "Zenit San Petersburgo"
},

                    // **Otras ligas europeas**

                    "Belgian Pro League" => new List<string>
{
    "Anderlecht", "Antwerp", "Club Brugge", "Genk", "Ghent",
    "Kortrijk", "Mechelen", "Oostende", "Sint-Truiden", "Standard Liège",
    "Zulte Waregem", "Cercle Brugge"
},

                    "Swiss Super League" => new List<string>
{
    "Basel", "Basilea", "Young Boys", "Zurich", "Servette",
    "Sion", "St. Gallen", "Lugano", "Luzern", "Thun"
},

                    "Austrian Bundesliga" => new List<string>
{
    "Austria Wien", "Red Bull Salzburg", "Sturm Graz", "LASK", "Rapid Viena",
    "WAC", "SV Ried", "Austria Klagenfurt", "Altach", "Hartberg"
},

                    "Turkish Süper Lig" => new List<string>
{
    "Galatasaray", "Fenerbahçe", "Beşiktaş", "Trabzonspor", "Başakşehir",
    "Sivasspor", "Antalyaspor", "Alanyaspor", "Gaziantep", "Konyaspor",
    "Adana Demirspor", "Karagümrük", "Kayserispor", "Göztepe"
},

                    "Greek Super League" => new List<string>
{
    "Olympiakos", "PAOK", "AEK Atenas", "Aris", "Atromitos",
    "Asteras Tripolis", "Lamia", "Volos", "Ionikos", "PAE Veria",
    "OFI Creta", "Larissa"
},

                    "Norwegian Eliteserien" => new List<string>
{
    "Bodø/Glimt", "Molde", "Rosenborg", "Viking", "Sarpsborg 08",
    "Tromsø", "Odd", "Kristiansund", "Stabæk", "Strømsgodset",
    "Vålerenga", "Sandefjord"
},

                    "Denmark Superliga" => new List<string>
{
    "Copenhagen", "Midtjylland", "Brøndby", "Aarhus", "Odense",
    "Randers", "Nordsjælland", "SønderjyskE", "Vejle", "Lyngby"
},


                   


























                    "Argentina Primera División" => new List<string>
    {
        "Argentinos Juniors", "Arsenal", "Atlético Tucumán", "Banfield", "Barracas Central",
        "Belgrano", "Boca Juniors", "Central Córdoba", "Colón", "Defensa y Justicia",
        "Estudiantes", "Gimnasia", "Godoy Cruz", "Huracán", "Independiente",
        "Instituto", "Lanús", "Newell's Old Boys", "Platense", "Racing Club",
        "River Plate", "Rosario Central", "San Lorenzo", "Sarmiento", "Tigre",
        "Unión", "Vélez Sarsfield"
    },
                    "Brasil Serie A" => new List<string>
    {
        "América Mineiro", "Atlético Mineiro", "Atlético Paranaense", "Bahía", "Botafogo",
        "Corinthians", "Coritiba", "Cuiabá", "Cruzeiro", "Flamengo",
        "Fluminense", "Fortaleza", "Goiás", "Grêmio", "Internacional",
        "Palmeiras", "Red Bull Bragantino", "Santos", "São Paulo", "Vasco da Gama"
    },
                    "Chile Primera División" => new List<string>
    {
        "Audax Italiano", "Coquimbo Unido", "Colo Colo", "Curicó Unido", "Everton",
        "Huachipato", "Magallanes", "Ñublense", "O'Higgins", "Palestino",
        "Cobresal", "Santiago Wanderers", "Unión Española", "Unión La Calera",
        "Universidad Católica", "Universidad de Chile"
    },


                    "Colombia Liga BetPlay" => new List<string>
    {
        "Águilas Doradas", "América de Cali", "Atlético Bucaramanga", "Atlético Huila",
        "Atlético Nacional", "Boyacá Chicó", "Deportivo Cali", "Deportivo Pasto",
        "Deportes Tolima", "Envigado", "Independiente Medellín", "Independiente Santa Fe",
        "Junior", "La Equidad", "Millonarios", "Once Caldas", "Unión Magdalena", "Jaguares"
    },
                    "Perú Liga 1" => new List<string>
    {
        "Alianza Atlético", "Alianza Lima", "Atlético Grau", "Binacional", "César Vallejo",
        "Carlos A. Mannucci", "Cantolao", "Cusco FC", "Cienciano", "Deportivo Garcilaso",
        "Deportivo Municipal", "Melgar", "Sport Boys", "Sport Huancayo", "Universitario",
        "UTC", "Unión Comercio"
    },
                    "Uruguay Primera División" => new List<string>
    {
        "Boston River", "Cerro Largo", "Danubio", "Defensor Sporting", "Deportivo Maldonado",
        "Fénix", "La Luz", "Liverpool", "Montevideo City Torque", "Montevideo Wanderers",
        "Nacional", "Peñarol", "Plaza Colonia", "Racing", "River Plate", "Cerro"
    },


                    "Ecuador Serie A" => new List<string>
    {
        "Aucas", "Barcelona SC", "Cumbayá", "Delfín", "Deportivo Cuenca",
        "El Nacional", "Emelec", "Gualaceo", "Guayaquil City", "Independiente del Valle",
        "LDU Quito", "Libertad", "Mushuc Runa", "Orense", "Tecnico Universitario"
    },
                    "Paraguay Primera División" => new List<string>
    {
        "Cerro Porteño", "Club Guaraní", "General Caballero", "Guaireña", "Libertad",
        "Nacional", "Olimpia", "Resistencia", "Sportivo Ameliano", "Sportivo Luqueño",
        "Tacuary", "Trinidense"
    },
                    "Bolivia Primera División" => new List<string>
    {
        "Always Ready", "Aurora", "Blooming", "Bolívar", "Guabirá",
        "Independiente Petrolero", "Nacional Potosí", "Oriente Petrolero",
        "Palmaflor", "Real Santa Cruz", "Royal Pari", "The Strongest",
        "Universitario de Vinto", "Vaca Díez", "Libertad Gran Mamoré"
    },


                    "Venezuela Primera División" => new List<string>
    {
        "Academia Puerto Cabello", "Angostura", "Caracas FC", "Carabobo", "Deportivo La Guaira",
        "Deportivo Lara", "Deportivo Táchira", "Estudiantes de Mérida", "Hermanos Colmenárez",
        "Metropolitanos", "Mineros de Guayana", "Monagas", "Portuguesa FC", "Rayo Zuliano",
        "Zamora FC"
    },








                    // **Centroamérica** - Equipos de las ligas centroamericanas
                    "Costa Rica Primera División" => new List<string>
    {
        "AD Guanacasteca", "AD San Carlos", "CS Cartaginés", "Deportivo Saprissa",
        "Grecia", "Herediano", "Jicaral Sercoba", "Limón FC", "Municipal Pérez Zeledón",
        "Puntarenas FC", "Santos de Guápiles", "Sporting FC"
    },
                    "El Salvador Primera División" => new List<string>
    {
        "Alianza", "Águila", "Chalatenango", "FAS", "Firpo", "Isidro Metapán",
        "Jocoro", "Limeño", "Once Deportivo", "Santa Tecla"
    },
                    "Guatemala Liga Nacional" => new List<string>
    {
        "Antigua GFC", "Coban Imperial", "Deportivo Guastatoya", "Deportivo Malacateco",
        "Municipal", "Xelajú MC", "Santa Lucia Cotzumalguapa", "Achuapa", "Sololá", "Iztapa"
    },
                    "Honduras Liga Nacional" => new List<string>
    {
        "Atlético Choloma", "Club Deportivo Olimpia", "Club Deportivo Motagua", "Real España",
        "Club Deportivo Honduras Progreso", "Platense", "Juticalpa FC", "UPNFM", "Vida"
    },


                    "Nicaragua Liga Primera" => new List<string>
    {
        "Real Estelí", "Diriangén", "Chinandega", "Club Deportivo Walter Ferreti", "Estelí",
        "Jinotega", "Managua FC", "Nicaragua FC", "Unan Managua", "Deportivo Ocotal"
    },

                    // **Norteamérica** - Equipos de las ligas de Norteamérica
                    "México Liga MX" => new List<string>
    {
        "América", "Atlas", "Cruz Azul", "Club León", "Club Tijuana", "Chivas", "Monterrey",
        "Necaxa", "Puebla", "Querétaro", "Santos Laguna", "Toluca", "Tigres UANL", "Pumas UNAM",
        "Juárez", "Mazatlán", "Pachuca"
    },
                    "Estados Unidos Major League Soccer" => new List<string>
    {
        "Atlanta United", "Chicago Fire", "FC Cincinnati", "Colorado Rapids", "Columbus Crew",
        "D.C. United", "FC Dallas", "Houston Dynamo", "Inter Miami", "LA Galaxy", "LAFC", "Minnesota United",
        "Montreal Impact", "Nashville SC", "New England Revolution", "New York City FC", "New York Red Bulls",
        "Orlando City", "Philadelphia Union", "Portland Timbers", "Real Salt Lake", "San Jose Earthquakes",
        "Seattle Sounders", "Sporting Kansas City", "Toronto FC", "Vancouver Whitecaps"
    },
                    "Canadá Major League Soccer" => new List<string>
    {
        "Toronto FC", "Vancouver Whitecaps", "Montreal Impact"
    },



                    "Sudáfrica Premier Division" => new List<string>
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


                    // **Asia y Países Árabes** - Equipos de las ligas asiáticas y árabes

                    "Saudi Pro League" => new List<string>
{
    "Al Ahli", "Al Ettifaq", "Al Fatesh", "Al Hilal", "Al Ittihad",
    "Al Nassr", "Al Raed", "Al Shabab", "Al Tai", "Al Wehda",
    "Abha", "Dhamk", "Al Batin"
},

                    "Arabian Gulf League" => new List<string>
{
    "Al Ain", "Al Jazira", "Al Nasr", "Al Wahda", "Al Shabab",
    "Sharjah", "Baniyas", "Khorfakkan", "Ajman", "Al Dhafra",
    "Ittihad Kalba", "Fujairah", "Hatta"
},

                    "Qatar Stars League" => new List<string>
{
    "Al Arabi", "Al Duhail", "Al Gharafa", "Al Khor", "Al Sadd",
    "Al Shamal", "Al Rayyan", "Al Wakrah", "Umm Salal", "Al Ahli",
    "Qatar SC", "Al Markhiya"
},

                    "Persian Gulf Pro League" => new List<string>
{
    "Esteghlal", "Persepolis", "Al Nassr", "Foolad", "Sepahan",
    "Naft Tehran", "Zob Ahan", "Tractor Sazi", "Shahr Khodro", "Sima Bakoon",
    "Aluminum Arak", "Gol Gohar"
},

                    "Iraqi Premier League" => new List<string>
{
    "Al Zawraa", "Al Shorta", "Al Talaba", "Al Quwa Al Jawiya", "Al Naft",
    "Al Karkh", "Al Minaa", "Najaf FC", "Duhok", "Al Naft",
    "Erbil", "Al Hikma"
},

                    "Kuwaiti Premier League" => new List<string>
{
    "Al Arabi", "Al Kuwait", "Al Salmiya", "Al Qadsia", "Al Yarmouk",
    "Al Fahaheel", "Al Jahra", "Al Shabab", "Khaitan", "Sulaibikhat",
    "Al Naser", "Fahaheel"
},

                    "Chinese Super League" => new List<string>
{
    "Beijing Guoan", "Guangzhou Evergrande", "Shanghai SIPG", "Shandong Taishan",
    "Tianjin Teda", "Hebei China Fortune", "Changchun Yatai", "Chongqing Lifan",
    "Dalian Professional", "Shenzhen", "Shanghai Shenhua", "Henan Songshan Longmen"
},

                    "J1 League" => new List<string>
{
    "Hokkaido Consadole Sapporo", "Kashima Antlers", "Kashiwa Reysol", "Vissel Kobe",
    "Urawa Reds", "Gamba Osaka", "Yokohama F. Marinos", "Sanfrecce Hiroshima",
    "FC Tokyo", "Nagoya Grampus", "Omiya Ardija", "Sagan Tosu", "Cerezo Osaka",
    "Shonan Bellmare", "Albirex Niigata"
}











                };


                // Navega a una nueva página mostrando los equipos
                await Navigation.PushAsync(new TeamsPage(league, teams));
            }
        }
    }
}

