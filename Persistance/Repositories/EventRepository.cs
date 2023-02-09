using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Persistance.Data;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Globalization;
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

        //do usunięcia
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

        public async Task<(List<Event>, int)> GetFiltredEventsByUserId(Guid userid, DateTime fromDate, DateTime toDate, string filter, int count, int page, string orderBy)
        
        {
            var query = _context.Events
                .Where(e => e.UserId == userid && e.EventDate >= fromDate && e.EventDate < toDate)
                .Where(e => filter == null ||
                    e.Title.ToLower().Contains(filter.ToLower()) ||
                    e.Label.ToLower().Contains(filter.ToLower()));

            var totalCount = await query.CountAsync();

            if (!orderBy.IsNullOrEmpty())
            {
                switch (orderBy)
                {
                    case "title": query = query.OrderBy(e => e.Title); break;
                    case "title_desc": query = query.OrderByDescending(e => e.Title); break;
                    case "label": query = query.OrderBy(e => e.Label); break;
                    case "label_desc": query = query.OrderByDescending(e => e.Label); break;
                    case "description": query = query.OrderBy(e => e.Description); break;
                    case "description_desc": query = query.OrderByDescending(e => e.Description); break;
                    case "date": query = query.OrderBy(e => e.EventDate); break;
                    case "date_desc": query = query.OrderByDescending(e => e.EventDate); break;
                    case "endDate": query = query.OrderBy(e => e.EndEventDate); break;
                    case "endDate_desc": query = query.OrderByDescending(e => e.EndEventDate); break;
                }
            }

            var events = await query
                .Skip((page - 1) * count)
                .Take(count)
                .AsNoTracking()
                .ToListAsync();

            return (events, totalCount);
        }
    }
}
