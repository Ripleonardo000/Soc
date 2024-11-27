using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Newtonsoft.Json.Linq;

namespace soc
{
    public partial class ProximosPartidos : ContentPage
    {
        private readonly FootballApiService _footballApiService;

        public ProximosPartidos()
        {
            InitializeComponent();
            _footballApiService = new FootballApiService();
            LoadUpcomingMatches();
        }

        private async void LoadUpcomingMatches()
        {
            try
            {
                // El ID del Real Madrid en la API-Football
                string realMadridTeamId = "541";
                var matchesData = await _footballApiService.GetUpcomingMatches(realMadridTeamId);
                var matchesList = ParseMatches(matchesData);

                MatchListView.ItemsSource = matchesList;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }

        private List<Match> ParseMatches(JObject matchesData)
        {
            var matches = new List<Match>();
            foreach (var match in matchesData["response"])
            {
                var fixture = match["fixture"];
                var teams = match["teams"];
                var date = fixture["date"].ToString();
                var homeTeam = teams["home"]["name"].ToString();
                var awayTeam = teams["away"]["name"].ToString();

                matches.Add(new Match
                {
                    MatchInfo = $"{date}: {homeTeam} vs {awayTeam}"
                });
            }
            return matches;
        }
    }

    public class Match
    {
        public string MatchInfo { get; set; }
    }
}
