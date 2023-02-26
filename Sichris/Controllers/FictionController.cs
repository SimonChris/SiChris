using Sichris.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sichris.Controllers
{
  public class FictionController : Controller
  {
    //
    // GET: /Fiction/
    public ActionResult Index() {
        AnalyticsModel.IncrementCount("Fiction");

        return View();
    }
  }
}