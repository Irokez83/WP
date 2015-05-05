using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WishApp.Controllers
{
    //Home Controller renamed to Extra Controller
    public class ExtraController : Controller
    {
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }
    }
}