using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebNutrition.Pages
{
    public class RecordsAndStatsModel : PageModel
    {
        private readonly ILogger<RecordsAndStatsModel> _logger;

        public RecordsAndStatsModel(ILogger<RecordsAndStatsModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}