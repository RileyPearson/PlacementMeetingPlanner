using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Meeting_Room_Schedule.Models
{
    public class WorkingDay
    {
        public string CurrentDate { get; set; }
        public string CurrentTime { get; set; }
        public bool IsAvailable { get; set; }
        public string Booker { get; set; }
        public DaySlot[] Slots { get; set; }
    }
}