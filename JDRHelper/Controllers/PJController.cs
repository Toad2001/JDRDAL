using JDRBusiness.Models;
using JDRBusiness.Services;
using JDRHelper.Infrastructure;
using JDRHelper.Models;
using JDRHelper.Services;
using JDRHelper.Services.IntermediaireS;
using JDRHelper.Services.ObjetS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace JDRHelper.Controllers
{
    public class PJController : Controller
    {
        private H_PJService pjService = new H_PJService();
        private H_RaceService raceService = new H_RaceService();
        private H_ClasseService classeService = new H_ClasseService();
        private H_SigneService signeService = new H_SigneService();
        private H_EquipementService equipementService = new H_EquipementService();
        private H_PJ_EquipementService pjequipementService = new H_PJ_EquipementService();
        private H_MatiereService matiereService = new H_MatiereService();
        private H_ArmeService armeService = new H_ArmeService();
        private H_ArmureService armureService = new H_ArmureService();
        private H_StyleService styleService = new H_StyleService();
        private H_EnchantementService enchantService = new H_EnchantementService();
        private B_PJ_UserService pJUserService = new B_PJ_UserService();


        // GET: PJ
        //[CustomAuth("Admin,User")]
        public ActionResult Index()
        {
            IEnumerable<H_PJ> pjs = pjService.Get();
            List<H_PJ> list = pjs.ToList();
            foreach (H_PJ item in list)
            {
                item.Race = raceService.Get(item.Id_Race);
                item.Classe = classeService.Get(item.Id_Classe);
                item.Signe = signeService.Get(item.Id_Signe);
            }
            return View(pjs);
        }

        //[CustomAuth("Admin,User")]
        public ActionResult Details(int id)
        {
            H_PJ h_PJ = pjService.Get(id);
            h_PJ.Race = raceService.Get(h_PJ.Id_Race);
            h_PJ.Classe = classeService.Get(h_PJ.Id_Classe);
            h_PJ.Signe = signeService.Get(h_PJ.Id_Signe);
            h_PJ.Details = pjService.GetAll(h_PJ.Id).ToList();
            h_PJ.Race.Details = raceService.GetAll(h_PJ.Id_Race).ToList();
            h_PJ.Classe.Details = classeService.GetAll(h_PJ.Id_Classe).ToList();
            h_PJ.Equipement = equipementService.GetForPJ(h_PJ.Id).ToList();
            foreach (var item in h_PJ.Equipement)
            {
                if (item.Id_Arme != null)
                {
                    item.Arme = armeService.Get((int)item.Id_Arme);
                    item.Arme.Details = armeService.GetAll((int)item.Id_Arme).ToList();
                    item.Matiere = matiereService.Get(item.Id_Matiere);
                    item.Matiere.Details = matiereService.GetAll(item.Id_Matiere).ToList();
                    item.Style = styleService.Get(item.Id_Style);

                    if (item.Id_Enchantement != null)
                    {
                        item.Enchantement = enchantService.Get((int)item.Id_Enchantement);
                        item.Enchantement.Details = enchantService.GetAll((int)item.Id_Enchantement).ToList();
                    }
                }

                if (item.Id_Armure != null)
                {
                    item.Armure = armureService.Get((int)item.Id_Armure);
                    item.Armure.Details = armureService.GetAll((int)item.Id_Armure).ToList();

                    item.Matiere = matiereService.Get(item.Id_Matiere);
                    item.Matiere.Details = matiereService.GetAll(item.Id_Matiere).ToList();
                    item.Style = styleService.Get(item.Id_Style);

                    if (item.Id_Enchantement != null)
                    {
                        item.Enchantement = enchantService.Get((int)item.Id_Enchantement);
                        item.Enchantement.Details = enchantService.GetAll((int)item.Id_Enchantement).ToList();
                    }
                }
            }

            return View(h_PJ);
        }

        [CustomAuth("Admin,User")]
        [HttpPost]
        public ActionResult Create(H_PJ item)
        {
            item.Race = raceService.Get((int)item.SelectedRace);
            item.Classe = classeService.Get((int)item.SelectedClasse);
            item.Signe = signeService.Get((int)item.SelectedSigne);

            item.Id_Race = (int)item.SelectedRace;
            item.Id_Classe = (int)item.SelectedClasse;
            item.Id_Signe = (int)item.SelectedSigne;

            H_PJ temp = pjService.Insert(item);

            B_PJ_User pjuser = new B_PJ_User()
            {
                Id_PJ = temp.Id,
                Id_User = TheSession.CurrentUser.Id,
            };

            pJUserService.Insert(pjuser);

            return RedirectToAction("Index");
        }

        [CustomAuth("Admin,User")]
        [HttpGet]
        public ActionResult Create()
        {
            return View(new H_PJ());
        }

        [CustomAuth("Admin")]
        public ActionResult Delete(int id)
        {
            bool temp = pjService.Delete(id);
            return RedirectToAction("Index");
        }

        [CustomAuth("Admin")]
        [HttpPost]
        public ActionResult Edit(H_PJ item)
        {
            bool temp = pjService.Update(item.Id, item);


            return RedirectToAction("Index");
        }

        [CustomAuth("Admin")]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            H_PJ pj = pjService.Get(id);

            pj.Details = pjService.GetAll(id).ToList();

            return View(pj);
        }

        [CustomAuth("Admin,User")]
        [HttpGet]
        public ActionResult Equipe()
        {
            ViewBag.Equipement = new MultiSelectList(new H_EquipementService().Get(), "Id");
            return View();
        }

        //[HttpPost]
        //public ActionResult Equipe(int[] Id_Equipement)
        //{
        //    foreach (int item in Id_Equipement)
        //    {
        //        pjequipementService.Post(new )
        //    }
        //}
    }
}