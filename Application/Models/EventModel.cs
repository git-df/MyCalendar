using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class EventOnListModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Label { get; set; }
        public DateTime EventDate { get; set; }
        public DateTime? EndEventDate { get; set; }
    }

    public class EventsListModel
    {
        public List<EventOnListModel> Events { get; set; }
        public int TotalPages { get; set; }
        public int EventsFrom { get; set; }
        public int EventsTo { get; set; }
        public int TotalCount { get; set; }
    }

    public class EventInputModel
    {
        public Guid userid { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public string filter { get; set; }
        public int pageNumber { get; set; }
        public int pageSize { get; set; }
        public string sortBy { get; set; }
        public bool sortByDesc { get; set; }
    }
}
