using Sichris.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sichris.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Random random = new Random();
            ViewBag.Number = random.Next(0, 3);

            AnalyticsModel.IncrementCount("Home");
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Support()
        {
            AnalyticsModel.IncrementCount("Support");

            return View();
        }

        public ActionResult Donate()
        {
          return View();
        }

        public ActionResult Contact()
        {
            AnalyticsModel.IncrementCount("Contact");
            ViewBag.Email = "simon@sichris.com";
            ViewBag.Mastodon = "https://mastodon.gamedev.place/@simonchris1729";
            ViewBag.Bluesky = "https://bsky.app/profile/simonchris.bsky.social";
            return View();
        }

        public ActionResult ContactJuggling()
        {
            return View();
        }      

    }
}