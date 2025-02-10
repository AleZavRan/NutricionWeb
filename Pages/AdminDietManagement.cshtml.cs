using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebNutrition.Pages
{
    public class AdminDietManagementModel : PageModel
    {
        private readonly ILogger<AdminDietManagementModel> _logger;

        public AdminDietManagementModel(ILogger<AdminDietManagementModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}