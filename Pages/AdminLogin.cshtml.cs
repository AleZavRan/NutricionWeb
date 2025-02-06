using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebNutrition.Pages
{
    public class AdminLoginModel : PageModel
    {
        private readonly ILogger<AdminLoginModel> _logger;

        public AdminLoginModel(ILogger<AdminLoginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
