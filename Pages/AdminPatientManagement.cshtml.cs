using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebNutrition.Pages
{
    public class AdminPatientManagementModel : PageModel
    {
        private readonly ILogger<AdminPatientManagementModel> _logger;

        public AdminPatientManagementModel(ILogger<AdminPatientManagementModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
