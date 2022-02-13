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
        public ActionResult International()
        {
            return View("MVR/International");
        }
        public ActionResult NormativeActs()
        {
            return View("MVR/NormativeActs");
        }

        public ActionResult CouncilsAndCommissions()
        {
            return View("MVR/CouncilsAndCommissions");
        }

        public ActionResult RegisterZPKONPI()
        {
            return View("MVR/RegisterZPKONPI");
        }

        public ActionResult Uniforms()
        {
            return View("MVR/Uniforms");
        }

        public ActionResult History()
        {
            return View("MVR/History");
        }

        public ActionResult Museum()
        {
            return View("MVR/Museum");
        }

        public ActionResult UsefulForYou()
        {
            return View("MVR/UsefulForYou");
        }

        public ActionResult Contacts()
        {
            return View("MVR/Contacts");
        }

        public ActionResult ReferenceId()
        {
            return View("Administration/ReferenceId");
        }

        public ActionResult ReferenceBgId()
        {
            return View("Administration/ReferenceBgId");
        }

        public ActionResult Coruption()
        {
            return View("MVR/Coruption");
        }

        public ActionResult EUslugi()
        {
            return View("Administration/EUslugi");
        }

        public ActionResult Brexit()
        {
            return View("Brexit/Brexit");
        }

    }
}