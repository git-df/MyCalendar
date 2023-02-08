using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.GridFilters
{
    public class CalendarFilter
    {
        public DateTime FromDate { get; set; } = DateTime.UtcNow;
        public DateTime ToDate { get; set; } = DateTime.UtcNow.AddMonths(1);
        public string Filter { get; set; } = null;
    }
}
