﻿using System.Web;
using System.Web.Mvc;

namespace bansachonline1460372
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
