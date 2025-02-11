using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebNutrition.Pages
{
    public class FoodInventoryModel : PageModel
    {
        private readonly ILogger<FoodInventoryModel> _logger;

        public FoodInventoryModel(ILogger<FoodInventoryModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
