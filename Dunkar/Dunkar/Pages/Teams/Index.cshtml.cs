using Dunkar.Models;
using Dunkar.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dunkar.Pages.Teams
{
    public class IndexModel : PageModel
    {
        private readonly MockDataService _dataService;

        public IndexModel(MockDataService dataService)
        {
            _dataService = dataService;
        }

        public IList<Team> Teams { get; set; } = default!;

        public void OnGet()
        {
            Teams = _dataService.GetTeams().OrderBy(t => t.Nom).ToList();
        }
    }
}
