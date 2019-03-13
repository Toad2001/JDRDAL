using JDRHelper.Infrastructure;
using JDRHelper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JDRHelper.Controllers
{
    //[CustomAuth("Admin,User")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Description de l'application";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contactez nous";

            return View();
        }

        public ActionResult Connection()
        {
            ViewBag.Message = "Connection";

            return RedirectToAction("Connection","Utilisateur");
        }
    }
}