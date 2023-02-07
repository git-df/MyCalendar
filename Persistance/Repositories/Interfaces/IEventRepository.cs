using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories.Interfaces
{
    public interface IEventRepository
    {
        Task<(List<Event> events, int totalCount)> GetEventsWithComments(
            Guid userid, 
            DateTime fromDate, 
            DateTime toDate, 
            string filter, 
            int pageNumber, 
            int pageSize, 
            string sortBy, 
            bool sortByDesc
            );
    }
}
