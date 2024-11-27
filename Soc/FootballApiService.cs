using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace soc
{
    public class FootballApiService
    {
        private static readonly string ApiKey = "5ad4e57d5156c4d5b51604c68f3c81e9"; // Reemplaza esto con tu clave API
        private static readonly string BaseUrl = "https://v3.football.api-sports.io/";

        public async Task<JObject> GetUpcomingMatches(string teamId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(BaseUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("x-apisports-key", ApiKey);

                string endpoint = $"fixtures?team={teamId}&next=5";
                HttpResponseMessage response = await client.GetAsync(endpoint);
                response.EnsureSuccessStatusCode();

                var jsonString = await response.Content.ReadAsStringAsync();
                return JObject.Parse(jsonString);
            }
        }
    }
}
