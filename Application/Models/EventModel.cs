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

    public class EventCalendarModel
    {
        public List<EventOnListModel> Events { get; set; }
        public int TotalPages { get; set; }
        public int EventsFrom { get; set; }
        public int EventsTo { get; set; }
        public int TotalCount { get; set; }
    }
}
