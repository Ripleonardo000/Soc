namespace soc
{
    public partial class LigaDetailPage : ContentPage
    {
        public string LigaNombre { get; set; }
        public string LigaDescripcion { get; set; }
        public string LigaImagen { get; set; }  // Nueva propiedad para la imagen

        public string LigaHistoria { get; set; }
        public string LigaDatosImportantes { get; set; }

        public string MaximosGoleadores { get; set; }  // Nueva propiedad para los m�ximos goleadores
        public string MaximosAsistentes { get; set; }  // Nueva propiedad para los m�ximos asistentes



        public LigaDetailPage(string liga)
        {
            InitializeComponent();

            // Asignar la liga seleccionada y su descripci�n
            LigaNombre = liga;
            LigaDescripcion = GetLigaDescripcion(liga);  // Aqu� obtenemos solo la descripci�n
            LigaImagen = GetLigaImagen(liga);  // Asignar la ruta de la imagen

            var ligaInfo = GetLigaInfo(liga);  // Aqu� obtenemos la informaci�n completa de la liga

            // Asignar las propiedades Historia y DatosImportantes
            LigaHistoria = GetLigaHistoria(liga);
            LigaDatosImportantes = GetLigaDatosImportantes(liga);


            MaximosGoleadores = ligaInfo.MaximosGoleadores;
            MaximosAsistentes = ligaInfo.MaximosAsistentes;


            // Configurar el BindingContext
            BindingContext = this;
        }

        // M�todo para obtener la descripci�n de cada liga
        private string GetLigaDescripcion(string liga)
        {
            return liga switch
            {
                "Premier League" => "La Premier League es la liga de f�tbol profesional m�s importante de Inglaterra, considerada una de las competiciones m�s competitivas y atractivas del mundo. Fundada en 1992, reemplaz� a la Football League First Division como la m�xima categor�a del f�tbol ingl�s. La liga cuenta con 20 equipos y se caracteriza por su estilo de juego r�pido, f�sico y por el nivel internacional de sus jugadores y entrenadores. Equipos hist�ricos como el Manchester United, Liverpool, Arsenal, Chelsea y Manchester City han dominado la liga, que atrae a millones de espectadores globalmente.",

                "Serie A" => "Serie A es la liga de f�tbol profesional de m�s alto nivel en Italia, una de las competiciones m�s antiguas y prestigiosas del mundo. Se fund� en 1898 y ha sido cuna de grandes equipos como la Juventus, Inter de Mil�n, AC Milan y Roma. A lo largo de su historia, la Serie A ha sido conocida por su s�lido enfoque defensivo y t�ctico, siendo una de las ligas m�s formativas para jugadores y entrenadores. Adem�s, Italia ha sido sede de numerosos t�tulos internacionales, incluidas varias Copas del Mundo, lo que resalta el nivel de su liga. La Serie A sigue siendo una de las ligas m�s seguidas a nivel mundial.",

                "Bundesliga" => "La Bundesliga es la liga de f�tbol profesional en Alemania, fundada en 1963. Reconocida por su ambiente vibrante, estadios modernos y una s�lida infraestructura futbol�stica, la Bundesliga ha producido algunos de los equipos m�s exitosos de Europa, como el Bayern de M�nich y el Borussia Dortmund. Es conocida por su estilo de juego din�mico y r�pido, con un �nfasis en el desarrollo juvenil y una fuerte estructura de clubes, muchos de los cuales est�n gestionados como sociedades deportivas de base. La liga tambi�n es famosa por su equilibrio competitivo y por la gran asistencia de aficionados a los estadios.",

                "Ligue 1" => "Ligue 1 es la m�xima categor�a del f�tbol profesional en Francia, fundada en 1932. Es conocida por ser la liga donde han brillado algunos de los mejores jugadores del mundo, como Zinedine Zidane, Thierry Henry, y actualmente Kylian Mbapp�. Ligue 1 es una liga que hist�ricamente ha estado dominada por el Paris Saint-Germain, especialmente despu�s de su adquisici�n por inversores catar�es en 2011, lo que ha tra�do consigo un fuerte ascenso del club en Europa. Adem�s, la liga francesa ha sido una cantera importante para j�venes talentos que luego se destacan en grandes competiciones internacionales.",

                _ => "Descripci�n no disponible"
            };
        }


        // M�todo para obtener la ruta de la imagen de cada liga
        private string GetLigaImagen(string liga)
        {
            return liga switch
            {



                


                "Premier League" => "premier_league.png",
                "Serie A" => "serie_a.png",
                "Bundesliga" => "bundesliga.png",
                "Ligue 1" => "ligue_1.png",
                _ => "default.png"  // Imagen por defecto si no se encuentra la liga
            };
        }

        private LigaInfo GetLigaInfo(string liga)
        {
            return liga switch
            {
                "Premier League" => new LigaInfo
                {
                    Nombre = "Premier League",
                    Descripcion = "La Premier League es la liga de f�tbol profesional en Inglaterra. Adem�s de la liga, existen competiciones como la FA Cup y la Carabao Cup, que enfrentan a equipos de distintas divisiones. Los equipos m�s destacados de la Premier League tambi�n compiten en torneos internacionales como la UEFA Champions League y la UEFA Europa League. " +
                        "Los cl�sicos m�s importantes son el 'North West Derby' entre Liverpool y Manchester United, el 'North London Derby' entre Arsenal y Tottenham, y el 'Manchester Derby' entre Manchester City y Manchester United.",
                    Historia = "Fundada en 1992, la Premier League reemplaz� a la antigua First Division de Inglaterra, transform�ndose en una de las ligas m�s competitivas y medi�ticas del mundo.",
                    DatosImportantes = "Equipos m�s importantes: Manchester United, Liverpool, Arsenal, Chelsea, Manchester City. Equipos recientes en dominar: Manchester City, Liverpool.",
                    MaximosGoleadores = "Alan Shearer (260 goles), Wayne Rooney (208 goles).",
                    MaximosAsistentes = "Ryan Giggs (162 asistencias), Frank Lampard (102 asistencias)."
                },

                "Serie A" => new LigaInfo
                {
                    Nombre = "Serie A",
                    Descripcion = "La Serie A es la liga de f�tbol profesional en Italia. Las competiciones nacionales incluyen la Serie A, la Coppa Italia y la Supercoppa Italiana. A nivel internacional, los equipos de la Serie A compiten en la UEFA Champions League, la UEFA Europa League y la UEFA Conference League. " +
                        "Los cl�sicos m�s destacados incluyen el 'Derby della Madonnina' entre el AC Milan e Inter de Mil�n, el 'Derby d'Italia' entre Juventus y el Inter de Mil�n, y el 'Derby della Capitale' entre Roma y Lazio.",
                    Historia = "Fundada en 1898, la Serie A ha sido hogar de algunos de los clubes m�s grandes y exitosos de Europa, especialmente en la d�cada de 1980 y 1990, cuando equipos como Juventus, AC Milan e Inter dominaron tanto a nivel nacional como europeo.",
                    DatosImportantes = "Equipos m�s importantes: Juventus, AC Milan, Inter de Mil�n, Roma, Napoli. La liga ha sido dominada hist�ricamente por Juventus en los �ltimos a�os.",
                    MaximosGoleadores = "Silvio Piola (274 goles), Francesco Totti (250 goles).",
                    MaximosAsistentes = "Francesco Totti (199 asistencias), Giuseppe Meazza (151 asistencias)."
                },

                "Bundesliga" => new LigaInfo
                {
                    Nombre = "Bundesliga",
                    Descripcion = "La Bundesliga es la liga de f�tbol profesional en Alemania. Adem�s de la liga, la Copa de Alemania (DFB-Pokal) es la principal competencia interna. Los equipos de la Bundesliga tambi�n compiten en la UEFA Champions League y la UEFA Europa League. " +
                        "Los principales cl�sicos son el 'Der Klassiker' entre Bayern M�nich y Borussia Dortmund, y el 'Revierderby' entre Schalke 04 y Borussia Dortmund.",
                    Historia = "Fundada en 1963, la Bundesliga ha crecido hasta convertirse en una de las ligas m�s poderosas de Europa, con un �nfasis en el desarrollo juvenil y una gran asistencia a sus partidos.",
                    DatosImportantes = "Equipos m�s importantes: Bayern Munich, Borussia Dortmund, RB Leipzig, Bayer Leverkusen. Bayern ha dominado la liga en los �ltimos a�os.",
                    MaximosGoleadores = "Gerd M�ller (365 goles), Klaus Fischer (268 goles).",
                    MaximosAsistentes = "Thomas M�ller (169 asistencias), Franck Rib�ry (121 asistencias)."
                },

                "Ligue 1" => new LigaInfo
                {
                    Nombre = "Ligue 1",
                    Descripcion = "La Ligue 1 es la liga de f�tbol profesional en Francia. Las competiciones internas incluyen la Ligue 1, la Coupe de France y la Troph�e des Champions. Los equipos franceses compiten en la UEFA Champions League y la UEFA Europa League. " +
                        "Los cl�sicos m�s importantes son el 'Le Classique' entre Par�s Saint-Germain (PSG) y Olympique de Marsella, y el 'Derby du Rh�ne' entre Lyon y Saint-�tienne.",
                    Historia = "Fundada en 1932, la Ligue 1 ha sido una de las ligas m�s exitosas en Europa, especialmente despu�s de la llegada de inversores catar�es al PSG en 2011, que ha dominado la liga desde entonces.",
                    DatosImportantes = "Equipos m�s importantes: PSG, Olympique Lyonnais, Olympique de Marsella, AS Monaco. PSG ha ganado la mayor�a de los t�tulos de liga en la �ltima d�cada.",
                    MaximosGoleadores = "Thierry Henry (175 goles), Edinson Cavani (138 goles).",
                    MaximosAsistentes = "Lionel Messi (95 asistencias), Neymar Jr. (58 asistencias)."
                },

                _ => new LigaInfo
                {
                    Nombre = "Desconocida",
                    Descripcion = "Descripci�n no disponible.",
                    Historia = "Historia no disponible.",
                    DatosImportantes = "Datos no disponibles.",
                    MaximosGoleadores = "No disponibles",
                    MaximosAsistentes = "No disponibles"
                }
            };
        }


        private string GetLigaHistoria(string liga)
        {
            return liga switch
            {
                "Premier League" => "Fundada en 1992, la Premier League reemplaz� a la antigua First Division de Inglaterra, transform�ndose en una de las ligas m�s competitivas y medi�ticas del mundo. " +
                    "Adem�s de la liga, existen competiciones internas como la FA Cup y la Carabao Cup. Los equipos m�s destacados han competido en torneos internacionales como la UEFA Champions League y la UEFA Europa League. " +
                    "Los cl�sicos m�s importantes incluyen el 'North West Derby' entre Liverpool y Manchester United, el 'North London Derby' entre Arsenal y Tottenham, y el 'Manchester Derby' entre Manchester City y Manchester United.",

                "Serie A" => "Fundada en 1898, la Serie A es una de las ligas m�s antiguas y prestigiosas del f�tbol mundial. Ha sido hogar de algunos de los clubes m�s grandes de Europa. " +
                    "Las competiciones nacionales incluyen la Serie A, la Coppa Italia y la Supercoppa Italiana. A nivel internacional, los equipos de la Serie A han competido en la UEFA Champions League, la UEFA Europa League y la UEFA Conference League. " +
                    "Los principales cl�sicos incluyen el 'Derby della Madonnina' entre AC Milan e Inter de Mil�n, el 'Derby d'Italia' entre Juventus e Inter, y el 'Derby della Capitale' entre Roma y Lazio.",

                "Bundesliga" => "Fundada en 1963, la Bundesliga ha sido una liga muy exitosa tanto a nivel nacional como internacional. Conocida por su gran competitividad y su enfoque en el desarrollo juvenil, " +
                    "la Bundesliga tambi�n alberga competiciones como la Copa de Alemania (DFB-Pokal). Los equipos de la liga compiten regularmente en la UEFA Champions League y la UEFA Europa League. " +
                    "Los principales cl�sicos de la Bundesliga incluyen el 'Der Klassiker' entre Bayern M�nich y Borussia Dortmund, y el 'Revierderby' entre Schalke 04 y Borussia Dortmund.",

                "Ligue 1" => "Fundada en 1932, la Ligue 1 es una de las ligas m�s importantes de Europa y ha producido una gran cantidad de futbolistas de clase mundial. " +
                    "Las competiciones internas de la liga incluyen la Ligue 1, la Coupe de France y la Troph�e des Champions. Los equipos franceses tambi�n participan en la UEFA Champions League y la UEFA Europa League. " +
                    "Los cl�sicos m�s importantes son el 'Le Classique' entre Par�s Saint-Germain (PSG) y Olympique de Marsella, y el 'Derby du Rh�ne' entre Lyon y Saint-�tienne.",

                _ => "Historia no disponible"
            };
        }






        private string GetLigaDatosImportantes(string liga)
        {
            return liga switch
            {
                "Premier League" => "Equipos m�s importantes: Manchester United, Liverpool, Arsenal, Chelsea. " +
                    "Manchester United ha ganado 3 veces la UEFA Champions League (1968, 1999, 2008), Liverpool 6 veces (1977, 1978, 1981, 1984, 2005, 2019), Arsenal gan� 1 vez la UEFA Cup Winners' Cup (1994) y Chelsea ha ganado 2 veces la Champions League (2012, 2021).",

                "Serie A" => "Equipos m�s importantes: Juventus, Inter de Mil�n, AC Milan. " +
                    "Juventus ha ganado 2 veces la UEFA Champions League (1985, 1996), Inter de Mil�n ha ganado 3 veces (1964, 1965, 2010) y AC Milan ha ganado 7 veces, siendo el segundo club con m�s Champions League (1963, 1969, 1989, 1990, 1994, 2003, 2007).",

                "Bundesliga" => "Equipos m�s importantes: Bayern Munich, Borussia Dortmund. " +
                    "Bayern Munich ha ganado 6 veces la UEFA Champions League (1974, 1975, 1976, 2001, 2010, 2020), Borussia Dortmund ha ganado 1 vez (1997).",

                "Ligue 1" => "Equipos m�s importantes: Paris Saint-Germain, Olympique Lyonnais. " +
                    "Paris Saint-Germain no ha ganado la UEFA Champions League, pero ha sido finalista en 2020. Olympique Lyonnais ha llegado a las semifinales de la Champions League en varias ocasiones, pero no ha ganado el torneo.",

                _ => "Datos no disponibles."
            };
        }





    }


}

