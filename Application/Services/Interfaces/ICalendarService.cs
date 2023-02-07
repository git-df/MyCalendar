using Application.Models;
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
        Task<ServiceResponse<EventsListModel>> GetEventsList(EventInputModel inputModel);
    }
}
