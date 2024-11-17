using PROG7312_POE.Class.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG7312_POE.Class.Models
{
    //-------------------------------------------------------------------------------------
    /// <summary>
    /// 
    /// </summary>
    public class EventClass
    {
        public int EventID { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public RequestCategory EventCategory { get; set; }

        public EventClass() { }

        public EventClass(int eventid, string eventName, DateTime eventDate, RequestCategory eventcategory)
        {
            EventID = eventid;
            EventName = eventName;
            EventDate = eventDate;
            EventCategory = eventcategory;
        }
    }
}
//-----------------------------------...ooo000 END OF FILE 000ooo...-----------------------------------//