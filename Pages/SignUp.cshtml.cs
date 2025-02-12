using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace WebNutrition.Pages
{
    public class SignUpModel : PageModel
    {
        //Adding connectionString
        //string cadenita = IConfiguration.("DefaultConnection");
        private readonly ILogger<SignUpModel> _logger;

        public SignUpModel(ILogger<SignUpModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }





    }

}