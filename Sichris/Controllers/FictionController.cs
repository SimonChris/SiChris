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
      return View();
    }
  }
}