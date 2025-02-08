using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebNutrition.Pages
{
    public class AdminFoodManagementModel : PageModel
    {
        private readonly ILogger<AdminFoodManagementModel> _logger;

        public AdminFoodManagementModel(ILogger<AdminFoodManagementModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}