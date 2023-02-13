using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Persistance.Data;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class AccesRequestRepository : IAccesRequestRepository
    {
        private readonly mcContext _context;

        public AccesRequestRepository(mcContext context)
        {
            _context = context;
        }

        public async Task<AccesRequest> CheckAcces(Guid fromUser, Guid toUser)
        {
            return await _context.AccesRequests
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.FromUserId == fromUser && a.ToUserId == toUser && a.IsAccepted);
        }
    }
}
