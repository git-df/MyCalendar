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

    public class EventListModel
    {
        public List<EventOnListModel> Events { get; set; }
        public int EventsCount { get; set; } = 0;
        public int PagesCount { get; set; } = 1;
        public int FirstEventNumber { get; set; }
        public int LastEventNumber { get; set; }
        public string OrderTitleRoute { get; set; } = string.Empty;
        public string OrderLabeleRoute { get; set; } = string.Empty;
        public string OrderDateRoute { get; set; } = string.Empty;
        public string OrderEndDateRoute { get; set; } = string.Empty;
        public int CurrentPage { get; set; } = 1;
        public int CurrentSize { get; set; } = 1;
        public string CurrentOrder { get; set; } = string.Empty;
    }


    //to usunięcia
    public class EventCalendarModel
    {
        public List<EventOnListModel> Events { get; set; }
        public int TotalPages { get; set; }
        public int EventsFrom { get; set; }
        public int EventsTo { get; set; }
        public int TotalCount { get; set; }
    }
}
