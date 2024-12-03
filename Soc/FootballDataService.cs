using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
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

        // Método para obtener competiciones (ligas) permitidas en el acceso gratuito
        public async Task<List<LigaDto>> ObtenerLigasAsync()
        {
            var url = "https://api.football-data.org/v4/competitions";  // Endpoint de competiciones
            var response = await _httpClient.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<LigasResponse>(response);
            return data.Competitions;
        }

        // Método para obtener los próximos partidos de una liga específica
        public async Task<List<Partido>> ObtenerProximosPartidosAsync(string idLiga)
        {
            var url = $"https://api.football-data.org/v4/competitions/{idLiga}/matches";  // Endpoint de partidos
            var response = await _httpClient.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<PartidosResponse>(response);
            return data.Matches;
        }
    }

    public class LigasResponse
    {
        [JsonProperty("competitions")]
        public List<LigaDto> Competitions { get; set; }
    }

    public class LigaDto
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class PartidosResponse
    {
        [JsonProperty("matches")]
        public List<Partido> Matches { get; set; }
    }

    public class Partido
    {
        [JsonProperty("homeTeam")]
        public Team HomeTeam { get; set; }

        [JsonProperty("awayTeam")]
        public Team AwayTeam { get; set; }

        [JsonProperty("utcDate")]
        public string UtcDate { get; set; }
    }

    public class Team
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("crest")]
        public string CrestUrl { get; set; } // Logo del equipo
    }
}
