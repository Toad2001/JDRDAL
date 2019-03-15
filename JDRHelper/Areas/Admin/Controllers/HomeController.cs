using JDRHelper.Models;
using JDRHelper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JDRHelper.Areas.Admin.Controllers
{
    [CustomAuth("Admin")]
    public class HomeController : Controller
    {
        H_UtilisateurService us = new H_UtilisateurService(); 

        // GET: Admin/Home
        public ActionResult Index()
        {
            List<H_Utilisateur> lesUSers = us.Get().ToList();

            return View(lesUSers);
        }

        public ActionResult Delete(int id)
        {
            us.Delete(id);

            return RedirectToAction("Index");
        }
    }
}