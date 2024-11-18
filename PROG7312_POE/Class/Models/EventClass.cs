using PROG7312_POE.Class.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Class.Models
{
    public class EventClass
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public RequestCategory EventCategory { get; set; }
        public SouthAfricanCities EventLocation { get; set; }

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Primary Constructor
        /// </summary>
        public EventClass() { }

         //-------------------------------------------------------------------------------------
        /// <summary>
        /// Constructor to initialize data
        /// </summary>
        public EventClass(int eventid, string eventName, DateTime eventDate, RequestCategory eventcategory, SouthAfricanCities eventlocation)
        {
            EventID = eventid;
            EventName = eventName;
            EventDate = eventDate;
            EventCategory = eventcategory;
            EventLocation = eventlocation;
        }
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//