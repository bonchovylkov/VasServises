﻿using System.Web;
using System.Web.Mvc;

namespace MasterMind.WebServices
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
