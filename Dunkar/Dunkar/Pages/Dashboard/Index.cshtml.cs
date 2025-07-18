using Dunkar.Models;
using Dunkar.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dunkar.Pages.Dashboard
{
    public class IndexModel : PageModel
    {
        private readonly MockDataService _dataService;

        public IndexModel(MockDataService dataService)
        {
            _dataService = dataService;
        }

        public Season CurrentSeason { get; set; } = default!;
        public int TotalTeams { get; set; }
        public int TotalPlayers { get; set; }
        public int GamesThisWeek { get; set; }
        public int PlayersInjured { get; set; }
        public List<Team> Standings { get; set; } = default!;
        public List<Game> UpcomingGames { get; set; } = default!;
        public List<Player> TopScorers { get; set; } = default!;
        public List<Player> TopAssisters { get; set; } = default!;
        public List<Player> TopRebounders { get; set; } = default!;

        public void OnGet()
        {
            CurrentSeason = _dataService.GetCurrentSeason();

            var teams = _dataService.GetTeams();
            var players = _dataService.GetPlayers();
            var games = _dataService.GetGames();

            TotalTeams = teams.Count(t => t.Statut == TeamStatus.Active);
            TotalPlayers = players.Count(p => p.Statut == PlayerStatus.Actif);
            PlayersInjured = players.Count(p => p.Statut == PlayerStatus.Blesse);

            var startOfWeek = DateTime.Now.Date.AddDays(-(int)DateTime.Now.DayOfWeek);
            var endOfWeek = startOfWeek.AddDays(7);
            GamesThisWeek = games.Count(g => g.DateMatch >= startOfWeek && g.DateMatch < endOfWeek);

            // Classement par pourcentage de victoires
            Standings = teams
                .Where(t => t.SaisonsEquipe.Any())
                .OrderByDescending(t =>
                {
                    var saison = t.SaisonsEquipe.First();
                    return (double)saison.Victoires / (saison.Victoires + saison.Defaites);
                })
                .ToList();

            UpcomingGames = games
                .Where(g => !g.EstTermine && g.DateMatch > DateTime.Now)
                .OrderBy(g => g.DateMatch)
                .ToList();

            TopScorers = players
                .Where(p => p.Stats != null && p.Statut == PlayerStatus.Actif)
                .OrderByDescending(p => p.Stats.PointsParMatch)
                .ToList();

            TopAssisters = players
                .Where(p => p.Stats != null && p.Statut == PlayerStatus.Actif)
                .OrderByDescending(p => p.Stats.PassesParMatch)
                .ToList();

            TopRebounders = players
                .Where(p => p.Stats != null && p.Statut == PlayerStatus.Actif)
                .OrderByDescending(p => p.Stats.RebondsParMatch)
                .ToList();
        }
    }
}
