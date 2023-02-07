using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Persistance.Data;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly mcContext _context;

        public EventRepository(mcContext context)
        {
            _context = context;
        }

        public async Task<(List<Event> events, int totalCount)> GetEventsWithComments(
            Guid userid, 
            DateTime fromDate, 
            DateTime toDate, 
            string filter, 
            int pageNumber, 
            int pageSize, 
            string sortBy, 
            bool sortByDesc)
        {
            var events = _context.Events
                .Where(e => e.UserId == userid && e.EventDate >= fromDate && e.EventDate < toDate)
                .Where(e => filter == null || 
                    e.Title.ToLower().Contains(filter.ToLower()) || 
                    e.Label.ToLower().Contains(filter.ToLower()));

            var totalCount = await events.CountAsync();

            if (!sortBy.IsNullOrEmpty())
            {
                var columnSelector = new Dictionary<string, Expression<Func<Event, object>>>
                {
                    { nameof(Event.Title), e => e.Title },
                    { nameof(Event.Label), e => e.Label },
                    { nameof(Event.EventDate), e => e.EventDate },
                    { nameof(Event.EndEventDate), e => e.EventDate }
                };

                events = sortByDesc
                    ? events.OrderByDescending(columnSelector[sortBy])
                    : events.OrderBy(columnSelector[sortBy]);
            }

            var eventsOnPage = await events.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToListAsync();

            return ( eventsOnPage, totalCount );
        }
    }
}
