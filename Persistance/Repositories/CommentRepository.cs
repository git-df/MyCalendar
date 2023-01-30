using Persistance.Data;
using Persistance.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly mcContext _context;

        public CommentRepository(mcContext context)
        {
            _context = context;
        }
    }
}
