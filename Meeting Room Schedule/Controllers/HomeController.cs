using EventsData;
using Meeting_Room_Schedule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meeting_Room_Schedule.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string roomParam = Request.QueryString["room"];
            int roomNumber;
            bool isInt = int.TryParse(roomParam, out roomNumber);
            if (isInt)
            {
                List<EventTable2> events = GetEventsData(roomNumber);
                WorkingDay today = CreateModel(events);
                return View(today);
            }
            else
            {
                return RedirectToAction("Error");
            }

        }

        private static WorkingDay CreateModel(List<EventTable2> events)
        {
            WorkingDay today = new WorkingDay();
            today.CurrentDate = string.Format("{0:dddd dd MMMMMMMMM}", DateTime.Now);
            today.CurrentTime = string.Format("{0:HH:mm}", DateTime.Now);

            today.IsAvailable = true;
            foreach (var item in events)
            {
                if (DateTime.Now >= item.EventStart && DateTime.Now <= item.EventEnd)
                    today.IsAvailable = false;
                today.Booker = item.EventOrganiser;
            }

            today.Slots = new DaySlot[20];
            for (int i = 0; i < 20; i++)
            {
                DaySlot current = new DaySlot();
                current.End = DateTime.Today.AddHours(8).AddMinutes(i * 30 + 30);
                current.Start = DateTime.Today.AddHours(8).AddMinutes(i * 30);

                current.MeetingName = "";

                foreach (var item in events)
                {
                    if (current.Start == item.EventStart)
                    {
                        current.MeetingName = item.EventName;
                        current.BookedBy = item.EventOrganiser;
                        current.MeetingStartAndEndDesc = string.Format("{0:HH:mm} - {1:HH:mm}", item.EventStart, item.EventEnd);
                    }

                    if (current.Start >= item.EventStart && current.End <= item.EventEnd)
                    {
                        current.IsBooked = true;
                    }
                }

                today.Slots[i] = current;

            }

            return today;
        }

        private static List<EventTable2> GetEventsData(int roomNumber)
        {
            EventsDataContext ctx = new EventsDataContext();
            var query = from e in ctx.EventTable2s
                        where (e.EventStart.Value.Date == DateTime.Today
                            || e.EventEnd.Value.Date == DateTime.Today)
                            && e.EventRoomNumber == roomNumber
                        select e;

            return query.ToList();
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}