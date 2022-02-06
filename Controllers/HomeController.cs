using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVRWebsite_Unibit_5sem_MWT_MVC.Controllers
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
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Guide()
        {
            return View("MVR/Guide");
        }

        public ActionResult BoikoRashkov()
        {
            return View("MVR/BoikoRashkov");
        }
        
        public ActionResult PoliticalCabinet()
        {
            return View("MVR/PoliticalCabinet");
        }
    }
}