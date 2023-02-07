using Application.Models;
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

        public async Task<ServiceResponse<EventsListModel>> GetEventsList(EventInputModel inputModel)
        {
            var results = await _eventRepository.GetEventsWithComments(
                inputModel.userid,
                inputModel.fromDate,
                inputModel.toDate,
                inputModel.filter,
                inputModel.pageNumber,
                inputModel.pageSize,
                inputModel.sortBy,
                inputModel.sortByDesc);

            return new ServiceResponse<EventsListModel> { 
                Data = new EventsListModel()
                {
                    Events = _mapper.Map<List<EventOnListModel>>(results.events),
                    TotalCount = results.totalCount,
                    EventsFrom = (inputModel.pageSize * inputModel.pageNumber - 1) + 1,
                    EventsTo = inputModel.pageSize * inputModel.pageNumber,
                    TotalPages = (int)Math.Ceiling(results.totalCount/(double)inputModel.pageSize)
                }
            };
        }
    }
}
