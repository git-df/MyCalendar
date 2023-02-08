using Application.Models;
using Application.Models.GridFilters;
using Application.Responses;
using Application.Services.Interfaces;
using AutoMapper;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CalendarService : ICalendarService
    {
        private readonly IMapper _mapper;
        private readonly IEventRepository _eventRepository;

        public CalendarService(IMapper mapper, IEventRepository eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        public async Task<ServiceResponse<EventCalendarModel>> GetEventsList(CalendarFilter filter, Guid userid, int pageNumber = 1, int pageSize = 10, string orderBy = null, bool orderDesc = false)
        {
            var events = await _eventRepository.GetEventsWithComments(
                userid,
                filter.FromDate,
                filter.ToDate,
                filter.Filter,
                pageNumber,
                pageSize,
                orderBy,
                orderDesc);

            if (events.totalCount == 0)
            {
                return new ServiceResponse<EventCalendarModel>()
                {
                    Success = false,
                    Message = "Brak wyników"
                };
            }

            return new ServiceResponse<EventCalendarModel>()
            {
                Data = new EventCalendarModel()
                {
                    Events = _mapper.Map<List<EventOnListModel>>(events.events),
                    TotalCount = events.totalCount,
                    EventsFrom = ((pageNumber - 1) * pageSize) + 1,
                    EventsTo = (pageNumber * pageSize),
                    TotalPages = (int)Math.Ceiling(events.totalCount / (double)pageSize)
                }
            };
        }
    }
}
