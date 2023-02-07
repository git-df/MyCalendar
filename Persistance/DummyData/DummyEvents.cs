using Domain.Entity;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
                    Title = "Moje urodziny",
                    Description = "Wielkie święto",
                    Label = "Urodziny",
                    EventDate = new DateTime(2000,12,12),
                    EndEventDate = new DateTime(2000,12,12).AddHours(1),
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 2,
                    Title = "Wakacje",
                    Description = "Wyjazd do Włoch",
                    Label = "Wycieczka",
                    EventDate = new DateTime(2024,06,01),
                    EndEventDate = new DateTime(2024,06,01).AddHours(1),
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 3,
                    Title = "Urodziny Adama",
                    Description = "Nie zapomnij wziąść wolne w pracy",
                    Label = "Urodziny",
                    EventDate = new DateTime(2000,01,10),
                    EndEventDate = new DateTime(2000,01,10).AddHours(1),
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 4,
                    Title = "Rachunek za prąd",
                    Description = "Nie zapomnij zapłacić",
                    Label = "Rachunki",
                    EventDate = new DateTime(2000,01,01),
                    EndEventDate = new DateTime(2000,01,01).AddHours(1),
                    UserId = users[1].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 5,
                    Title = "Rachunek za wodę",
                    Description = "Termin do końca miesiąca",
                    Label = "Rachunki",
                    EventDate = new DateTime(2000,01,10),
                    EndEventDate = new DateTime(2000,01,10).AddHours(1),
                    UserId = users[1].Id,
                    CreatedBy = "SYSTEM"
                },
                new Event()
                {
                    Id = 6,
                    Title = "Koncert",
                    Description = "Koncert w Warszawie",
                    Label = "Rozrywka",
                    EventDate = new DateTime(2025,08,15),
                    EndEventDate = new DateTime(2025,08,15).AddHours(1),
                    UserId = users[1].Id,
                    CreatedBy = "SYSTEM"
                }
            };
        }
    }
}
