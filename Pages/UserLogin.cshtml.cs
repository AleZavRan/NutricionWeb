using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebNutrition.Pages
{
    public class UserLoginModel : PageModel
    {
        private readonly ILogger<UserLoginModel> _logger;

        public UserLoginModel(ILogger<UserLoginModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}