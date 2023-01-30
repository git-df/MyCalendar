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
            User newuser = new User()
            {
                Id = Guid.NewGuid(),
                FirstName = "Dawid",
                LastName = "Florian",
                Email = "dawidflorian99@gmail.com",
                Password = "dc",
                Salt = "cs"
            };

            var a = await _authService.Test(newuser);

            return Page();
        }
    }
}