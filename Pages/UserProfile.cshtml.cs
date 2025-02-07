using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebNutrition.Pages
{
    public class UserProfileModel : PageModel
    {
        private readonly ILogger<UserProfileModel> _logger;

        public UserProfileModel(ILogger<UserProfileModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}