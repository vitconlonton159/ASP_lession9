﻿using System.Web;
using System.Web.Mvc;

namespace LHL_lesson09
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
