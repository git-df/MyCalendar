using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class CommentOnEventModel
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public string Author { get; set; }
    }
}
