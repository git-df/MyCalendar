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
                    Message = "",
                    EventId = 1,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Comment()
                {
                    Id = 2,
                    Message = "",
                    EventId = 1,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Comment()
                {
                    Id = 3,
                    Message = "",
                    EventId = 1,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Comment()
                {
                    Id = 4,
                    Message = "",
                    EventId = 1,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Comment()
                {
                    Id = 5,
                    Message = "",
                    EventId = 1,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Comment()
                {
                    Id = 6,
                    Message = "",
                    EventId = 1,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Comment()
                {
                    Id = 7,
                    Message = "",
                    EventId = 1,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Comment()
                {
                    Id = 8,
                    Message = "",
                    EventId = 1,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Comment()
                {
                    Id = 9,
                    Message = "",
                    EventId = 1,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
                new Comment()
                {
                    Id = 10,
                    Message = "",
                    EventId = 1,
                    UserId = users[0].Id,
                    CreatedBy = "SYSTEM"
                },
            };
        }
    }
}
