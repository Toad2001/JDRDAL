using JDRBusiness.Models;
using JDRHelper.Models;
using JDRHelper.Models.ViewModel;
using JDRHelper.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToolBox.MappeurGeneric;

namespace JDRHelper.Controllers
{
    public class PJ_StatController : Controller
    {
        private H_PJDetailsService pjDetSer = new H_PJDetailsService();
        private H_PJService pjSer = new H_PJService();

        // GET: PJ_Stat
        [CustomAuth("Admin","User")]
        public ActionResult Details(int id)
        {
            H_PJ h_PJ = pjSer.Get(id);
            h_PJ.Details = pjSer.GetAll(h_PJ.Id).ToList();

            return View(h_PJ.Details);
        }

        [CustomAuth("Admin")]
        [HttpPost]
        public ActionResult Edit(H_PJDetails item)
        {
            bool temp = pjDetSer.Update(item.Id,item);
            H_PJ h_PJ = pjDetSer.GetPJbyStat(item.Id);
            return RedirectToAction("Details", "PJ" , new { h_PJ.Id });
        }

        [CustomAuth("Admin")]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            H_PJDetails detail = pjDetSer.Get(id);

            return View(detail);
        }
    }
}