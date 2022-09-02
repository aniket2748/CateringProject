using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Caters.Web.Controllers
{
    public class NonVegController : Controller
    {
        // GET: NonVeg
        public ActionResult NonVeg()
        {
            return View();
        }
        public ActionResult SoupsList()
        {
            return View();
        }
        public ActionResult StartersList()
        {
            return View();
        }
        public ActionResult MainCourseList()
        {
            return View();
        }
        public ActionResult DessertsList()
        {
            return View();
        }
    }
}