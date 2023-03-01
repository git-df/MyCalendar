using Application.Test.Mocks.Data;
using Domain.Entity;
using Moq;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Test.Mocks
{
    public class EventRepositoryMock
    {
        public static Mock<IEventRepository> GetEventRepository()
        {
            var events = ContextMock.GetEvents();

            var mockEventRepository = new Mock<IEventRepository>();

            mockEventRepository.Setup(repo => repo.GetEventById(It.IsAny<int>())).ReturnsAsync(
                (int id) =>
                {
                    return events.FirstOrDefault(e => e.Id == id);
                });

            mockEventRepository.Setup(repo => repo.AddEvent(It.IsAny<Domain.Entity.Event>())).ReturnsAsync(
                (Domain.Entity.Event addedEvent) => 
                {
                    events.Add(addedEvent);
                    return addedEvent;
                });

            mockEventRepository.Setup(repo => repo.EditEvent(It.IsAny<Domain.Entity.Event>())).ReturnsAsync(
                (Domain.Entity.Event updatedEvent) =>
                {
                    events.Remove(updatedEvent);
                    events.Add(updatedEvent);
                    return updatedEvent;
                });

            return mockEventRepository;
        }
    }
}