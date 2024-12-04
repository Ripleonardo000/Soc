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

        public async Task<List<LigaDto>> ObtenerLigasAsync()
        {
            var url = "https://api.football-data.org/v4/competitions";
            var response = await _httpClient.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<LigasResponse>(response);

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

        public async Task<List<Posicion>> ObtenerTablaPosicionesAsync(string idLiga)
        {
            var url = $"https://api.football-data.org/v4/competitions/{idLiga}/standings";
            var response = await _httpClient.GetStringAsync(url);
            var data = JsonConvert.DeserializeObject<PosicionesResponse>(response);
            return data.Standings[0].Table;  
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
        public string CrestUrl { get; set; }
    }

    public class PosicionesResponse
    {
        [JsonProperty("standings")]
        public List<Standing> Standings { get; set; }
    }

    public class Standing
    {
        [JsonProperty("table")]
        public List<Posicion> Table { get; set; }
    }

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

}
