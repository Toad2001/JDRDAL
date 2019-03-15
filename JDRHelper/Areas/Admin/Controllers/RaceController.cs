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
    public class RaceController : Controller
    {
        private H_RaceService raceService = new H_RaceService();

        // GET: Race
        public ActionResult Index()
        {
            IEnumerable<H_Race> race = raceService.Get();
            return View(race);
        }

        public ActionResult Details(int id)
        {
            H_Race h_race = raceService.Get(id);
            h_race.Details = raceService.GetAll(h_race.Id).ToList();
            return View(h_race);
        }
    }
}