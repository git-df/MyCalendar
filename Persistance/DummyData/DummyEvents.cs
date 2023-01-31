using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.DummyData
{
    public class DummyEvents
    {
        public static List<Event> GetEvents()
        {
            var users = DummyUsers.GetUsers();

            return new List<Event>()
            {
                new Event()
                {
                    Id = 1,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 2,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 3,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 4,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 5,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 6,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 7,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 8,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 9,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 10,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 11,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 12,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 13,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 14,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 15,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 16,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 17,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 18,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 19,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 20,
                    Title = "",
                    Description = "",
                    Label = "",
                    EventDate = new DateTime(1,1,1),
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                }
            };
        }
    }
}
