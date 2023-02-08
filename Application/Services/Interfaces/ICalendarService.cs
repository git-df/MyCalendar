using Application.Models;
using Application.Models.GridFilters;
using Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.Interfaces
{
    public interface ICalendarService
    {
        Task<ServiceResponse<EventCalendarModel>> GetEventsList(CalendarFilter filter, Guid userid, int pageNumber, int pageSize, string orderBy, bool orderDesc);
    }
}
