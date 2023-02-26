using Sichris.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sichris.Controllers
{
    public class AnalyticsController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.StartDate = AnalyticsModel.StartDate.ToString();
            ViewBag.AnalyticsData = AnalyticsModel.AnalyticsData;

            return View();
        }

    }
}