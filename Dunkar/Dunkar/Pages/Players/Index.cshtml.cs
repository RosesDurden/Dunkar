using Dunkar.Models;
using Dunkar.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dunkar.Pages.Players
{
    public class IndexModel : PageModel
    {
        private readonly MockDataService _dataService;

        public IndexModel(MockDataService dataService)
        {
            _dataService = dataService;
        }

        public IList<Player> Players { get; set; } = default!;
        public IList<Team> Teams { get; set; } = default!;

        [BindProperty(SupportsGet = true)]
        public int? FilterTeamId { get; set; }

        [BindProperty(SupportsGet = true)]
        public Position? FilterPosition { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? SearchTerm { get; set; }

        public void OnGet()
        {
            Teams = _dataService.GetTeams().OrderBy(t => t.Nom).ToList();

            var allPlayers = _dataService.GetPlayers().AsQueryable();

            // Appliquer les filtres
            if (FilterTeamId.HasValue)
            {
                allPlayers = allPlayers.Where(p => p.EquipeId == FilterTeamId.Value);
            }

            if (FilterPosition.HasValue)
            {
                allPlayers = allPlayers.Where(p => p.PostePrincipal == FilterPosition.Value);
            }

            if (!string.IsNullOrEmpty(SearchTerm))
            {
                allPlayers = allPlayers.Where(p =>
                    p.Nom.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase) ||
                    p.Prenom.Contains(SearchTerm, StringComparison.OrdinalIgnoreCase));
            }

            Players = allPlayers.OrderBy(p => p.Nom).ToList();
        }
    }
}
