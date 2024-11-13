using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE
{
    public class EventClass
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventCategory { get; set; }

        public EventClass() { }

        public EventClass(int eventid, string eventName, DateTime eventDate, string eventcategory)
        {
            EventID = eventid;
            EventName = eventName;
            EventDate = eventDate;
            EventCategory = eventcategory;
        } 
    }
}
