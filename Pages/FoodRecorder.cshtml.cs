using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebNutrition.Pages
{
    public class FoodRecorderModel : PageModel
    {
        private readonly ILogger<FoodRecorderModel> _logger;

        public FoodRecorderModel(ILogger<FoodRecorderModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
