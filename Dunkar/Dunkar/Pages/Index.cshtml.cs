// Pages/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dunkar.Models;
using Dunkar.Services;

namespace Dunkar.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MockDataService _dataService;

        public IndexModel(MockDataService dataService)
        {
            _dataService = dataService;
        }

        public int TotalTeams { get; set; }
        public int TotalPlayers { get; set; }
        public int GamesPlayed { get; set; }
        public int CurrentSeason { get; set; }
        public List<Player> TopScorers { get; set; } = new();
        public List<Game> UpcomingGames { get; set; } = new();

        public void OnGet()
        {
            var teams = _dataService.GetTeams();
            var players = _dataService.GetPlayers();
            var games = _dataService.GetGames();
            var currentSeason = _dataService.GetCurrentSeason();

            // Statistiques générales
            TotalTeams = teams.Count(t => t.Statut == TeamStatus.Active);
            TotalPlayers = players.Count(p => p.Statut == PlayerStatus.Actif);
            GamesPlayed = games.Count(g => g.EstTermine);
            CurrentSeason = currentSeason.Annee;

            // Top marqueurs
            TopScorers = players
                .Where(p => p.Stats != null && p.Statut == PlayerStatus.Actif)
                .OrderByDescending(p => p.Stats.PointsParMatch)
                .Take(5)
                .ToList();

            // Prochains matchs
            UpcomingGames = games
                .Where(g => !g.EstTermine && g.DateMatch > DateTime.Now)
                .OrderBy(g => g.DateMatch)
                .Take(5)
                .ToList();
        }
    }
}