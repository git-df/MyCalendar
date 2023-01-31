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
                    Title = "Moje urodziny",
                    Description = "Wielkie święto",
                    Label = "Urodziny",
                    EventDate = new DateTime(2000,12,12),
                    MonyhlyEvent = false,
                    YearlyEvent = true,
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
                    MonyhlyEvent = false,
                    YearlyEvent = false,
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
                    MonyhlyEvent = false,
                    YearlyEvent = true,
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
                    MonyhlyEvent = true,
                    YearlyEvent = true,
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
                    MonyhlyEvent = true,
                    YearlyEvent = true,
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
                    MonyhlyEvent = false,
                    YearlyEvent = false,
                    UserId = users[1].Id,
                    CreatedBy = "SYSTEM"
                }
            };
        }
    }
}
