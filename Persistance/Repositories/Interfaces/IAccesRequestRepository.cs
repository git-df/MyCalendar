using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.Interfaces
{
    public interface IAccesRequestRepository
    {
        Task<AccesRequest> CheckAcces(Guid fromUser, Guid toUser);
    }
}
