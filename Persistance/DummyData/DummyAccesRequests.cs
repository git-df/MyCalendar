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
                    IsAccepted = false,
                    FromUserId = users[0].Id,
                    ToUserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new AccesRequest()
                {
                    Id = 2,
                    IsAccepted = false,
                    FromUserId = users[0].Id,
                    ToUserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new AccesRequest()
                {
                    Id = 3,
                    IsAccepted = false,
                    FromUserId = users[0].Id,
                    ToUserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                }
            };
        }
    }
}
