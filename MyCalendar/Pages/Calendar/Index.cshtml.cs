using Application.Models;
using Application.Models.GridFilters;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace MyCalendar.Pages.Calendar
{
    [Authorize(Policy = "User")]
    public class IndexModel : PageModel
    {
        private readonly ICalendarService _calendarService;

        public IndexModel(ICalendarService calendarService)
        {
            _calendarService = calendarService;
        }

        [BindProperty]
        public CalendarFilter Filter { get; set; }

        [BindProperty]
        public EventCalendarModel CalendarModel { get; set; }

        public async Task<IActionResult> OnGetAsync(int page = 1, int size = 10, string orderBy = null, bool orderDesc = false)
        {

            Filter = Filter != null ? Filter : new CalendarFilter();

            var response = await _calendarService
                .GetEventsList(Filter, Guid.Parse(User.FindFirstValue("Id")), page, size, orderBy, orderDesc);

            if (!response.Success)
            {
                ViewData["Message"] = response.Message;
                return Page();
            }

            CalendarModel = response.Data;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int page = 1, int size = 10, string orderBy = null, bool orderDesc = false)
        {
            var response = await _calendarService
                .GetEventsList(Filter, Guid.Parse(User.FindFirstValue("Id")), page, size, orderBy, orderDesc);

            if (!response.Success)
            {
                ViewData["Message"] = response.Message;
                return Page();
            }

            CalendarModel = response.Data;
            return Page();
        }
    }
}
