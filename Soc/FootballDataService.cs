using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace soc.Services
{
    public class FootballDataService
    {
        private readonly HttpClient _httpClient;

        public FootballDataService()
        {
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("X-Auth-Token", "0b1a20c3291c4d42a69e1fd30175adca");
        }

        // Obtener las ligas disponibles
        public async Task<List<LigaDto>> ObtenerLigasAsync()
        {
            var url = "https://api.football-data.org/v4/competitions";
            var response = await _httpClient.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<LigasResponse>(response);

            // Modificar el nombre de algunas ligas (si es necesario)
            foreach (var liga in data.Competitions)
            {
                switch (liga.Id)
                {
                    case "2014":
                        liga.Name = "Liga Española";
                        break;
                    default:
                        break;
                }
            }

            return data.Competitions;
        }

        // Obtener los próximos partidos de una liga
        public async Task<List<Partido>> ObtenerProximosPartidosAsync(string idLiga)
        {
            var url = $"https://api.football-data.org/v4/competitions/{idLiga}/matches";
            var response = await _httpClient.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<PartidosResponse>(response);

            var partidosFuturos = new List<Partido>();
            foreach (var partido in data.Matches)
            {
                if (DateTime.TryParse(partido.UtcDate, out DateTime fechaPartido))
                {
                    if (fechaPartido > DateTime.UtcNow)
                    {
                        partidosFuturos.Add(partido);
                    }
                }
            }

            return partidosFuturos;
        }

        // Obtener la tabla de posiciones de una liga
        public async Task<List<Posicion>> ObtenerTablaPosicionesAsync(string idLiga)
        {
            var url = $"https://api.football-data.org/v4/competitions/{idLiga}/standings";
            var response = await _httpClient.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<PosicionesResponse>(response);
            return data.Standings[0].Table;
        }

        // Obtener los goleadores de una liga
        public async Task<List<Goleador>> ObtenerGoleadoresAsync(string idLiga)
        {
            var url = $"https://api.football-data.org/v4/competitions/{idLiga}/scorers";
            var response = await _httpClient.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<GoleadoresResponse>(response);

            // Verifica si los goleadores tienen posiciones y goles
            foreach (var goleador in data.Scorrers)
            {
                if (goleador.Position == 0)
                {
                    goleador.Position = data.Scorrers.IndexOf(goleador) + 1;
                }
            }

            return data.Scorrers;
        }
    }

    // Respuesta para obtener las ligas
    public class LigasResponse
    {
        [JsonProperty("competitions")]
        public List<LigaDto> Competitions { get; set; }
    }

    // Modelo de liga
    public class LigaDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    // Respuesta para obtener los partidos
    public class PartidosResponse
    {
        [JsonProperty("matches")]
        public List<Partido> Matches { get; set; }
    }

    // Modelo de partido
    public class Partido
    {
        [JsonProperty("homeTeam")]
        public Team HomeTeam { get; set; }

        [JsonProperty("awayTeam")]
        public Team AwayTeam { get; set; }

        [JsonProperty("utcDate")]
        public string UtcDate { get; set; }
    }

    // Modelo de equipo
    public class Team
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("crest")]
        public string CrestUrl { get; set; }  // Aquí debe ir la URL del logo
    }

    // Respuesta para obtener la tabla de posiciones
    public class PosicionesResponse
    {
        [JsonProperty("standings")]
        public List<Standing> Standings { get; set; }
    }

    // Modelo de tabla de posiciones
    public class Standing
    {
        [JsonProperty("table")]
        public List<Posicion> Table { get; set; }
    }

    // Modelo de posición en la tabla
    public class Posicion
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("points")]
        public int Points { get; set; }

        [JsonProperty("playedGames")]
        public int PlayedGames { get; set; }

        [JsonProperty("goalDifference")]
        public int GoalDifference { get; set; }

        [JsonProperty("goalsFor")]
        public int GoalsFor { get; set; }
    }

    // Respuesta para obtener los goleadores
    public class GoleadoresResponse
    {
        [JsonProperty("scorers")]
        public List<Goleador> Scorrers { get; set; }
    }

    // Modelo de goleador
    public class Goleador
    {
        [JsonProperty("position")]
        public int Position { get; set; }

        [JsonProperty("player")]
        public Player Player { get; set; }

        [JsonProperty("goals")]
        public int Goals { get; set; }
    }

    // Modelo de jugador
    public class Player
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
