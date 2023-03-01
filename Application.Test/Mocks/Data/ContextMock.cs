using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Test.Mocks.Data
{
    public class ContextMock
    {
        public static List<Domain.Entity.User> GetUsers()
        {
            var events = GetEvents();
            var accesRequests = GetAccesRequests();
            var comments = GetComments();

            return new List<Domain.Entity.User>()
            {
                new Domain.Entity.User()
                {
                    Id = Guid.Parse("fb8e707d-9a9d-40f6-9819-968add26204e"),
                    Email = "test1@test.test",
                    FirstName = "test1first",
                    LastName = "test1last",
                    Password = "631502BC927D8265FAACD1D32299BBCA705BEBF1FD79250E054F77398F5C6B54",
                    Salt = "49DF6A0F9C34A50A9178470E0CE3E1EB841C5F3BEEE2C18B36E77F702CC57A2A",
                    Events = events.Where(e => e.UserId == Guid.Parse("fb8e707d-9a9d-40f6-9819-968add26204e")).ToList(),
                    Comments = comments.Where(e => e.UserId == Guid.Parse("fb8e707d-9a9d-40f6-9819-968add26204e")).ToList(),
                    accesRequestsFromUser = accesRequests.Where(e => e.FromUserId == Guid.Parse("fb8e707d-9a9d-40f6-9819-968add26204e")).ToList(),
                    accesRequestsToUser = accesRequests.Where(e => e.ToUserId == Guid.Parse("fb8e707d-9a9d-40f6-9819-968add26204e")).ToList()
                },
                new Domain.Entity.User()
                {
                    Id = Guid.Parse("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf"),
                    Email = "test2@test.test",
                    FirstName = "test2first",
                    LastName = "test2last",
                    Password = "D22D6E8BCCCD20674DC25D98AA2DAEDCE9BD1D88F7ED6BA16DFFCBB9F0944606",
                    Salt = "B3F4EF86908A730D7243DF0752A1A3A405B1BDDC8B2AE54CEA1F16550F433576",
                    Events = events.Where(e => e.UserId == Guid.Parse("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf")).ToList(),
                    Comments = comments.Where(e => e.UserId == Guid.Parse("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf")).ToList(),
                    accesRequestsFromUser = accesRequests.Where(e => e.FromUserId == Guid.Parse("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf")).ToList(),
                    accesRequestsToUser = accesRequests.Where(e => e.ToUserId == Guid.Parse("9ce89f11-4d8b-4d78-98ee-4ef4640dfadf")).ToList()
                },
                new Domain.Entity.User()
                {
                    Id = Guid.Parse("3715e326-6e29-43d7-bb77-af4440508186"),
                    Email = "test3@test.test",
                    FirstName = "test3first",
                    LastName = "test3last",
                    Password = "EF44C1BAE114AECB845C356DCBC23AA510518214487BE43CECD658F100CF4FA4",
                    Salt = "315419C3F8AB3B7C21A55D9E573DC0F7B40CCF0174CB8874CDC40CF78F7F7E9D",
                    Events = events.Where(e => e.UserId == Guid.Parse("3715e326-6e29-43d7-bb77-af4440508186")).ToList(),
                    Comments = comments.Where(e => e.UserId == Guid.Parse("3715e326-6e29-43d7-bb77-af4440508186")).ToList(),
                    accesRequestsFromUser = accesRequests.Where(e => e.FromUserId == Guid.Parse("3715e326-6e29-43d7-bb77-af4440508186")).ToList(),
                    accesRequestsToUser = accesRequests.Where(e => e.ToUserId == Guid.Parse("3715e326-6e29-43d7-bb77-af4440508186")).ToList()
                }
            };
        }

        public static List<Domain.Entity.Event> GetEvents()
        {
            var users = GetUsers();
            var comments = GetComments();

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
                    UserId = users[0].Id,
                    User = users[0],
                    Comments = comments.Where(c => c.EventId == 1).ToList()
                },
                new Domain.Entity.Event()
                {
                    Id = 2,
                    Title = "Test2",
                    Description = "Test2Desc",
                    Label = "Test2Label",
                    EventDate = DateTime.Now.AddDays(10),
                    EndEventDate = DateTime.Now.AddDays(10).AddHours(2),
                    UserId = users[0].Id,
                    User = users[0],
                    Comments = comments.Where(c => c.EventId == 2).ToList()
                },
                new Domain.Entity.Event()
                {
                    Id = 3,
                    Title = "Test3",
                    Description = "Test3Desc",
                    Label = "Test3Label",
                    EventDate = DateTime.Now.AddDays(15),
                    EndEventDate = DateTime.Now.AddDays(15).AddHours(3),
                    UserId = users[0].Id,
                    User = users[0],
                    Comments = comments.Where(c => c.EventId == 3).ToList()
                },
                new Domain.Entity.Event()
                {
                    Id = 4,
                    Title = "Test4",
                    Description = "Test4Desc",
                    Label = "Test4Label",
                    EventDate = DateTime.Now.AddDays(6),
                    EndEventDate = DateTime.Now.AddDays(6).AddHours(1),
                    UserId = users[1].Id,
                    User = users[1],
                    Comments = comments.Where(c => c.EventId == 4).ToList()
                },
                new Domain.Entity.Event()
                {
                    Id = 5,
                    Title = "Test5",
                    Description = "Test5Desc",
                    Label = "Test5Label",
                    EventDate = DateTime.Now.AddDays(11),
                    EndEventDate = DateTime.Now.AddDays(11).AddHours(2),
                    UserId = users[1].Id,
                    User = users[1],
                    Comments = comments.Where(c => c.EventId == 5).ToList()
                },
                new Domain.Entity.Event()
                {
                    Id = 6,
                    Title = "Test6",
                    Description = "Test6Desc",
                    Label = "Test6Label",
                    EventDate = DateTime.Now.AddDays(16),
                    EndEventDate = DateTime.Now.AddDays(16).AddHours(3),
                    UserId = users[1].Id,
                    User = users[1],
                    Comments = comments.Where(c => c.EventId == 6).ToList()
                },
                new Domain.Entity.Event()
                {
                    Id = 7,
                    Title = "Test7",
                    Description = "Test7Desc",
                    Label = "Test7Label",
                    EventDate = DateTime.Now.AddDays(7),
                    EndEventDate = DateTime.Now.AddDays(7).AddHours(1),
                    UserId = users[2].Id,
                    User = users[2],
                    Comments = comments.Where(c => c.EventId == 7).ToList()
                },
                new Domain.Entity.Event()
                {
                    Id = 8,
                    Title = "Test8",
                    Description = "Test8Desc",
                    Label = "Test8Label",
                    EventDate = DateTime.Now.AddDays(12),
                    EndEventDate = DateTime.Now.AddDays(12).AddHours(2),
                    UserId = users[2].Id,
                    User = users[2],
                    Comments = comments.Where(c => c.EventId == 8).ToList()
                },
                new Domain.Entity.Event()
                {
                    Id = 9,
                    Title = "Test9",
                    Description = "Test9Desc",
                    Label = "Test9Label",
                    EventDate = DateTime.Now.AddDays(17),
                    EndEventDate = DateTime.Now.AddDays(17).AddHours(3),
                    UserId = users[2].Id,
                    User = users[2],
                    Comments = comments.Where(c => c.EventId == 9).ToList()
                }
            };
        }

        public static List<Domain.Entity.AccesRequest> GetAccesRequests()
        {
            var users = GetUsers();

            return new List<Domain.Entity.AccesRequest>()
            {
                new Domain.Entity.AccesRequest()
                {
                    Id = 1,
                    IsAccepted = true,
                    FromUserId = users[0].Id,
                    FromUser = users[0],
                    ToUserId = users[1].Id,
                    ToUser = users[1]
                },
                new Domain.Entity.AccesRequest()
                {
                    Id = 2,
                    IsAccepted = true,
                    FromUserId = users[1].Id,
                    FromUser = users[1],
                    ToUserId = users[0].Id,
                    ToUser = users[0]
                },new Domain.Entity.AccesRequest()
                {
                    Id = 3,
                    IsAccepted = true,
                    FromUserId = users[0].Id,
                    FromUser = users[0],
                    ToUserId = users[2].Id,
                    ToUser = users[2]
                },
                new Domain.Entity.AccesRequest()
                {
                    Id = 4,
                    IsAccepted = false,
                    FromUserId = users[2].Id,
                    FromUser = users[2],
                    ToUserId = users[1].Id,
                    ToUser = users[1]
                }
            };
        }

        public static List<Domain.Entity.Comment> GetComments()
        {
            var users = GetUsers();
            var events = GetEvents();

            return new List<Domain.Entity.Comment>()
            {
                new Domain.Entity.Comment()
                {
                    Id = 1,
                    Message = "Test1Message",
                    EventId = events[0].Id,
                    Event = events[0],
                    UserId = users[0].Id,
                    User = users[0]
                },
                new Domain.Entity.Comment()
                {
                    Id = 2,
                    Message = "Test2Message",
                    EventId = events[0].Id,
                    Event = events[0],
                    UserId = users[0].Id,
                    User = users[0]
                },
                new Domain.Entity.Comment()
                {
                    Id = 3,
                    Message = "Test3Message",
                    EventId = events[0].Id,
                    Event = events[0],
                    UserId = users[1].Id,
                    User = users[1]
                },
                new Domain.Entity.Comment()
                {
                    Id = 4,
                    Message = "Test4Message",
                    EventId = events[0].Id,
                    Event = events[0],
                    UserId = users[1].Id,
                    User = users[1]
                }
            };
        }
    }
}
