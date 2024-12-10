namespace soc
{
    public partial class LigaDetailPage : ContentPage
    {
        public string LigaNombre { get; set; }
        public string LigaDescripcion { get; set; }
        public string LigaImagen { get; set; }  // Nueva propiedad para la imagen

        public string LigaHistoria { get; set; }
        public string LigaDatosImportantes { get; set; }

        public string MaximosGoleadores { get; set; }  // Nueva propiedad para los máximos goleadores
        public string MaximosAsistentes { get; set; }  // Nueva propiedad para los máximos asistentes



        public LigaDetailPage(string liga)
        {
            InitializeComponent();

            // Asignar la liga seleccionada y su descripción
            LigaNombre = liga;
            LigaDescripcion = GetLigaDescripcion(liga);  // Aquí obtenemos solo la descripción
            LigaImagen = GetLigaImagen(liga);  // Asignar la ruta de la imagen

            var ligaInfo = GetLigaInfo(liga);  // Aquí obtenemos la información completa de la liga

            // Asignar las propiedades Historia y DatosImportantes
            LigaHistoria = GetLigaHistoria(liga);
            LigaDatosImportantes = GetLigaDatosImportantes(liga);


            MaximosGoleadores = ligaInfo.MaximosGoleadores;
            MaximosAsistentes = ligaInfo.MaximosAsistentes;


            // Configurar el BindingContext
            BindingContext = this;
        }

        // Método para obtener la descripción de cada liga
        private string GetLigaDescripcion(string liga)
        {
            return liga switch
            {
                "Premier League" => "La Premier League es la liga de fútbol profesional más importante de Inglaterra, considerada una de las competiciones más competitivas y atractivas del mundo. Fundada en 1992, reemplazó a la Football League First Division como la máxima categoría del fútbol inglés. La liga cuenta con 20 equipos y se caracteriza por su estilo de juego rápido, físico y por el nivel internacional de sus jugadores y entrenadores. Equipos históricos como el Manchester United, Liverpool, Arsenal, Chelsea y Manchester City han dominado la liga, que atrae a millones de espectadores globalmente.",

                "Serie A" => "Serie A es la liga de fútbol profesional de más alto nivel en Italia, una de las competiciones más antiguas y prestigiosas del mundo. Se fundó en 1898 y ha sido cuna de grandes equipos como la Juventus, Inter de Milán, AC Milan y Roma. A lo largo de su historia, la Serie A ha sido conocida por su sólido enfoque defensivo y táctico, siendo una de las ligas más formativas para jugadores y entrenadores. Además, Italia ha sido sede de numerosos títulos internacionales, incluidas varias Copas del Mundo, lo que resalta el nivel de su liga. La Serie A sigue siendo una de las ligas más seguidas a nivel mundial.",

                "Bundesliga" => "La Bundesliga es la liga de fútbol profesional en Alemania, fundada en 1963. Reconocida por su ambiente vibrante, estadios modernos y una sólida infraestructura futbolística, la Bundesliga ha producido algunos de los equipos más exitosos de Europa, como el Bayern de Múnich y el Borussia Dortmund. Es conocida por su estilo de juego dinámico y rápido, con un énfasis en el desarrollo juvenil y una fuerte estructura de clubes, muchos de los cuales están gestionados como sociedades deportivas de base. La liga también es famosa por su equilibrio competitivo y por la gran asistencia de aficionados a los estadios.",

                "Ligue 1" => "Ligue 1 es la máxima categoría del fútbol profesional en Francia, fundada en 1932. Es conocida por ser la liga donde han brillado algunos de los mejores jugadores del mundo, como Zinedine Zidane, Thierry Henry, y actualmente Kylian Mbappé. Ligue 1 es una liga que históricamente ha estado dominada por el Paris Saint-Germain, especialmente después de su adquisición por inversores cataríes en 2011, lo que ha traído consigo un fuerte ascenso del club en Europa. Además, la liga francesa ha sido una cantera importante para jóvenes talentos que luego se destacan en grandes competiciones internacionales.",

                _ => "Descripción no disponible"
            };
        }


        // Método para obtener la ruta de la imagen de cada liga
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
                    Descripcion = "La Premier League es la liga de fútbol profesional en Inglaterra. Además de la liga, existen competiciones como la FA Cup y la Carabao Cup, que enfrentan a equipos de distintas divisiones. Los equipos más destacados de la Premier League también compiten en torneos internacionales como la UEFA Champions League y la UEFA Europa League. " +
                        "Los clásicos más importantes son el 'North West Derby' entre Liverpool y Manchester United, el 'North London Derby' entre Arsenal y Tottenham, y el 'Manchester Derby' entre Manchester City y Manchester United.",
                    Historia = "Fundada en 1992, la Premier League reemplazó a la antigua First Division de Inglaterra, transformándose en una de las ligas más competitivas y mediáticas del mundo.",
                    DatosImportantes = "Equipos más importantes: Manchester United, Liverpool, Arsenal, Chelsea, Manchester City. Equipos recientes en dominar: Manchester City, Liverpool.",
                    MaximosGoleadores = "Alan Shearer (260 goles), Wayne Rooney (208 goles).",
                    MaximosAsistentes = "Ryan Giggs (162 asistencias), Frank Lampard (102 asistencias)."
                },

                "Serie A" => new LigaInfo
                {
                    Nombre = "Serie A",
                    Descripcion = "La Serie A es la liga de fútbol profesional en Italia. Las competiciones nacionales incluyen la Serie A, la Coppa Italia y la Supercoppa Italiana. A nivel internacional, los equipos de la Serie A compiten en la UEFA Champions League, la UEFA Europa League y la UEFA Conference League. " +
                        "Los clásicos más destacados incluyen el 'Derby della Madonnina' entre el AC Milan e Inter de Milán, el 'Derby d'Italia' entre Juventus y el Inter de Milán, y el 'Derby della Capitale' entre Roma y Lazio.",
                    Historia = "Fundada en 1898, la Serie A ha sido hogar de algunos de los clubes más grandes y exitosos de Europa, especialmente en la década de 1980 y 1990, cuando equipos como Juventus, AC Milan e Inter dominaron tanto a nivel nacional como europeo.",
                    DatosImportantes = "Equipos más importantes: Juventus, AC Milan, Inter de Milán, Roma, Napoli. La liga ha sido dominada históricamente por Juventus en los últimos años.",
                    MaximosGoleadores = "Silvio Piola (274 goles), Francesco Totti (250 goles).",
                    MaximosAsistentes = "Francesco Totti (199 asistencias), Giuseppe Meazza (151 asistencias)."
                },

                "Bundesliga" => new LigaInfo
                {
                    Nombre = "Bundesliga",
                    Descripcion = "La Bundesliga es la liga de fútbol profesional en Alemania. Además de la liga, la Copa de Alemania (DFB-Pokal) es la principal competencia interna. Los equipos de la Bundesliga también compiten en la UEFA Champions League y la UEFA Europa League. " +
                        "Los principales clásicos son el 'Der Klassiker' entre Bayern Múnich y Borussia Dortmund, y el 'Revierderby' entre Schalke 04 y Borussia Dortmund.",
                    Historia = "Fundada en 1963, la Bundesliga ha crecido hasta convertirse en una de las ligas más poderosas de Europa, con un énfasis en el desarrollo juvenil y una gran asistencia a sus partidos.",
                    DatosImportantes = "Equipos más importantes: Bayern Munich, Borussia Dortmund, RB Leipzig, Bayer Leverkusen. Bayern ha dominado la liga en los últimos años.",
                    MaximosGoleadores = "Gerd Müller (365 goles), Klaus Fischer (268 goles).",
                    MaximosAsistentes = "Thomas Müller (169 asistencias), Franck Ribéry (121 asistencias)."
                },

                "Ligue 1" => new LigaInfo
                {
                    Nombre = "Ligue 1",
                    Descripcion = "La Ligue 1 es la liga de fútbol profesional en Francia. Las competiciones internas incluyen la Ligue 1, la Coupe de France y la Trophée des Champions. Los equipos franceses compiten en la UEFA Champions League y la UEFA Europa League. " +
                        "Los clásicos más importantes son el 'Le Classique' entre París Saint-Germain (PSG) y Olympique de Marsella, y el 'Derby du Rhône' entre Lyon y Saint-Étienne.",
                    Historia = "Fundada en 1932, la Ligue 1 ha sido una de las ligas más exitosas en Europa, especialmente después de la llegada de inversores cataríes al PSG en 2011, que ha dominado la liga desde entonces.",
                    DatosImportantes = "Equipos más importantes: PSG, Olympique Lyonnais, Olympique de Marsella, AS Monaco. PSG ha ganado la mayoría de los títulos de liga en la última década.",
                    MaximosGoleadores = "Thierry Henry (175 goles), Edinson Cavani (138 goles).",
                    MaximosAsistentes = "Lionel Messi (95 asistencias), Neymar Jr. (58 asistencias)."
                },

                _ => new LigaInfo
                {
                    Nombre = "Desconocida",
                    Descripcion = "Descripción no disponible.",
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
                "Premier League" => "Fundada en 1992, la Premier League reemplazó a la antigua First Division de Inglaterra, transformándose en una de las ligas más competitivas y mediáticas del mundo. " +
                    "Además de la liga, existen competiciones internas como la FA Cup y la Carabao Cup. Los equipos más destacados han competido en torneos internacionales como la UEFA Champions League y la UEFA Europa League. " +
                    "Los clásicos más importantes incluyen el 'North West Derby' entre Liverpool y Manchester United, el 'North London Derby' entre Arsenal y Tottenham, y el 'Manchester Derby' entre Manchester City y Manchester United.",

                "Serie A" => "Fundada en 1898, la Serie A es una de las ligas más antiguas y prestigiosas del fútbol mundial. Ha sido hogar de algunos de los clubes más grandes de Europa. " +
                    "Las competiciones nacionales incluyen la Serie A, la Coppa Italia y la Supercoppa Italiana. A nivel internacional, los equipos de la Serie A han competido en la UEFA Champions League, la UEFA Europa League y la UEFA Conference League. " +
                    "Los principales clásicos incluyen el 'Derby della Madonnina' entre AC Milan e Inter de Milán, el 'Derby d'Italia' entre Juventus e Inter, y el 'Derby della Capitale' entre Roma y Lazio.",

                "Bundesliga" => "Fundada en 1963, la Bundesliga ha sido una liga muy exitosa tanto a nivel nacional como internacional. Conocida por su gran competitividad y su enfoque en el desarrollo juvenil, " +
                    "la Bundesliga también alberga competiciones como la Copa de Alemania (DFB-Pokal). Los equipos de la liga compiten regularmente en la UEFA Champions League y la UEFA Europa League. " +
                    "Los principales clásicos de la Bundesliga incluyen el 'Der Klassiker' entre Bayern Múnich y Borussia Dortmund, y el 'Revierderby' entre Schalke 04 y Borussia Dortmund.",

                "Ligue 1" => "Fundada en 1932, la Ligue 1 es una de las ligas más importantes de Europa y ha producido una gran cantidad de futbolistas de clase mundial. " +
                    "Las competiciones internas de la liga incluyen la Ligue 1, la Coupe de France y la Trophée des Champions. Los equipos franceses también participan en la UEFA Champions League y la UEFA Europa League. " +
                    "Los clásicos más importantes son el 'Le Classique' entre París Saint-Germain (PSG) y Olympique de Marsella, y el 'Derby du Rhône' entre Lyon y Saint-Étienne.",

                _ => "Historia no disponible"
            };
        }






        private string GetLigaDatosImportantes(string liga)
        {
            return liga switch
            {
                "Premier League" => "Equipos más importantes: Manchester United, Liverpool, Arsenal, Chelsea. " +
                    "Manchester United ha ganado 3 veces la UEFA Champions League (1968, 1999, 2008), Liverpool 6 veces (1977, 1978, 1981, 1984, 2005, 2019), Arsenal ganó 1 vez la UEFA Cup Winners' Cup (1994) y Chelsea ha ganado 2 veces la Champions League (2012, 2021).",

                "Serie A" => "Equipos más importantes: Juventus, Inter de Milán, AC Milan. " +
                    "Juventus ha ganado 2 veces la UEFA Champions League (1985, 1996), Inter de Milán ha ganado 3 veces (1964, 1965, 2010) y AC Milan ha ganado 7 veces, siendo el segundo club con más Champions League (1963, 1969, 1989, 1990, 1994, 2003, 2007).",

                "Bundesliga" => "Equipos más importantes: Bayern Munich, Borussia Dortmund. " +
                    "Bayern Munich ha ganado 6 veces la UEFA Champions League (1974, 1975, 1976, 2001, 2010, 2020), Borussia Dortmund ha ganado 1 vez (1997).",

                "Ligue 1" => "Equipos más importantes: Paris Saint-Germain, Olympique Lyonnais. " +
                    "Paris Saint-Germain no ha ganado la UEFA Champions League, pero ha sido finalista en 2020. Olympique Lyonnais ha llegado a las semifinales de la Champions League en varias ocasiones, pero no ha ganado el torneo.",

                _ => "Datos no disponibles."
            };
        }





    }


}

