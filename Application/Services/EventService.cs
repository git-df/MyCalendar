using Application.Models;
using Application.Responses;
using Application.Services.Interfaces;
using AutoMapper;
using Microsoft.Extensions.Logging;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _eventRepository;
        private readonly IAccesRequestRepository _accesRequestRepository;
        private readonly IMapper _mapper;

        public EventService(IEventRepository eventRepository, IAccesRequestRepository accesRequestRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _accesRequestRepository = accesRequestRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<EventDetailsModel>> GetEventDetail(Guid userId, int eventId)
        {
            var eventFromBase = await _eventRepository.GetEventById(eventId);

            if (eventFromBase == null)
            {
                return new ServiceResponse<EventDetailsModel>()
                {
                    Success = false,
                    Message = "Nie znaleziono wydarzenia o takim id"
                };
            }

            var eventModel = _mapper.Map<EventDetailsModel>(eventFromBase);

            if (eventFromBase.UserId == userId)
            {
                eventModel.Editable = true;

                return new ServiceResponse<EventDetailsModel>()
                {
                    Data = eventModel
                };
            }

            var accesRequest = await _accesRequestRepository.CheckAcces(userId, eventFromBase.UserId);

            if (accesRequest == null)
            {
                return new ServiceResponse<EventDetailsModel>()
                {
                    Success = false,
                    Message = "Nie masz dostępu do tego wydarzenia"
                };
            }

            return new ServiceResponse<EventDetailsModel>()
            {
                Data = eventModel
            };
        }

        public async Task<ServiceResponse<EventDetailsModel>> UpdateEvent(Guid userId, EventDetailsModel eventDetails)
        {
            var eventFromBase = await _eventRepository.GetEventById(eventDetails.Id);

            if (eventFromBase == null)
            {
                return new ServiceResponse<EventDetailsModel>()
                {
                    Success = false,
                    Message = "Nie znaleziono wydarzenia o takim id"
                };
            }

            if (eventFromBase.UserId == userId)
            {
                eventFromBase.Title = eventDetails.Title;
                eventFromBase.Label = eventDetails.Label;
                eventFromBase.Description = eventDetails.Description;
                eventFromBase.EventDate = eventDetails.EventDate;
                eventFromBase.EndEventDate = eventDetails.EndEventDate;

                await _eventRepository.EditEvent(eventFromBase);

                return new ServiceResponse<EventDetailsModel>()
                {
                    Data = eventDetails
                };
            }


            return new ServiceResponse<EventDetailsModel>()
            {
                Success = false,
                Message = "Nie masz dostępu do tego wydarzenia"
            };
        }
    }
}
