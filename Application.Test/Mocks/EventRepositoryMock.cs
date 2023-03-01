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
            var events = GetEvents();

            var mockEventRepository = new Mock<IEventRepository>();

            mockEventRepository.Setup(repo => repo.GetEventById(It.IsAny<int>())).ReturnsAsync(
                (int id) =>
                {
                    return events.FirstOrDefault(e => e.Id == id);
                });




            return mockEventRepository;
        }

        public static List<Domain.Entity.Event> GetEvents()
        {
            var users = UserRepositoryMock.GetUsers();

            return new List<Domain.Entity.Event>()
            {
                new Domain.Entity.Event()
                {
                    Id = 1,
                    Title = "Test1",
                    Description = "Test1Desc",
                    Label = "Test1Label",
                    EventDate = DateTime.Now.AddDays(5),
                    EndEventDate = DateTime.Now.AddDays(5).AddHours(1),
                    UserId = users[0].Id
                },
                new Domain.Entity.Event()
                {
                    Id = 2,
                    Title = "Test2",
                    Description = "Test2Desc",
                    Label = "Test2Label",
                    EventDate = DateTime.Now.AddDays(10),
                    EndEventDate = DateTime.Now.AddDays(10).AddHours(2),
                    UserId = users[0].Id
                },
                new Domain.Entity.Event()
                {
                    Id = 3,
                    Title = "Test3",
                    Description = "Test3Desc",
                    Label = "Test3Label",
                    EventDate = DateTime.Now.AddDays(15),
                    EndEventDate = DateTime.Now.AddDays(15).AddHours(3),
                    UserId = users[0].Id
                },
                new Domain.Entity.Event()
                {
                    Id = 4,
                    Title = "Test4",
                    Description = "Test4Desc",
                    Label = "Test4Label",
                    EventDate = DateTime.Now.AddDays(6),
                    EndEventDate = DateTime.Now.AddDays(6).AddHours(1),
                    UserId = users[1].Id
                },
                new Domain.Entity.Event()
                {
                    Id = 5,
                    Title = "Test5",
                    Description = "Test5Desc",
                    Label = "Test5Label",
                    EventDate = DateTime.Now.AddDays(11),
                    EndEventDate = DateTime.Now.AddDays(11).AddHours(2),
                    UserId = users[1].Id
                },
                new Domain.Entity.Event()
                {
                    Id = 6,
                    Title = "Test6",
                    Description = "Test6Desc",
                    Label = "Test6Label",
                    EventDate = DateTime.Now.AddDays(16),
                    EndEventDate = DateTime.Now.AddDays(16).AddHours(3),
                    UserId = users[1].Id
                },
                new Domain.Entity.Event()
                {
                    Id = 7,
                    Title = "Test7",
                    Description = "Test7Desc",
                    Label = "Test7Label",
                    EventDate = DateTime.Now.AddDays(7),
                    EndEventDate = DateTime.Now.AddDays(7).AddHours(1),
                    UserId = users[2].Id
                },
                new Domain.Entity.Event()
                {
                    Id = 8,
                    Title = "Test8",
                    Description = "Test8Desc",
                    Label = "Test8Label",
                    EventDate = DateTime.Now.AddDays(12),
                    EndEventDate = DateTime.Now.AddDays(12).AddHours(2),
                    UserId = users[2].Id
                },
                new Domain.Entity.Event()
                {
                    Id = 9,
                    Title = "Test9",
                    Description = "Test9Desc",
                    Label = "Test9Label",
                    EventDate = DateTime.Now.AddDays(17),
                    EndEventDate = DateTime.Now.AddDays(17).AddHours(3),
                    UserId = users[2].Id
                },
            };
        }
    }
}
