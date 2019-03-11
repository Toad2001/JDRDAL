using JDRHelper.Models;
using JDRHelper.Services;
using JDRHelper.Services.ObjetS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JDRHelper.Controllers
{
    public class EquipementController : Controller
    {

        private H_EquipementService equipementService = new H_EquipementService();
        private H_MatiereService matiereService = new H_MatiereService();
        private H_ArmeService armeService = new H_ArmeService();
        private H_ArmureService armureService = new H_ArmureService();
        private H_StyleService styleService = new H_StyleService();
        private H_EnchantementService enchantService = new H_EnchantementService();


        // GET: Equipement
        public ActionResult Index()
        {
            IEnumerable<H_Equipement> equipements = equipementService.Get().ToList();
            foreach (var item in equipements)
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
            return View(equipements);
        }

        public ActionResult DetailsArme(int id)
        {
            H_Equipement h_equipement = equipementService.Get(id);
            h_equipement.Arme = armeService.Get((int)h_equipement.Id_Arme);
            h_equipement.Arme.Details = armeService.GetAll((int)h_equipement.Id_Arme).ToList();
            h_equipement.Matiere = matiereService.Get(h_equipement.Id_Matiere);
            h_equipement.Matiere.Details = matiereService.GetAll(h_equipement.Id_Matiere).ToList();
            h_equipement.Style = styleService.Get(h_equipement.Id_Style);

            if (h_equipement.Id_Enchantement != null)
            {
                h_equipement.Enchantement = enchantService.Get((int)h_equipement.Id_Enchantement);
                h_equipement.Enchantement.Details = enchantService.GetAll((int)h_equipement.Id_Enchantement).ToList();
            }

            return View(h_equipement);
        }

        public ActionResult DetailsArmure(int id)
        {
            H_Equipement h_equipement = equipementService.Get(id);


            h_equipement.Armure = armureService.Get((int)h_equipement.Id_Armure);
            h_equipement.Armure.Details = armureService.GetAll((int)h_equipement.Id_Armure).ToList();

            h_equipement.Matiere = matiereService.Get(h_equipement.Id_Matiere);
            h_equipement.Matiere.Details = matiereService.GetAll(h_equipement.Id_Matiere).ToList();
            h_equipement.Style = styleService.Get(h_equipement.Id_Style);

            if (h_equipement.Id_Enchantement != null)
            {
                h_equipement.Enchantement = enchantService.Get((int)h_equipement.Id_Enchantement);
                h_equipement.Enchantement.Details = enchantService.GetAll((int)h_equipement.Id_Enchantement).ToList();
            }

            return View(h_equipement);
        }
    }
}