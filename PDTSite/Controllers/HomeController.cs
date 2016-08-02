using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PDTSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "UW-Madison Phi Delta Theta Alpha Chapter";
            return View();
        }
        public ActionResult MeetTheBrothers()
        {
            ViewBag.Message = "This is where we will put the information about the brothers.";

            return View();
        }
        public ActionResult JoinUs()
        {
            ViewBag.Message = "This is where we will put the information about the brothers.";

            return View();
        }
        public ActionResult Teaser()
        {
            return View();
        }

    }
}