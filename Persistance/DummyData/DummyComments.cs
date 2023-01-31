using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.DummyData
{
    public class DummyComments
    {
        public static List<Comment> GetComments()
        {
            var users = DummyUsers.GetUsers();

            return new List<Comment>()
            {
                new Comment()
                {
                    Id = 1,
                    Message = "Na pewno wpadnę",
                    EventId = 1,
                    UserId = users[2].Id,
                    CreatedBy = "SYSTEM"
                },
                new Comment()
                {
                    Id = 2,
                    Message = "Mam już prezent",
                    EventId = 1,
                    UserId = users[3].Id,
                    CreatedBy = "SYSTEM"
                },
                new Comment()
                {
                    Id = 3,
                    Message = "Mogę kierować",
                    EventId = 6,
                    UserId = users[6].Id,
                    CreatedBy = "SYSTEM"
                },
                new Comment()
                {
                    Id = 4,
                    Message = "O której jedziemy?",
                    EventId = 6,
                    UserId = users[7].Id,
                    CreatedBy = "SYSTEM"
                }
            };
        }
    }
}
