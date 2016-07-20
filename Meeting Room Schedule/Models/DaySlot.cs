using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meeting_Room_Schedule.Models
{
    public class DaySlot
    {
        public bool IsBooked { get; set;}
        public string BookedBy { get; set; }
        public string MeetingName { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string MeetingStartAndEndDesc { get; set; }
     }
}