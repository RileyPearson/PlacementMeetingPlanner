﻿using System.Web;
using System.Web.Mvc;

namespace Meeting_Room_Schedule
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}