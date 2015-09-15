using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sichris.Controllers
{
  public class GamesController : Controller
  {
    //
    // GET: /Games/
    public ActionResult Index() {
      return View();
    }
    public ActionResult Cuff() {
      return View();
    }

    public ActionResult PataNoir() {
      return View();
    }

    public ActionResult AlethiCorp() {
      return View();
    }

    public ActionResult Vigilance() {
      return View();
    }

    public ActionResult Grief() {
      return View();
    }

    public ActionResult TrappedInTime() {
      return View();
    }
  }
}