using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.DummyData
{
    public class DummyAccesRequests
    {
        public static List<AccesRequest> GetAccesRequests()
        {
            var users = DummyUsers.GetUsers();

            return new List<AccesRequest>()
            {
                new AccesRequest()
                {
                    Id = 1,
                    IsAccepted = true,
                    FromUserId = users[2].Id,
                    ToUserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new AccesRequest()
                {
                    Id = 2,
                    IsAccepted = true,
                    FromUserId = users[3].Id,
                    ToUserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new AccesRequest()
                {
                    Id = 3,
                    IsAccepted = false,
                    FromUserId = users[4].Id,
                    ToUserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new AccesRequest()
                {
                    Id = 4,
                    IsAccepted = false,
                    FromUserId = users[5].Id,
                    ToUserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new AccesRequest()
                {
                    Id = 5,
                    IsAccepted = true,
                    FromUserId = users[6].Id,
                    ToUserId = users[1].Id,
                    CreatedBy = "SYSTEM"
                },
                new AccesRequest()
                {
                    Id = 6,
                    IsAccepted = true,
                    FromUserId = users[7].Id,
                    ToUserId = users[1].Id,
                    CreatedBy = "SYSTEM"
                },
                new AccesRequest()
                {
                    Id = 7,
                    IsAccepted = false,
                    FromUserId = users[8].Id,
                    ToUserId = users[1].Id,
                    CreatedBy = "SYSTEM"
                },
                new AccesRequest()
                {
                    Id = 8,
                    IsAccepted = false,
                    FromUserId = users[9].Id,
                    ToUserId = users[1].Id,
                    CreatedBy = "SYSTEM"
                }
            };
        }
    }
}
