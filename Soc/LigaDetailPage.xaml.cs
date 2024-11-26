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
                "cbbche" => "cbbche es una liga ficticia creada para demostración.",
                "Premier League" => "La Premier League es la liga de fútbol profesional en Inglaterra.",
                "Serie A" => "Serie A es la liga de fútbol profesional en Italia.",
                "Bundesliga" => "La Bundesliga es la liga de fútbol profesional en Alemania.",
                "Ligue 1" => "Ligue 1 es la liga de fútbol profesional en Francia.",
                _ => "Descripción no disponible"
            };
        }

        // Método para obtener la ruta de la imagen de cada liga
        private string GetLigaImagen(string liga)
        {
            return liga switch
            {
                "cbbche" => "cbbche.png",  // Ruta de la imagen dentro de Resources/Images
                "Premier League" => "premier_league.png",
                "Serie A" => "serie_a.png",
                "Bundesliga" => "bundesliga.png",
                "Ligue 1" => "ligue_1.png",
                _ => "default.png"  // Imagen por defecto si no se encuentra la liga
            };
        }

        // Método para obtener la información completa de cada liga
        private LigaInfo GetLigaInfo(string liga)
        {
            return liga switch
            {
                "cbbche" => new LigaInfo
                {
                    Nombre = "cbbche",
                    Descripcion = "cbbche es una liga ficticia creada para demostración.",
                    Historia = "Fundada en 2023, cbbche es conocida por su enfoque en el desarrollo de nuevos talentos.",
                    DatosImportantes = "Equipos más importantes: CBB United, Club CBBChe FC.",
                    MaximosGoleadores = "Jugador 1 (100 goles), Jugador 2 (80 goles).",
                    MaximosAsistentes = "Jugador 3 (50 asistencias), Jugador 4 (40 asistencias)."
                },



                "Premier League" => new LigaInfo
                {
                    Nombre = "Premier League",
                    Descripcion = "La Premier League es la liga de fútbol profesional en Inglaterra.",
                    Historia = "Fundada en 1992, la Premier League reemplazó a la antigua First Division de Inglaterra.",
                    DatosImportantes = "Equipos más importantes: Manchester United, Liverpool, Arsenal, Chelsea.",
                    MaximosGoleadores = "Alan Shearer (260 goles), Wayne Rooney (208 goles).",
                    MaximosAsistentes = "Ryan Giggs (162 asistencias), Frank Lampard (102 asistencias)."
                },


                "Serie A" => new LigaInfo
                {
                    Nombre = "Serie A",
                    Descripcion = "La Serie A es la liga de fútbol profesional en Italia.",
                    Historia = "Fundada en 1898, la Serie A ha sido hogar de algunos de los clubes más grandes de Europa.",
                    DatosImportantes = "Equipos más importantes: Juventus, AC Milan, Inter de Milán.",
                    MaximosGoleadores = "Silvio Piola (274 goles), Francesco Totti (250 goles).",
                    MaximosAsistentes = "Francesco Totti (199 asistencias), Giuseppe Meazza (151 asistencias)."
                },




                "Bundesliga" => new LigaInfo
                {
                    Nombre = "Bundesliga",
                    Descripcion = "La Bundesliga es la liga de fútbol profesional en Alemania.",
                    Historia = "Fundada en 1963, la Bundesliga es conocida por su gran competitividad y su gran apoyo al desarrollo de jóvenes talentos.",
                    DatosImportantes = "Equipos más importantes: Bayern Munich, Borussia Dortmund, RB Leipzig.",
                    MaximosGoleadores = "Gerd Müller (365 goles), Klaus Fischer (268 goles).",
                    MaximosAsistentes = "Thomas Müller (169 asistencias), Franck Ribéry (121 asistencias)."
                },




                "Ligue 1" => new LigaInfo
                {
                    Nombre = "Ligue 1",
                    Descripcion = "La Ligue 1 es la liga de fútbol profesional en Francia.",
                    Historia = "Fundada en 1932, la Ligue 1 es la liga más importante de fútbol en Francia.",
                    DatosImportantes = "Equipos más importantes: PSG, Olympique Lyonnais, Olympique de Marsella.",
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
                "cbbche" => "Fundada en 2023, cbbche es conocida por su enfoque en el desarrollo de nuevos talentos.",
                "Premier League" => "Fundada en 1992, la Premier League reemplazó a la antigua First Division de Inglaterra.",
                "Serie A" => "Fundada en 1898, la Serie A es una de las ligas más antiguas y prestigiosas del fútbol mundial.",
                "Bundesliga" => "Fundada en 1963, la Bundesliga ha sido una liga muy exitosa tanto a nivel nacional como internacional.",
                "Ligue 1" => "Fundada en 1932, la Ligue 1 es conocida por su calidad y por ser la liga que ha producido a muchos futbolistas de clase mundial.",
                _ => "Historia no disponible"
            };
        }





        private string GetLigaDatosImportantes(string liga)
        {
            return liga switch
            {
                "cbbche" => "Equipos más importantes: CBB United, Club CBBChe FC.",
                "Premier League" => "Equipos más importantes: Manchester United, Liverpool, Arsenal, Chelsea.",
                "Serie A" => "Equipos más importantes: Juventus, Inter de Milán, AC Milan.",
                "Bundesliga" => "Equipos más importantes: Bayern Munich, Borussia Dortmund.",
                "Ligue 1" => "Equipos más importantes: Paris Saint-Germain, Olympique Lyonnais.",
                _ => "Datos no disponibles."
            };
        }





    }

   
}

