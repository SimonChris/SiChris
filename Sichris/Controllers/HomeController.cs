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
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult Support()
        {
            return View();
        }

        public ActionResult Donate()
        {
          return View();
        }

        public ActionResult Contact()
        {
          ViewBag.Email = "simon@sichris.com";
          return View();
        }

        public ActionResult ContactJuggling()
        {
            return View();
        }      

    }
}