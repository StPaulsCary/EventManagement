using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagement.Web.Controllers
{
    public class EventController : Controller
    {
        // GET: Event

        public ActionResult EventHome(string eventShortName)
        {
            ViewBag.Message = eventShortName;
            return View();
        }
    }
}