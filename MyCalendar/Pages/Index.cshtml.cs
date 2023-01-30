using Application.Models;
using Application.Services.Interfaces;
using Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyCalendar.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IAuthService _authService;

        public IndexModel(ILogger<IndexModel> logger, IAuthService authService)
        {
            _logger = logger;
            _authService = authService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            UserSignUpModel user = new UserSignUpModel()
            {
                FirstName = "Dawid",
                LastName = "Florian",
                Email = "Cjhwidflorian99@gmail.com",
                Password = "Haslo123!",
                ConfirmPassword = "Haslo123!"
            };

            var a = await _authService.SignIn(new UserSignInModel()
            {
                Email = user.Email,
                Password= user.Password
            });

            return Page();
        }
    }
}